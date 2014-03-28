using Microsoft.SharePoint.Administration;
using System;
using System.Collections.Generic;
using System.Configuration.Provider;
using System.Linq;
using System.Net;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Management;
using System.Web.Security;

namespace ClubCloud.Provider
{
    public class ZimbraMembershipProvider : System.Web.Security.MembershipProvider
    {
        private bool Initialized;
        private string applicationName;
        private Zimbra.ZimbraServer zimbraServerClient;
        private Zimbra.ZimbraServer zimbraServer;
        private ZimbraProviderSettings zimbraSettings;
        private Zimbra.Global.VersionInfo zimbraVersion;
        private string AdminToken;

        #region Initialisation
        protected ZimbraMembershipProvider() : base()
        { 
        }

        public override void Initialize(string name, System.Collections.Specialized.NameValueCollection config)
        {
            if (HostingEnvironment.IsHosted)
            {
                NamedPermissionSet permission = HttpRuntime.GetNamedPermissionSet();
                AspNetHostingPermission aspNetHostingPermission = (AspNetHostingPermission)permission.GetPermission(typeof(AspNetHostingPermission));
                if (!(aspNetHostingPermission != null && aspNetHostingPermission.Level >= AspNetHostingPermissionLevel.Low))
                {
                    string message = String.Format("Error while initializing settings Membership Provider {0}: {1}", this.applicationName, "Zimbra Provider kan niet in AspNetHostingPermissionLevel.Low werken.");
                    LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                    throw new ProviderException(message);
                }
            }

            if (this.Initialized)
            {
                return;
            }

            if (string.IsNullOrEmpty(name))
            {
                this.applicationName = "ZimbraMembershipProvider";
            }
            else
            {
                this.applicationName = name;
            }

            try
            {
                zimbraSettings = ZimbraProviderSettings.Current;

                if(zimbraSettings == null || String.IsNullOrEmpty(zimbraSettings.ZimbraServer) || String.IsNullOrEmpty(zimbraSettings.ZimbraUserName) || String.IsNullOrEmpty(zimbraSettings.ZimbraPassword))
                {
                    string message = String.Format("Error while initializing settings Membership Provider {0}: {1}", this.applicationName, "The setting for Zimbra are not complete.");
                    LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                    throw new ProviderException(message);

                }
            }
            catch (ZimbraSettingsException zex)
            {
                string message = String.Format("Error while initializing settings Membership Provider {0}: {1}", this.applicationName, zex.Message);
                LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                throw new ProviderException(message, zex);
            }

            if (string.IsNullOrEmpty(zimbraSettings.ZimbraServer.Trim()))
            {
                string message = String.Format("Error while initializing settings Membership Provider {0}: {1}", this.applicationName, "The Zimbra server name can not be empty.");
                LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                throw new ZimbraMembershipException(message);
            }

            zimbraServer = new Zimbra.ZimbraServer(zimbraSettings.ZimbraServer);

            try
            {
                if (!zimbraServer.AuthenticatedAdmin.Value)
                {
                    AdminToken = zimbraServer.Authenticate(zimbraSettings.ZimbraUserName, zimbraSettings.ZimbraPassword, true);
                }

                using (Zimbra.Administration.GetVersionInfoResponse response = zimbraServer.Message(new Zimbra.Administration.GetVersionInfoRequest()) as Zimbra.Administration.GetVersionInfoResponse)
                {
                    if (response != null)
                    {
                        zimbraVersion = response.info;
                    }
                    else
                    {
                        string message = String.Format("Error while getting VersionInfo for {0}: {1}", this.applicationName, "The Zimbra server returned no VersionInfo.");
                        LogToULS(message, TraceSeverity.Unexpected, EventSeverity.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                string message = String.Format("Error while initializing settings Membership Provider {0}: {1}", this.applicationName, ex.Message);
                LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                throw new ProviderException(message, ex);
            }

            this.Initialized = true;
        }

        public override string ApplicationName
        {
			get
			{
                if (!Initialized)
                {
                    string message = String.Format("Membership Provider {0}: {1}", this.applicationName, "The provider was not initialized.");
                    LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                    throw new ProviderException(message);
                }

                return this.applicationName;
			}
			set
			{
                if (!this.Initialized)
                {
                    this.applicationName = value;
                }
			}
        }

        #endregion

        #region Password Methods

        public override bool ChangePassword(string username, string oldPassword, string newPassword)
        {
            bool changed = false;
            if (!Initialized)
            {
                string message = String.Format("Membership Provider {0}: {1}", this.applicationName, "The provider was not initialized.");
                LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                throw new ProviderException(message);
            }

            try
            {
                using (Zimbra.ZimbraServer clientServer = new Zimbra.ZimbraServer(zimbraSettings.ZimbraServer))
                {
                    Zimbra.Account.ChangePasswordRequest request = new Zimbra.Account.ChangePasswordRequest { account = new Zimbra.Global.accountSelector { by = Zimbra.Global.accountBy.Name, Value = username }, oldPassword = oldPassword, password = newPassword };
                    Zimbra.Account.ChangePasswordResponse response = clientServer.Message(request) as Zimbra.Account.ChangePasswordResponse;
                    string AuthToken = response.authToken;
                    ZimbraCookie(AuthToken);
                    changed = true;                    
                }
            }
            catch { }

            return changed;
        }

        public override bool ChangePasswordQuestionAndAnswer(string username, string password, string newPasswordQuestion, string newPasswordAnswer)
        {
            return false;
        }

        public override int MinRequiredPasswordLength
        {
            get 
            {
                if (zimbraSettings == null)
                {
                    return 14;
                }
                return zimbraSettings.ZimbraMinRequiredPasswordLength;
            }
        }

        public override int MinRequiredNonAlphanumericCharacters
        {
            get
            {
                if (zimbraSettings == null)
                {
                    return 3;
                }
                return zimbraSettings.ZimbraMinRequiredNonAlphanumericCharacters;

            }
        }

        public override string ResetPassword(string username, string answer)
        {
            if (!Initialized)
            {
                string message = String.Format("Membership Provider {0}: {1}", this.applicationName, "The provider was not initialized.");
                LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                throw new ProviderException(message);
            }
            throw new NotImplementedException();
        }

        public override string GetPassword(string username, string answer)
        {
            if (!Initialized)
            {
                string message = String.Format("Membership Provider {0}: {1}", this.applicationName, "The provider was not initialized.");
                LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                throw new ProviderException(message);
            }
            throw new NotImplementedException();
        }

        public virtual string GeneratePassword()
        {
            return Membership.GeneratePassword((this.MinRequiredPasswordLength < 14) ? 14 : this.MinRequiredPasswordLength, this.MinRequiredNonAlphanumericCharacters);
        }

        public override int MaxInvalidPasswordAttempts
        {
            get { throw new NotImplementedException(); }
        }

        public override int PasswordAttemptWindow
        {
            get { throw new NotImplementedException(); }
        }

        public override System.Web.Security.MembershipPasswordFormat PasswordFormat
        {
            get { return MembershipPasswordFormat.Clear; }
        }

        public override string PasswordStrengthRegularExpression
        {
            get { throw new NotImplementedException(); }
        }

        public override bool RequiresQuestionAndAnswer
        {
            get { return false; }
        }

        public override bool EnablePasswordReset
        {
            get { return true; }
        }

        public override bool EnablePasswordRetrieval
        {
            get { return false; }
        }

        public override bool RequiresUniqueEmail
        {
            get { return false; }
        }
        #endregion

        #region Query Users

        public override System.Web.Security.MembershipUserCollection FindUsersByEmail(string emailToMatch, int pageIndex, int pageSize, out int totalRecords)
        {
            if (!Initialized)
            {
                string message = String.Format("Membership Provider {0}: {1}", this.applicationName, "The provider was not initialized.");
                LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                throw new ProviderException(message);
            }
            //zmsoap -z -v SearchDirectoryRequest @offset="0" @limit="25" @sortBy="name" @sortAscending="1" @applyCos="false" @applyConfig="false" \
            //@attrs="displayName,zimbraId,zimbraAliasTargetId,cn,sn,zimbraMailHost,uid,zimbraCOSId,zimbraAccountStatus,zimbraLastLogonTimestamp, \
            //description,zimbraIsDelegatedAdminAccount,zimbraIsAdminAccount,zimbraIsSystemResource,zimbraAuthTokenValidityValue,zimbraMailStatus, \
            //zimbraIsAdminGroup,zimbraCalResType,zimbraDomainType,zimbraDomainName,zimbraDomainStatus,zimbraIsDelegatedAdminAccount,zimbraIsAdminAccount,zimbraIsSystemResource" \
            //@types="accounts" @maxResults="5000" query=""
            throw new NotImplementedException();
        }

        public override System.Web.Security.MembershipUserCollection FindUsersByName(string usernameToMatch, int pageIndex, int pageSize, out int totalRecords)
        {
            if (!Initialized)
            {
                string message = String.Format("Membership Provider {0}: {1}", this.applicationName, "The provider was not initialized.");
                LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                throw new ProviderException(message);
            }
            //zmsoap -z -v SearchDirectoryRequest @offset="0" @limit="25" @sortBy="name" @sortAscending="1" @applyCos="false" @applyConfig="false" \
            //@attrs="displayName,zimbraId,zimbraAliasTargetId,cn,sn,zimbraMailHost,uid,zimbraCOSId,zimbraAccountStatus,zimbraLastLogonTimestamp, \
            //description,zimbraIsDelegatedAdminAccount,zimbraIsAdminAccount,zimbraIsSystemResource,zimbraAuthTokenValidityValue,zimbraMailStatus, \
            //zimbraIsAdminGroup,zimbraCalResType,zimbraDomainType,zimbraDomainName,zimbraDomainStatus,zimbraIsDelegatedAdminAccount,zimbraIsAdminAccount,zimbraIsSystemResource" \
            //@types="accounts" @maxResults="5000" query=""

            throw new NotImplementedException();
        }

        public override System.Web.Security.MembershipUserCollection GetAllUsers(int pageIndex, int pageSize, out int totalRecords)
        {
            if (!Initialized)
            {
                string message = String.Format("Membership Provider {0}: {1}", this.applicationName, "The provider was not initialized.");
                LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                throw new ProviderException(message);
            }
            //zmsoap -z -v SearchDirectoryRequest @offset="0" @limit="25" @sortBy="name" @sortAscending="1" @applyCos="false" @applyConfig="false" \
            //@attrs="displayName,zimbraId,zimbraAliasTargetId,cn,sn,zimbraMailHost,uid,zimbraCOSId,zimbraAccountStatus,zimbraLastLogonTimestamp, \
            //description,zimbraIsDelegatedAdminAccount,zimbraIsAdminAccount,zimbraIsSystemResource,zimbraAuthTokenValidityValue,zimbraMailStatus, \
            //zimbraIsAdminGroup,zimbraCalResType,zimbraDomainType,zimbraDomainName,zimbraDomainStatus,zimbraIsDelegatedAdminAccount,zimbraIsAdminAccount,zimbraIsSystemResource" \
            //@types="accounts" @maxResults="5000" query=""

            throw new NotImplementedException();
        }

        public override int GetNumberOfUsersOnline()
        {
            if (!Initialized)
            {
                string message = String.Format("Membership Provider {0}: {1}", this.applicationName, "The provider was not initialized.");
                LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                throw new ProviderException(message);
            }
            //file:///C:/Source/ClubCloud/Common/api-reference/zimbraAdmin/GetSessions.html
            //GetSessionsRequest
            throw new NotImplementedException();
        }
        #endregion

        #region Get User
        public override System.Web.Security.MembershipUser GetUser(string username, bool userIsOnline)
        {
            if (!Initialized)
            {
                string message = String.Format("Membership Provider {0}: {1}", this.applicationName, "The provider was not initialized.");
                LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                throw new ProviderException(message);
            }
            throw new NotImplementedException();
        }

        public override System.Web.Security.MembershipUser GetUser(object providerUserKey, bool userIsOnline)
        {
            if (!Initialized)
            {
                string message = String.Format("Membership Provider {0}: {1}", this.applicationName, "The provider was not initialized.");
                LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                throw new ProviderException(message);
            }
            throw new NotImplementedException();
        }

        public override string GetUserNameByEmail(string email)
        {
            if (!Initialized)
            {
                string message = String.Format("Membership Provider {0}: {1}", this.applicationName, "The provider was not initialized.");
                LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                throw new ProviderException(message);
            }
            throw new NotImplementedException();
        }

        #endregion

        #region Unlock User

        public override bool UnlockUser(string userName)
        {
            if (!Initialized)
            {
                string message = String.Format("Membership Provider {0}: {1}", this.applicationName, "The provider was not initialized.");
                LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                throw new ProviderException(message);
            }
            throw new NotImplementedException();
        }

        #endregion

        #region Create User

        public override System.Web.Security.MembershipUser CreateUser(string username, string password, string email, string passwordQuestion, string passwordAnswer, bool isApproved, object providerUserKey, out System.Web.Security.MembershipCreateStatus status)
        {
            if (!Initialized)
            {
                string message = String.Format("Membership Provider {0}: {1}", this.applicationName, "The provider was not initialized.");
                LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                throw new ProviderException(message);
            }
            throw new NotImplementedException();
        }

        #endregion

        #region Delete Region

        public override bool DeleteUser(string username, bool deleteAllRelatedData)
        {
            if (!Initialized)
            {
                string message = String.Format("Membership Provider {0}: {1}", this.applicationName, "The provider was not initialized.");
                LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                throw new ProviderException(message);
            }
            throw new NotImplementedException();
        }

        #endregion

        #region Update User
        public override void UpdateUser(System.Web.Security.MembershipUser user)
        {
            if (!Initialized)
            {
                string message = String.Format("Membership Provider {0}: {1}", this.applicationName, "The provider was not initialized.");
                LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                throw new ProviderException(message);
            }
            throw new NotImplementedException();
        }

        #endregion

        #region Validate User

        public override bool ValidateUser(string username, string password)
        {
            bool validated = false;
            if(!Initialized)
            {
                string message = String.Format("Membership Provider {0}: {1}", this.applicationName, "The provider was not initialized.");
                LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                throw new ProviderException(message);
            }

            try
            {
 
                //TODO MessageContract redesign on ClubCloud.Zimbra.dll
                Zimbra.Administration.getAccountInfoRequest request = new Zimbra.Administration.getAccountInfoRequest { account = new Zimbra.Global.accountSelector { by = Zimbra.Global.accountBy.Name, Value = username } };
                Zimbra.Administration.getAccountInfoResponse response = zimbraServer.Message(request) as Zimbra.Administration.getAccountInfoResponse;
                if (response != null)
                {
                    using (Zimbra.ZimbraServer clientServer = new Zimbra.ZimbraServer(zimbraSettings.ZimbraServer))
                    {
                        string AuthToken = clientServer.Authenticate(username, password);
                        ZimbraCookie(AuthToken);
                        validated = zimbraServer.Authenticated.Value;
                    }
                }

                //WebBaseEvent.RaiseSystemEvent(null, 4002, username);
                validated = true;
            }
            catch
            {
                validated = false;
                //WebBaseEvent.RaiseSystemEvent(null, 4006, username);
            }

            return validated;
        }

        private void ZimbraCookie(string AuthToken)
        {
            if (HttpContext.Current != null && HttpContext.Current.Request != null)
            {
                HttpCookie ZimbraAuth = HttpContext.Current.Request.Cookies.Get("_ZimbraAuth");
                bool update = true;
                if (ZimbraAuth == null)
                {
                    update = false;
                    ZimbraAuth = new HttpCookie("_ZimbraAuth", AuthToken);
                }

                ZimbraAuth.Domain = HttpContext.Current.Request.Url.DnsSafeHost;
                ZimbraAuth.Expires = DateTime.Now.AddHours(1);
                ZimbraAuth.HttpOnly = true;
                ZimbraAuth.Secure = false;
                ZimbraAuth.Shareable = true;
                if (update)
                {
                    HttpContext.Current.Request.Cookies.Set(ZimbraAuth);
                }
                else
                {
                    HttpContext.Current.Request.Cookies.Add(ZimbraAuth);
                }
            }
        }

        #endregion

        #region ULS

        public static void LogToULS(string message, TraceSeverity traceSeverity, EventSeverity eventSeverity)
        {
            try
            {
                SPDiagnosticsCategory category = new SPDiagnosticsCategory("Zimbra MembershipProvider", traceSeverity, eventSeverity);
                SPDiagnosticsService ds = SPDiagnosticsService.Local;
                ds.WriteTrace(0, category, traceSeverity, message);
            }
            catch
            {
            }
        }

        #endregion
    }
}
