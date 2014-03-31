﻿using ClubCloud.Zimbra.Administration;
using ClubCloud.Zimbra.Global;
using Microsoft.SharePoint.Administration;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration.Provider;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security;
using System.Security.Principal;
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

        public override string Name
        {
            get
            {
                return "ZimbraMembershipProvider";
            }
        }

        public override string Description
        {
            get
            {
                return "Zimbra Membership Provider";
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
                    if (propertyInfo != null)
                    {
                        propertyInfo.SetValue(this, Convert.ChangeType(item.Value, propertyInfo.PropertyType), null);
                    }
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
                    if (propertyInfo != null)
                    {
                        propertyInfo.SetValue(this, Convert.ChangeType(item.Value, propertyInfo.PropertyType), null);
                    }
                }
                catch
                {
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

        protected override byte[] DecryptPassword(byte[] encodedPassword)
        {
            return base.DecryptPassword(encodedPassword);
        }

        protected override byte[] EncryptPassword(byte[] password)
        {
            return base.EncryptPassword(password);
        }

        protected override byte[] EncryptPassword(byte[] password, System.Web.Configuration.MembershipPasswordCompatibilityMode legacyPasswordCompatibilityMode)
        {
            return base.EncryptPassword(password, legacyPasswordCompatibilityMode);
        }

        protected override void OnValidatingPassword(ValidatePasswordEventArgs e)
        {
            base.OnValidatingPassword(e);
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
            string resetPassword = null;

            if (!Initialized)
            {
                string message = String.Format("Membership Provider {0}: {1}", this.applicationName, "The provider was not initialized.");
                LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                throw new ProviderException(message);
            }

            string zimbraId = null;

            Zimbra.Administration.GetAccountInfoRequest request = new Zimbra.Administration.GetAccountInfoRequest { account = new Zimbra.Global.accountSelector { by = Zimbra.Global.accountBy.Name, Value = username } };
            Zimbra.Administration.GetAccountInfoResponse response = zimbraServer.Message(request) as Zimbra.Administration.GetAccountInfoResponse;
            if (response != null)
            {
                
                foreach (var item in response.a)
                {
                    if (item.name == "zimbraId")
                    {
                        zimbraId = item.Value;
                    }
                }
            }
            resetPassword = this.GeneratePassword();

            if(string.IsNullOrWhiteSpace(zimbraId) && string.IsNullOrWhiteSpace(resetPassword))
            {
                resetPassword = this.GeneratePassword();
                List<attrN> password = new List<attrN>();
                password.Add(new attrN { name = "userPassword", Value = resetPassword });
                Zimbra.Administration.ModifyAccountRequest modify = new Zimbra.Administration.ModifyAccountRequest { id = zimbraId, a = password };
                Zimbra.Administration.ModifyAccountResponse modified = zimbraServer.Message(modify) as Zimbra.Administration.ModifyAccountResponse;
            }
            else
            {
                string message = String.Format("Membership Provider {0}: {1}", this.applicationName, "The password could not be rest.");
                LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                throw new ProviderException(message);
            }

            return resetPassword;
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

            /*
            if (length < 1 || length > 128)
            {
                throw new ArgumentException(SR.GetString("Membership_password_length_incorrect"));
            }
            if (numberOfNonAlphanumericCharacters > length || numberOfNonAlphanumericCharacters < 0)
            {
                throw new ArgumentException(SR.GetString("Membership_min_required_non_alphanumeric_characters_incorrect", new object[]
		{
			"numberOfNonAlphanumericCharacters"
		}));
            }
            string text;
            int num4;
            do
            {
                byte[] array = new byte[length];
                char[] array2 = new char[length];
                int num = 0;
                new RNGCryptoServiceProvider().GetBytes(array);
                for (int i = 0; i < length; i++)
                {
                    int num2 = (int)(array[i] % 87);
                    if (num2 < 10)
                    {
                        array2[i] = (char)(48 + num2);
                    }
                    else
                    {
                        if (num2 < 36)
                        {
                            array2[i] = (char)(65 + num2 - 10);
                        }
                        else
                        {
                            if (num2 < 62)
                            {
                                array2[i] = (char)(97 + num2 - 36);
                            }
                            else
                            {
                                array2[i] = Membership.punctuations[num2 - 62];
                                num++;
                            }
                        }
                    }
                }
                if (num < numberOfNonAlphanumericCharacters)
                {
                    Random random = new Random();
                    for (int j = 0; j < numberOfNonAlphanumericCharacters - num; j++)
                    {
                        int num3;
                        do
                        {
                            num3 = random.Next(0, length);
                        }
                        while (!char.IsLetterOrDigit(array2[num3]));
                        array2[num3] = Membership.punctuations[random.Next(0, Membership.punctuations.Length)];
                    }
                }
                text = new string(array2);
            }
            while (CrossSiteScriptingValidation.IsDangerousString(text, out num4));
            return text;
            */
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
            ZimbraMembershipUserCollection zusers = new ZimbraMembershipUserCollection();
            MembershipUserCollection users = new MembershipUserCollection();
            if (!Initialized)
            {
                string message = String.Format("Membership Provider {0}: {1}", this.applicationName, "The provider was not initialized.");
                LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                throw new ProviderException(message);
            }
            //GetAllAccounts
            //file:///C:/Source/ClubCloud/Common/api-reference/zimbraAdmin/GetAllAccounts.html
            zusers.Add(new ZimbraMembershipUser());

            foreach (var item in zusers)
            {
                users.Add(item as MembershipUser);
            }

            totalRecords = users.Count;
            return users;
        }

        public override int GetNumberOfUsersOnline()
        {
            int UsersOnline = 0;
            if (!Initialized)
            {
                string message = String.Format("Membership Provider {0}: {1}", this.applicationName, "The provider was not initialized.");
                LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                throw new ProviderException(message);
            }
            //file:///C:/Source/ClubCloud/Common/api-reference/zimbraAdmin/GetSessions.html
            //GetSessionsRequest
            return UsersOnline;
        }
        #endregion

        #region Get User

        public ZimbraMembershipUser GetZimbraUser(string username, bool userIsOnline)
        {
            return this.GetUser(username, userIsOnline) as ZimbraMembershipUser;
        }

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
                Type tuser = user.GetType();
                foreach (var item in response.account.a)
                {
                    try
                    {
                        PropertyInfo propertyInfo = tuser.GetProperty(item.name);
                        if (propertyInfo != null)
                        {
                            if (propertyInfo.PropertyType == typeof(string))
                            {
                                propertyInfo.SetValue(item, Convert.ChangeType(item.Value, propertyInfo.PropertyType), null);
                            }
                            else
                            {
                                IList attr = (IList)propertyInfo.GetValue(item);
                                if (attr != null)
                                {
                                    attr.Add(Convert.ChangeType(item.Value, propertyInfo.PropertyType));
                                    propertyInfo.SetValue(this, attr);
                                }
                            }
                        }
                    }
                    catch
                    {
                    }
                }
            }
            return user;
        }

        public ZimbraMembershipUser GetZimbraUser(object providerUserKey, bool userIsOnline)
        {
            return this.GetUser(providerUserKey, userIsOnline) as ZimbraMembershipUser;
        }

        public override System.Web.Security.MembershipUser GetUser(object providerUserKey, bool userIsOnline)
        {
            ZimbraMembershipUser user = new ZimbraMembershipUser();

            string sddl = (providerUserKey as SecurityIdentifier).Value;

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
                Type tuser = user.GetType();
                foreach (var item in response.account.a)
                {
                    try
                    {
                        PropertyInfo propertyInfo = tuser.GetProperty(item.name);
                        if (propertyInfo != null)
                        {
                            if (propertyInfo.PropertyType == typeof(string))
                            {
                                propertyInfo.SetValue(item, Convert.ChangeType(item.Value, propertyInfo.PropertyType), null);
                            }
                            else
                            {
                                IList attr = (IList)propertyInfo.GetValue(item);
                                if (attr != null)
                                {
                                    attr.Add(Convert.ChangeType(item.Value,propertyInfo.PropertyType));
                                    propertyInfo.SetValue(this, attr);
                                }
                            }
                        }
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

        #region Locking User

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
                //Zimbra.Administration.GetAccountInfoRequest request = new Zimbra.Administration.GetAccountInfoRequest { account = new Zimbra.Global.accountSelector { by = Zimbra.Global.accountBy.Name, Value = "info@clubcloud.nl" } };
                //Zimbra.Administration.GetAccountInfoResponse response = server.Message(request) as Zimbra.Administration.GetAccountInfoResponse;
                //if (response != null)
                //{
                //    string name = response.name;
                //}

            }
            return unlocked;
        }

        public bool LockUser(string userName)
        {
            bool unlocked = false;
            if (!Initialized)
            {
                string message = String.Format("Membership Provider {0}: {1}", this.applicationName, "The provider was not initialized.");
                LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                throw new ProviderException(message);
            }
            //getUser and check lockoutstate
            if (zimbraPasswordLockoutEnabled) //&& usre.islockedout)
            {
                //Zimbra.Administration.GetAccountInfoRequest request = new Zimbra.Administration.GetAccountInfoRequest { account = new Zimbra.Global.accountSelector { by = Zimbra.Global.accountBy.Name, Value = "info@clubcloud.nl" } };
                //Zimbra.Administration.GetAccountInfoResponse response = server.Message(request) as Zimbra.Administration.GetAccountInfoResponse;
                //if (response != null)
                //{
                //    string name = response.name;
                //}

            }
            return unlocked;
        }

        #endregion

        #region Create User

        public override System.Web.Security.MembershipUser CreateUser(string username, string password, string email, string passwordQuestion, string passwordAnswer, bool isApproved, object providerUserKey, out System.Web.Security.MembershipCreateStatus status)
        {
            ZimbraMembershipUser zuser = new ZimbraMembershipUser();
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

            //Zimbra.Administration.GetAccountInfoRequest request = new Zimbra.Administration.GetAccountInfoRequest { account = new Zimbra.Global.accountSelector { by = Zimbra.Global.accountBy.Name, Value = "info@clubcloud.nl" } };
            //Zimbra.Administration.GetAccountInfoResponse response = server.Message(request) as Zimbra.Administration.GetAccountInfoResponse;
            //if (response != null)
            //{
            //    string name = response.name;
            //}

            throw new NotImplementedException();
        }

        #endregion

        #region Update User
        public override void UpdateUser(System.Web.Security.MembershipUser user)
        {
            ZimbraMembershipUser zuser = user as ZimbraMembershipUser;

            if (!Initialized)
            {
                string message = String.Format("Membership Provider {0}: {1}", this.applicationName, "The provider was not initialized.");
                LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                throw new ProviderException(message);
            }

            try
            {
                string zimbraId = null;
                List<attrN> properties = new List<attrN>();

                MembershipUser membershipUser = new MembershipUser("Fake", "Fake", null, "fake@zimbra.com", "Fake", "Fake", false, true, DateTime.Now, DateTime.Now, DateTime.Now, DateTime.Now, DateTime.Now);
                List<PropertyInfo> basepropertyInfos = membershipUser.GetType().GetProperties().ToList<PropertyInfo>();
                List<PropertyInfo> propertyInfos = zuser.GetType().GetProperties().ToList<PropertyInfo>();

                foreach (PropertyInfo propertyInfo in propertyInfos)
                {
                    if (!basepropertyInfos.Contains(propertyInfo))
                    {
                        try
                        {
                            string value = propertyInfo.GetValue(zuser).ToString();

                            if (!string.IsNullOrWhiteSpace(value))
                            {
                                if (propertyInfo.Name == "zimbraId")
                                {
                                    zimbraId = value;
                                }
                                else
                                {
                                    properties.Add(new attrN { name = propertyInfo.Name, Value = value });
                                }
                            }
                        }
                        catch { }
                    }
                }

                if (string.IsNullOrWhiteSpace(zimbraId) && properties.Count > 0)
                {
                    Zimbra.Administration.ModifyAccountRequest modify = new Zimbra.Administration.ModifyAccountRequest { id = zimbraId, a = properties };
                    Zimbra.Administration.ModifyAccountResponse modified = zimbraServer.Message(modify) as Zimbra.Administration.ModifyAccountResponse;
                }
            }
            catch
            {
            }
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
                SPDiagnosticsCategory category = new SPDiagnosticsCategory("Zimbra Membership Provider", traceSeverity, eventSeverity);
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
