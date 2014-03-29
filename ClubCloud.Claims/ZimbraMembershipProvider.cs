using ClubCloud.Zimbra.Administration;
using ClubCloud.Zimbra.Global;
using Microsoft.SharePoint.Administration;
using System;
using System.Collections.Generic;
using System.Configuration.Provider;
using System.Linq;
using System.Net;
using System.Reflection;
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
        private Zimbra.ZimbraServer zimbraServer;
        private ZimbraProviderSettings zimbraSettings;
        private Zimbra.Global.VersionInfo zimbraVersion;
        private string AdminToken;

        private int _zimbraPasswordMaxLength;

        public int zimbraPasswordMaxLength
        {
            get { return _zimbraPasswordMaxLength; }
            set { _zimbraPasswordMaxLength = value; }
        }
        private int _zimbraPasswordMinLength;

        public int zimbraPasswordMinLength
        {
            get { return _zimbraPasswordMinLength; }
            set { _zimbraPasswordMinLength = value; }
        }
        private int _zimbraPasswordMinLowerCaseChars;

        public int zimbraPasswordMinLowerCaseChars
        {
            get { return _zimbraPasswordMinLowerCaseChars; }
            set { _zimbraPasswordMinLowerCaseChars = value; }
        }
        private int _zimbraPasswordMinAlphaChars;

        public int zimbraPasswordMinAlphaChars
        {
            get { return _zimbraPasswordMinAlphaChars; }
            set { _zimbraPasswordMinAlphaChars = value; }
        }
        private int _zimbraPasswordMinNumericChars;

        public int zimbraPasswordMinNumericChars
        {
            get { return _zimbraPasswordMinNumericChars; }
            set { _zimbraPasswordMinNumericChars = value; }
        }
        private int _zimbraPasswordMinDigitsOrPuncs;

        public int zimbraPasswordMinDigitsOrPuncs
        {
            get { return _zimbraPasswordMinDigitsOrPuncs; }
            set { _zimbraPasswordMinDigitsOrPuncs = value; }
        }
        private int _zimbraPasswordMinPunctuationChars;

        public int zimbraPasswordMinPunctuationChars
        {
            get { return _zimbraPasswordMinPunctuationChars; }
            set { _zimbraPasswordMinPunctuationChars = value; }
        }
        private int _zimbraPasswordMinUpperCaseChars;

        public int zimbraPasswordMinUpperCaseChars
        {
            get { return _zimbraPasswordMinUpperCaseChars; }
            set { _zimbraPasswordMinUpperCaseChars = value; }
        }
        private string _zimbraPasswordAllowedChars = string.Empty;

        public string zimbraPasswordAllowedChars
        {
            get { return _zimbraPasswordAllowedChars; }
            set { _zimbraPasswordAllowedChars = value; }
        }
        private string _zimbraPasswordAllowedPunctuationChars = string.Empty;

        public string zimbraPasswordAllowedPunctuationChars
        {
            get { return _zimbraPasswordAllowedPunctuationChars; }
            set { _zimbraPasswordAllowedPunctuationChars = value; }
        }

        private string _zimbraPasswordLocked = string.Empty;

        public string zimbraPasswordLocked
        {
            get { return _zimbraPasswordLocked; }
            set { _zimbraPasswordLocked = value; }
        }

        private string _zimbraPasswordLockoutDuration;

        public string zimbraPasswordLockoutDuration
        {
            get { return _zimbraPasswordLockoutDuration; }
            set { _zimbraPasswordLockoutDuration = value; }
        }

        private bool _zimbraPasswordLockoutEnabled;

        public bool zimbraPasswordLockoutEnabled
        {
            get { return _zimbraPasswordLockoutEnabled; }
            set { _zimbraPasswordLockoutEnabled = value; }
        }

        private int _zimbraPasswordLockoutMaxFailures;

        public int zimbraPasswordLockoutMaxFailures
        {
            get { return _zimbraPasswordLockoutMaxFailures; }
            set { _zimbraPasswordLockoutMaxFailures = value; }
        }

        private string _zimbraPasswordLockoutFailureLifetime;

        public string zimbraPasswordLockoutFailureLifetime
        {
            get { return _zimbraPasswordLockoutFailureLifetime; }
            set { _zimbraPasswordLockoutFailureLifetime = value; }
        }

        
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
            GetPasswordProperties();

            GetLockProperties();

            this.Initialized = true;
        }

        private void GetLockProperties()
        {
            GetCosRequest request = new GetCosRequest { cos = new cosSelector { by = cosBy.name, Value = zimbraSettings.ZimbraClassOfService }, attrs = "zimbraPasswordLockoutDuration,zimbraPasswordLockoutEnabled,zimbraPasswordLockoutMaxFailures,zimbraPasswordLockoutFailureLifetime" };
            GetCosResponse response = zimbraServer.Message(request) as GetCosResponse;

            foreach (var item in response.cos.a)
            {
                try
                {
                    PropertyInfo propertyInfo = this.GetType().GetProperty(item.name);
                    propertyInfo.SetValue(this, Convert.ChangeType(item.Value, propertyInfo.PropertyType), null);
                }
                catch
                {
                }
            }
        }

        private void GetPasswordProperties()
        {
            GetCosRequest request = new GetCosRequest { cos = new cosSelector { by = cosBy.name, Value = zimbraSettings.ZimbraClassOfService }, attrs = "zimbraPasswordLocked,zimbraPasswordLocked,zimbraPasswordLockoutDuration,zimbraPasswordLockoutEnabled,zimbraPasswordLockoutMaxFailures" };
            GetCosResponse response = zimbraServer.Message(request) as GetCosResponse;

            foreach (var item in response.cos.a)
            {
                try
                {
                    PropertyInfo propertyInfo = this.GetType().GetProperty(item.name);
                    propertyInfo.SetValue(this, Convert.ChangeType(item.Value, propertyInfo.PropertyType), null);
                }
                catch
                {
                }
            }
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
                return _zimbraPasswordMinLength;
            }
        }

        public override int MinRequiredNonAlphanumericCharacters
        {
            get
            {
                return zimbraPasswordMinAlphaChars;
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
            get { return zimbraPasswordLockoutMaxFailures; }
        }

        public override int PasswordAttemptWindow
        {
            get { return int.Parse(zimbraPasswordLockoutFailureLifetime); }
        }

        public override System.Web.Security.MembershipPasswordFormat PasswordFormat
        {
            get { return MembershipPasswordFormat.Hashed; }
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
            get { return false; }
        }

        public override bool EnablePasswordRetrieval
        {
            get { return false; }
        }

        public override bool RequiresUniqueEmail
        {
            get { return true; }
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
            //GetAllAccounts
            //file:///C:/Source/ClubCloud/Common/api-reference/zimbraAdmin/GetAllAccounts.html

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
            ZimbraMembershipUser user = new ZimbraMembershipUser();

            if (!Initialized)
            {
                string message = String.Format("Membership Provider {0}: {1}", this.applicationName, "The provider was not initialized.");
                LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                throw new ProviderException(message);
            }
            Zimbra.Administration.GetAccountRequest request = new Zimbra.Administration.GetAccountRequest { account = new Zimbra.Global.accountSelector { by = Zimbra.Global.accountBy.Name, Value = username }, applyCos = true };
            Zimbra.Administration.GetAccountResponse response = zimbraServer.Message(request) as Zimbra.Administration.GetAccountResponse;
            if (response != null)
            {
                foreach (var item in response.account.a)
                {
                    try
                    {
                        PropertyInfo propertyInfo = user.GetType().GetProperty(item.name);
                        propertyInfo.SetValue(user, Convert.ChangeType(item.Value, propertyInfo.PropertyType), null);
                    }
                    catch
                    {
                    }
                }
            }
            return user;
        }

        public override System.Web.Security.MembershipUser GetUser(object providerUserKey, bool userIsOnline)
        {
            ZimbraMembershipUser user = new ZimbraMembershipUser();

            if (!Initialized)
            {
                string message = String.Format("Membership Provider {0}: {1}", this.applicationName, "The provider was not initialized.");
                LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                throw new ProviderException(message);
            }
            Zimbra.Administration.GetAccountRequest request = new Zimbra.Administration.GetAccountRequest { account = new Zimbra.Global.accountSelector { by = Zimbra.Global.accountBy.Id, Value = providerUserKey.ToString() }, applyCos = true };
            Zimbra.Administration.GetAccountResponse response = zimbraServer.Message(request) as Zimbra.Administration.GetAccountResponse;
            if (response != null)
            {
                foreach (var item in response.account.a)
                {
                    try
                    {
                        PropertyInfo propertyInfo = user.GetType().GetProperty(item.name);
                        propertyInfo.SetValue(user, Convert.ChangeType(item.Value, propertyInfo.PropertyType), null);
                    }
                    catch
                    {
                    }
                }
            }
            return user;
        }

        public override string GetUserNameByEmail(string email)
        {
            string UserName = "Onbekend";
            if (!Initialized)
            {
                string message = String.Format("Membership Provider {0}: {1}", this.applicationName, "The provider was not initialized.");
                LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                throw new ProviderException(message);
            }
            Zimbra.Administration.GetAccountRequest request = new Zimbra.Administration.GetAccountRequest { account = new Zimbra.Global.accountSelector { by = Zimbra.Global.accountBy.Name, Value = email }, applyCos = false, attrs = "displayName" };
            Zimbra.Administration.GetAccountResponse response = zimbraServer.Message(request) as Zimbra.Administration.GetAccountResponse;
            if (response != null)
            {
                UserName = response.account.a[0].Value;
            }
            return UserName;
        }

        #endregion

        #region Unlock User

        public override bool UnlockUser(string userName)
        {
            bool unlocked = false;
            if (!Initialized)
            {
                string message = String.Format("Membership Provider {0}: {1}", this.applicationName, "The provider was not initialized.");
                LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                throw new ProviderException(message);
            }
            //getUser and check lockoutstate
            if(zimbraPasswordLockoutEnabled) //&& usre.islockedout)
            {

            }
            return unlocked;
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
                Zimbra.Administration.GetAccountInfoRequest request = new Zimbra.Administration.GetAccountInfoRequest { account = new Zimbra.Global.accountSelector { by = Zimbra.Global.accountBy.Name, Value = username } };
                Zimbra.Administration.GetAccountInfoResponse response = zimbraServer.Message(request) as Zimbra.Administration.GetAccountInfoResponse;
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
            if (HttpContext.Current != null || HttpContext.Current.Request != null )
            {
                HttpCookie ZimbraAuth = HttpContext.Current.Request.Unvalidated.Cookies.Get("_ZimbraAuth");
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
                    HttpContext.Current.Request.Unvalidated.Cookies.Set(ZimbraAuth);
                }
                else
                {
                    HttpContext.Current.Request.Unvalidated.Cookies.Add(ZimbraAuth);
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
