using ClubCloud.Zimbra;
using ClubCloud.Zimbra.Administration;
using ClubCloud.Zimbra.Global;
using ClubCloud.Zimbra.Service;
using Microsoft.IdentityModel.Web;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;
using Microsoft.SharePoint.IdentityModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Configuration.Provider;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Management;
using System.Web.Security;

namespace ClubCloud.Provider
{
    public class ZimbraMembershipProvider : System.Web.Security.MembershipProvider
    {
        #region properties

        private bool Initialized;
        private string applicationName;
        private Zimbra.ZimbraServer zimbraServer;
        private ZimbraProviderSettings zimbraSettings;
        internal static ZimbraConfigurationSection zimbraconfiguration = null;
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

        #endregion

        #region Initialisation
        public ZimbraMembershipProvider() : base()
        {
            SetConfiguration();
            /*
            try
            {
                zimbraconfiguration = (ZimbraConfigurationSection)ConfigurationManager.GetSection("Zimbra/Configuration");
            }
            catch (Exception ex)
            {
                string messsage = ex.Message;
            }

            if (zimbraconfiguration == null)
            {
                zimbraconfiguration = new ZimbraConfigurationSection();
            }
            */
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
                    SetConfiguration();
                    Initialize(string.Empty, new NameValueCollection());

                    if (!Initialized)
                    {
                        string message = String.Format("Membership Provider {0}: {1}", this.applicationName, "The provider was not initialized.");
                        LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                        throw new ProviderException(message);
                    }
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
            Task.Run(async () => await InitializeAsync(name, config)).ConfigureAwait(true);
        }

        public async Task InitializeAsync(string name, System.Collections.Specialized.NameValueCollection config)
        {
            try
            {
                base.Initialize(name, config);
            }
            catch { };

            /*
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
            */
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

                if (zimbraSettings != null && !String.IsNullOrEmpty(zimbraSettings.ZimbraServer) && !String.IsNullOrEmpty(zimbraSettings.ZimbraUserName) && !String.IsNullOrEmpty(zimbraSettings.ZimbraPassword))
                {
                    zimbraconfiguration.Server.UserName = zimbraSettings.ZimbraUserName;
                    zimbraconfiguration.Server.Password = zimbraSettings.ZimbraPassword;
                    zimbraconfiguration.Server.ServerName = zimbraSettings.ZimbraServer;
                    zimbraconfiguration.Server.IsAdmin = true;
                    /*
                    string message = String.Format("Error while initializing settings Role Provider {0}: {1}", this.applicationName, "The setting for Zimbra are not complete.");
                    LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                    throw new ProviderException(message);
                    */
                }
            }
            catch (ZimbraSettingsException zex)
            {
                string message = String.Format("Error while initializing settings Membership Provider {0}: {1}", this.applicationName, zex.Message);
                LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                throw new ProviderException(message, zex);
            }

            if (!string.IsNullOrEmpty(zimbraconfiguration.Server.ServerName))
            {
                zimbraServer = new Zimbra.ZimbraServer(zimbraconfiguration.Server.ServerName);

                try
                {
                    while(!zimbraServer.AuthenticatedAdmin.Value)
                    {
                        try
                        {
                            AdminToken = zimbraServer.Authenticate(zimbraconfiguration.Server.UserName, zimbraconfiguration.Server.Password, zimbraconfiguration.Server.IsAdmin);
                        }
                        catch { }

                        if (string.IsNullOrEmpty(AdminToken))
                        {
                            //zimbraServer = new Zimbra.ZimbraServer(zimbraconfiguration.Server.ServerName);
                            zimbraServer.TriggerWebSite();
                            System.Threading.Thread.Sleep(1000);
                        }
                    }

                    using (Zimbra.Administration.GetVersionInfoResponse response = await zimbraServer.Message(new Zimbra.Administration.GetVersionInfoRequest()) as Zimbra.Administration.GetVersionInfoResponse)
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

                await GetPasswordProperties();

                await GetLockProperties();

                this.Initialized = true;
            }
        }

        private void SetConfiguration()
        {
            try
            {
                zimbraconfiguration = (ZimbraConfigurationSection)ConfigurationManager.GetSection("Zimbra/Configuration");
            }
            catch (Exception ex)
            {
                string messsage = ex.Message;
            }

            if (zimbraconfiguration == null)
            {
                zimbraconfiguration = new ZimbraConfigurationSection();
            }
        }

        private async Task GetLockProperties()
        {
            GetCosRequest request = new GetCosRequest { cos = new cosSelector { by = cosBy.name, Value = zimbraconfiguration.Server.ClassOfService }, attrs = "zimbraPasswordLockoutDuration,zimbraPasswordLockoutEnabled,zimbraPasswordLockoutMaxFailures,zimbraPasswordLockoutFailureLifetime" };
            GetCosResponse response = await zimbraServer.Message(request) as GetCosResponse;

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

        private async Task GetPasswordProperties()
        {
            GetCosRequest request = new GetCosRequest { cos = new cosSelector { by = cosBy.name, Value = zimbraconfiguration.Server.ClassOfService }, attrs = "zimbraPasswordLocked,zimbraPasswordLocked,zimbraPasswordLockoutDuration,zimbraPasswordLockoutEnabled,zimbraPasswordLockoutMaxFailures" };
            GetCosResponse response = await zimbraServer.Message(request) as GetCosResponse;

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
            return Task.Run(async () => await ChangePasswordAsync(username, oldPassword, newPassword)).Result;
        }

        public async Task<bool> ChangePasswordAsync(string username, string oldPassword, string newPassword)
        {
            bool changed = false;
            if (!Initialized)
            {
                SetConfiguration();
                await InitializeAsync(string.Empty, new NameValueCollection());

                if (!Initialized)
                {
                    string message = String.Format("Membership Provider {0}: {1}", this.applicationName, "The provider was not initialized.");
                    LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                    throw new ProviderException(message);
                }
            }

            try
            {
                using (Zimbra.ZimbraServer clientServer = new Zimbra.ZimbraServer(zimbraconfiguration.Server.ServerName))
                {
                    if (string.IsNullOrEmpty(oldPassword) || string.IsNullOrWhiteSpace(oldPassword))
                    {
                        ClubCloud.Zimbra.Administration.SetPasswordRequest request = new SetPasswordRequest { id = username, newPassword = newPassword };
                        SetPasswordResponse response = await clientServer.Message(request) as SetPasswordResponse;
                        string message = response.message;
                    }
                    else
                    {
                        ClubCloud.Zimbra.Account.ChangePasswordRequest request = new Zimbra.Account.ChangePasswordRequest { account = new Zimbra.Global.accountSelector { by = Zimbra.Global.accountBy.Name, Value = username }, oldPassword = oldPassword, password = newPassword };
                        Zimbra.Account.ChangePasswordResponse response = await clientServer.Message(request) as Zimbra.Account.ChangePasswordResponse;
                        string AuthToken = response.authToken;
                        //ZimbraCookie(AuthToken);
                    }
                    changed = true;           
                    //TODO send message
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
            return Task.Run(async () => await ResetPasswordAsync(username, answer)).Result;
        }

        public async Task<string> ResetPasswordAsync(string username, string answer)
        {
            string resetPassword = null;

            if (!Initialized)
            {
                SetConfiguration();
                await InitializeAsync(string.Empty, new NameValueCollection());

                if (!Initialized)
                {
                    string message = String.Format("Membership Provider {0}: {1}", this.applicationName, "The provider was not initialized.");
                    LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                    throw new ProviderException(message);
                }
            }

            string zimbraId = null;

            Zimbra.Administration.GetAccountInfoRequest request = new Zimbra.Administration.GetAccountInfoRequest { account = new Zimbra.Global.accountSelector { by = Zimbra.Global.accountBy.Name, Value = username } };
            Zimbra.Administration.GetAccountInfoResponse response = await zimbraServer.Message(request) as Zimbra.Administration.GetAccountInfoResponse;
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

            if(!string.IsNullOrWhiteSpace(zimbraId) && !string.IsNullOrWhiteSpace(resetPassword))
            {
                //resetPassword = this.GeneratePassword();
                //List<attrN> password = new List<attrN>();
                //password.Add(new attrN { name = "userPassword", Value = resetPassword });
                //Zimbra.Administration.ModifyAccountRequest modify = new Zimbra.Administration.ModifyAccountRequest { id = zimbraId, a = password };
                //Zimbra.Administration.ModifyAccountResponse modified = zimbraServer.Message(modify) as Zimbra.Administration.ModifyAccountResponse;
                //TODO send message
                Zimbra.Administration.SetPasswordRequest setpwrequest = new SetPasswordRequest { id = zimbraId, newPassword = resetPassword };
                Zimbra.Administration.SetPasswordResponse setpwresponse = await zimbraServer.Message(setpwrequest) as Zimbra.Administration.SetPasswordResponse;
            }
            else
            {
                string message = String.Format("Membership Provider {0}: {1}", this.applicationName, "The password could not be rest.");
                LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                throw new ProviderException(message);
            }

            return resetPassword;
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="username"></param>
        /// <param name="answer"></param>
        /// <returns></returns>
        public override string GetPassword(string username, string answer)
        {
            return Task.Run(async () => await GetPasswordAsync(username, answer)).Result;
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="username"></param>
        /// <param name="answer"></param>
        /// <returns></returns>
        public async Task<string> GetPasswordAsync(string username, string answer)
        {
            if (!Initialized)
            {
                SetConfiguration();
                await InitializeAsync(string.Empty, new NameValueCollection());        

                if (!Initialized)
                {

                    string message = String.Format("Membership Provider {0}: {1}", this.applicationName, "The provider was not initialized.");
                    LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                    throw new ProviderException(message);
                }
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
            Tuple<int, System.Web.Security.MembershipUserCollection> result;
            result = Task.Run(async () => await FindUsersByEmailAsync(emailToMatch, pageIndex, pageSize)).Result;
            totalRecords = result.Item1;
            return result.Item2;
        }

        public async Task<Tuple<int, System.Web.Security.MembershipUserCollection>> FindUsersByEmailAsync(string emailToMatch, int pageIndex, int pageSize)//, out int totalRecords)
        {
            int totalRecords = 0;

            if (!Initialized)
            {
                SetConfiguration();
                await InitializeAsync(string.Empty, new NameValueCollection());

                if (!Initialized)
                {
                    string message = String.Format("Membership Provider {0}: {1}", this.applicationName, "The provider was not initialized.");
                    LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                    throw new ProviderException(message);
                }
            }

            MembershipUserCollection users = new MembershipUserCollection();

            string[] parts = emailToMatch.Split('@');//.Last();
            if (parts.Length == 2)
            {
                string emaildomain = parts.Last();
                Uri uri = new Uri(emaildomain);
                if (uri.HostNameType == UriHostNameType.Dns)
                {

                }
            }
            else
            {
                totalRecords = 0;
                return new Tuple<int,MembershipUserCollection>(totalRecords, users);
            }

            if (!Initialized)
            {
                string message = String.Format("Membership Provider {0}: {1}", this.applicationName, "The provider was not initialized.");
                LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                throw new ProviderException(message);
            }

            
            SPContext context = SPContext.Current;
            string domain = null;
            totalRecords = 0;
            if (context != null)
            {
                domain = GetZimbraDomain(context.Site.Url);
                if (emailToMatch.Contains('<') && emailToMatch.Contains('>'))
                {
                    emailToMatch = Regex.Match(emailToMatch, @"\<([^)]*)\>").Groups[1].Value;
                }

                Zimbra.Administration.SearchDirectoryRequest srequest = new Zimbra.Administration.SearchDirectoryRequest { applyConfig = false, applyCos = false, domain = domain, limit = 50, countOnly = false, offset = 0, sortAscending = true, sortBy = "name", types = "accounts" };
                srequest.query = String.Format("(|(mail=*{0}*)(zimbraMailDeliveryAddress=*{0}*)(zimbraPrefMailForwardingAddress=*{0}*)(zimbraMail=*{0}*)(zimbraMailAlias=*{0}*))", emailToMatch);

                Zimbra.Administration.SearchDirectoryResponse sresponse = await zimbraServer.Message(srequest) as Zimbra.Administration.SearchDirectoryResponse;
                List<Zimbra.Global.accountInfo> accounts = sresponse.Items.ConvertAll<Zimbra.Global.accountInfo>(delegate(object o) { return o as Zimbra.Global.accountInfo; });

                totalRecords += accounts.Count;
                if (accounts.Count > 0)
                {
                    foreach (accountInfo account in accounts)
                    {
                        ZimbraMembershipUser user = new ZimbraMembershipUser();
                        Type tuser = user.GetType();

                        foreach (var item in account.a)
                        {
                            try
                            {
                                PropertyInfo propertyInfo = tuser.GetProperty(item.name);
                                if (propertyInfo != null)
                                {
                                    if (propertyInfo.PropertyType == typeof(string))
                                    {
                                        propertyInfo.SetValue(user, Convert.ChangeType(item.Value, propertyInfo.PropertyType), null);
                                    }
                                    else
                                    {
                                        IList attr = (IList)propertyInfo.GetValue(item);
                                        if (attr != null)
                                        {
                                            attr.Add(Convert.ChangeType(item.Value, propertyInfo.PropertyType));
                                            propertyInfo.SetValue(user, attr);
                                        }
                                    }
                                }

                            }
                            catch
                            {
                            }
                        }
                        users.Add(user);
                    }
                }
                return new Tuple<int,MembershipUserCollection>(totalRecords, users);
            }
            return new Tuple<int, MembershipUserCollection>(0, new MembershipUserCollection()); 
        }

        public override System.Web.Security.MembershipUserCollection FindUsersByName(string usernameToMatch, int pageIndex, int pageSize, out int totalRecords)
        {
            Tuple<int, System.Web.Security.MembershipUserCollection> result;
            result= Task.Run(async () => await FindUsersByNameAsync(usernameToMatch, pageIndex, pageSize)).Result;
            totalRecords =result.Item1;
            return result.Item2;
        }

        public async Task<Tuple<int, System.Web.Security.MembershipUserCollection>> FindUsersByNameAsync(string usernameToMatch, int pageIndex, int pageSize)//, out int totalRecords)
        {

            if (!Initialized)
            {
                SetConfiguration();
                await InitializeAsync(string.Empty, new NameValueCollection());

                if (!Initialized)
                {
                    string message = String.Format("Membership Provider {0}: {1}", this.applicationName, "The provider was not initialized.");
                    LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                    throw new ProviderException(message);
                }
            }

            MembershipUserCollection users = new MembershipUserCollection();
            SPContext context = SPContext.Current;
            string domain = null;
            int totalRecords = 0;
            if (context != null)
            {
                domain = GetZimbraDomain(context.Site.Url);
                if(usernameToMatch.Contains('<') && usernameToMatch.Contains('>'))
                {
                    usernameToMatch = Regex.Match(usernameToMatch, @"\<([^)]*)\>").Groups[1].Value;
                }

                List<Zimbra.Global.accountInfo> accounts = new List<accountInfo>();
                try
                {
                    Zimbra.Administration.SearchDirectoryRequest srequest = new Zimbra.Administration.SearchDirectoryRequest { applyConfig = false, applyCos = false, domain = domain, limit = 50, countOnly = false, offset = 0, sortAscending = true, sortBy = "name", types = "accounts", attrs = "displayName,zimbraId,zimbraAliasTargetId,cn,sn,zimbraMailHost,uid,zimbraCOSId,zimbraAccountStatus,zimbraLastLogonTimestamp,description,zimbraIsSystemAccount,zimbraIsDelegatedAdminAccount,zimbraIsAdminAccount,zimbraIsSystemResource,zimbraAuthTokenValidityValue,zimbraIsExternalVirtualAccount,zimbraMailStatus,zimbraIsAdminGroup,zimbraCalResType,zimbraDomainType,zimbraDomainName,zimbraDomainStatus" };
                    srequest.query = String.Format("(|(uid=*{0}*)(cn=*{0}*)(sn=*{0}*)(gn=*{0}*)(displayName=*{0}*)(givenName=*{0}*))", usernameToMatch);

                    Zimbra.Administration.SearchDirectoryResponse sresponse = await zimbraServer.Message(srequest) as Zimbra.Administration.SearchDirectoryResponse;
                    accounts = sresponse.Items.ConvertAll<Zimbra.Global.accountInfo>(delegate(object o) { return o as Zimbra.Global.accountInfo; });
                }
                catch (Exception)
                {
                    accounts = new List<accountInfo>();
                }

                totalRecords += accounts.Count;

                if (accounts.Count > 0)
                {
                    foreach (accountInfo account in accounts)
                    {
                        ZimbraMembershipUser user = new ZimbraMembershipUser();
                        Type tuser = user.GetType();

                        foreach (var item in account.a)
                        {
                            try
                            {
                                PropertyInfo propertyInfo = tuser.GetProperty(item.name);
                                if (propertyInfo != null)
                                {
                                    if (propertyInfo.PropertyType == typeof(string))
                                    {
                                        propertyInfo.SetValue(user, Convert.ChangeType(item.Value, propertyInfo.PropertyType), null);
                                    }
                                    else
                                    {
                                        IList attr = (IList)propertyInfo.GetValue(item);
                                        if (attr != null)
                                        {
                                            attr.Add(Convert.ChangeType(item.Value, propertyInfo.PropertyType));
                                            propertyInfo.SetValue(user, attr);
                                        }
                                    }
                                }
                                
                            }
                            catch
                            {
                            }
                        }
                        users.Add(user);
                        
                    }
                }
                return new Tuple<int,MembershipUserCollection>(totalRecords, users);
            }
            return new Tuple<int, MembershipUserCollection>(0, new MembershipUserCollection());
        }

        public override System.Web.Security.MembershipUserCollection GetAllUsers(int pageIndex, int pageSize, out int totalRecords)
        {
            Tuple<int,System.Web.Security.MembershipUserCollection> result;
            result = Task.Run(async () => await GetAllUsersAsync(pageIndex, pageSize)).Result;
            totalRecords = result.Item1;
            return result.Item2;
        }

        public async Task<Tuple<int, System.Web.Security.MembershipUserCollection>> GetAllUsersAsync(int pageIndex, int pageSize)//, out int totalRecords)
        {
            int totalRecords;
            if (!Initialized)
            {
                SetConfiguration();
                await InitializeAsync(string.Empty, new NameValueCollection());

                if (!Initialized)
                {
                    string message = String.Format("Membership Provider {0}: {1}", this.applicationName, "The provider was not initialized.");
                    LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                    throw new ProviderException(message);
                }
            }

            MembershipUserCollection users = new MembershipUserCollection();
            SPContext context = SPContext.Current;
            string domain = null;
            totalRecords = 0;
            if (context != null)
            {
                domain = GetZimbraDomain(context.Site.Url);

                GetAllAccountsRequest request = new GetAllAccountsRequest { domain = new domainSelector { by = domainBy.name, Value = domain }, server = new serverSelector { by = serverBy.name, Value = zimbraconfiguration.Server.ServerName } };
                GetAllAccountsResponse response = await zimbraServer.Message(request) as GetAllAccountsResponse;

                if (response != null)
                {
                    List<accountInfo> allaccounts = response.account;
                    List<accountInfo> accounts = new List<accountInfo>();

                    foreach (accountInfo account in allaccounts)
                    {
                        try
                        {
                            attrN zimbraIsSystemAccount = account.a.SingleOrDefault(a => a.name == "zimbraIsSystemAccount");
                            if (zimbraIsSystemAccount == null)
                            {
                                accounts.Add(account);
                            }
                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                    }

                    totalRecords = accounts.Count;

                    int startIndex = 0;
                    int endIndex = totalRecords;

                    if (pageIndex > 0)
                    {
                        startIndex = pageIndex * pageSize;
                    }

                    if (((pageIndex * pageSize) + pageSize) < totalRecords)
                    {
                        endIndex = (pageIndex * pageSize) + pageSize;
                    }

                    for (int i = startIndex; i < endIndex; i++)
                    {
                        accountInfo account = accounts[i];
                        ZimbraMembershipUser user = new ZimbraMembershipUser();
                        Type tuser = user.GetType();

                        foreach (var item in account.a)
                        {
                            try
                            {
                                PropertyInfo propertyInfo = tuser.GetProperty(item.name);
                                if (propertyInfo != null)
                                {
                                    if (propertyInfo.PropertyType == typeof(string))
                                    {
                                        propertyInfo.SetValue(user, Convert.ChangeType(item.Value, propertyInfo.PropertyType), null);
                                    }
                                    else
                                    {
                                        IList attr = (IList)propertyInfo.GetValue(item);
                                        if (attr != null)
                                        {
                                            attr.Add(Convert.ChangeType(item.Value, propertyInfo.PropertyType));
                                            propertyInfo.SetValue(user, attr);
                                        }
                                    }
                                }
                            }
                            catch { }
                        }
                        users.Add(user);
                    }
                }
                return new Tuple<int,MembershipUserCollection>(totalRecords, users);
            }
            return new Tuple<int, MembershipUserCollection>(totalRecords, users); ;
        }

        /*
        public override int GetNumberOfUsersOnline()
        {
            int UsersOnline = 0;
            if (!Initialized)
            {
                string message = String.Format("Membership Provider {0}: {1}", this.applicationName, "The provider was not initialized.");
                LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                throw new ProviderException(message);
            }

            SPContext context = SPContext.Current;
            string domain = null;
            if (context != null)
            {
                domain = GetZimbraDomain(context.Site.Url);

                getAllAccountsRequest request = new getAllAccountsRequest { domain = new domainSelector { by = domainBy.name, Value = domain } };
                getAllAccountsResponse response = zimbraServer.Message(request) as getAllAccountsResponse;

                if (response != null)
                {
                }
            }
            return UsersOnline;
        }
        */
        public override int GetNumberOfUsersOnline()
        {
            return 0;
        }

        #endregion

        #region Get User

        public async Task<ZimbraMembershipUser> GetZimbraUserAsync(string username, bool userIsOnline)
        {
            MembershipUser user = await this.GetUserAsync(username, userIsOnline);
            return user as ZimbraMembershipUser;
        }

        public ZimbraMembershipUser GetZimbraUser(string username, bool userIsOnline)
        {
            return this.GetUser(username, userIsOnline) as ZimbraMembershipUser;
        }

        public override System.Web.Security.MembershipUser GetUser(string username, bool userIsOnline)
        {
            return Task.Run(async () => await GetUserAsync(username, userIsOnline)).Result;
        }

        public async Task<System.Web.Security.MembershipUser> GetUserAsync(string username, bool userIsOnline)
        {
            ZimbraMembershipUser user = new ZimbraMembershipUser();

            if (!Initialized)
            {
                SetConfiguration();
                await InitializeAsync(string.Empty, new NameValueCollection());

                if (!Initialized)
                {
                    string message = String.Format("Membership Provider {0}: {1}", this.applicationName, "The provider was not initialized.");
                    LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                    throw new ProviderException(message);
                }
            }

            try
            {
                Zimbra.Administration.GetAccountRequest request = new Zimbra.Administration.GetAccountRequest { account = new Zimbra.Global.accountSelector { by = Zimbra.Global.accountBy.Name, Value = username }, applyCos = true };
                Zimbra.Administration.GetAccountResponse response = await zimbraServer.Message(request) as Zimbra.Administration.GetAccountResponse;
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
                                    propertyInfo.SetValue(user, Convert.ChangeType(item.Value, propertyInfo.PropertyType), null);
                                }
                                else
                                {
                                    IList attr = (IList)propertyInfo.GetValue(item);
                                    if (attr != null)
                                    {
                                        attr.Add(Convert.ChangeType(item.Value, propertyInfo.PropertyType));
                                        propertyInfo.SetValue(user, attr);
                                    }
                                }
                            }
                        }
                        catch
                        {
                        }
                    }
                }
                else
                {
                    user = null;
                }
            }
            catch
            {
                return null;
            }
            return user;
        }

        public ZimbraMembershipUser GetZimbraUser(object providerUserKey, bool userIsOnline)
        {
            return this.GetUser(providerUserKey, userIsOnline) as ZimbraMembershipUser;
        }

        public override System.Web.Security.MembershipUser GetUser(object providerUserKey, bool userIsOnline)
        {
            return Task.Run(async () => await GetUserAsync(providerUserKey, userIsOnline)).Result;
        }

        public async Task<System.Web.Security.MembershipUser> GetUserAsync(object providerUserKey, bool userIsOnline)
        {
            ZimbraMembershipUser user = new ZimbraMembershipUser();

            string sddl = (providerUserKey as SecurityIdentifier).Value;

            if (!Initialized)
            {
                SetConfiguration();
                await InitializeAsync(string.Empty, new NameValueCollection());

                if (!Initialized)
                {
                    string message = String.Format("Membership Provider {0}: {1}", this.applicationName, "The provider was not initialized.");
                    LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                    throw new ProviderException(message);
                }
            }

            try
            {

                Zimbra.Administration.GetAccountRequest request = new Zimbra.Administration.GetAccountRequest { account = new Zimbra.Global.accountSelector { by = Zimbra.Global.accountBy.Id, Value = providerUserKey.ToString() }, applyCos = true };
                Zimbra.Administration.GetAccountResponse response = await zimbraServer.Message(request) as Zimbra.Administration.GetAccountResponse;
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
                                    propertyInfo.SetValue(user, Convert.ChangeType(item.Value, propertyInfo.PropertyType), null);
                                }
                                else
                                {
                                    IList attr = (IList)propertyInfo.GetValue(item);
                                    if (attr != null)
                                    {
                                        attr.Add(Convert.ChangeType(item.Value, propertyInfo.PropertyType));
                                        propertyInfo.SetValue(user, attr);
                                    }
                                }
                            }
                        }
                        catch
                        {
                        }
                    }
                }
                else
                {
                    user = null;
                }
            }
            catch
            {
                return null;
            }
            //MembershipUser spuser = new MembershipUser(this.ApplicationName, user.displayName, user.ProviderUserKey, user.Email, string.Empty, string.Empty, user.IsApproved, user.IsLockedOut, user.CreationDate, user.LastLoginDate, user.LastActivityDate, user.LastPasswordChangedDate, user.LastLockoutDate);
            //return spuser as ZimbraMembershipUser;
            return user;
        }

        public override string GetUserNameByEmail(string email)
        {
            return Task.Run(async () => await GetUserNameByEmailAsync(email)).Result;
        }

        public async Task<string> GetUserNameByEmailAsync(string email)
        {
            string UserName = null;

            string[] parts = email.Split('@');//.Last();
            if (parts.Length == 2)
            {
                string domain = parts.Last();
                Uri uri = new Uri(domain);
                if (uri.HostNameType != UriHostNameType.Dns)
                {
                    return null;
                }
            }
            else
            {
                return UserName;
            }

            if (!Initialized)
            {
                SetConfiguration();
                await InitializeAsync(string.Empty, new NameValueCollection());

                if (!Initialized)
                {
                    string message = String.Format("Membership Provider {0}: {1}", this.applicationName, "The provider was not initialized.");
                    LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                    throw new ProviderException(message);
                }
            }

            try
            {
                Zimbra.Administration.GetAccountRequest request = new Zimbra.Administration.GetAccountRequest { account = new Zimbra.Global.accountSelector { by = Zimbra.Global.accountBy.Name, Value = email }, applyCos = false, attrs = "displayName" };
                Zimbra.Administration.GetAccountResponse response = await zimbraServer.Message(request) as Zimbra.Administration.GetAccountResponse;
                if (response != null)
                {
                    UserName = response.account.a.Single<attrN>(a => a.name == "displayName").Value;
                    //UserName = response.account.a[0].Value;
                }
            }
            catch
            {
                return null;
            }

            return UserName;
        }

        #endregion

        #region Locking User

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public override bool UnlockUser(string userName)
        {
            return Task.Run(async () => await UnlockUserAsync(userName)).Result;
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public async Task<bool> UnlockUserAsync(string userName)
        {
            bool unlocked = false;
            if (!Initialized)
            {
                SetConfiguration();
                await InitializeAsync(string.Empty, new NameValueCollection());

                if (!Initialized)
                {
                    string message = String.Format("Membership Provider {0}: {1}", this.applicationName, "The provider was not initialized.");
                    LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                    throw new ProviderException(message);
                }
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

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public async Task<bool> LockUserAsync(string userName)
        {
            bool unlocked = false;

            if (!Initialized)
            {
                SetConfiguration();
                await InitializeAsync(string.Empty, new NameValueCollection());

                if (!Initialized)
                {
                    string message = String.Format("Membership Provider {0}: {1}", this.applicationName, "The provider was not initialized.");
                    LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                    throw new ProviderException(message);
                }
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
            Tuple<System.Web.Security.MembershipCreateStatus, System.Web.Security.MembershipUser> result;
            result = Task.Run(async () => await CreateUserAsync(username, password, email, passwordQuestion, passwordAnswer, isApproved, providerUserKey)).Result;
            status = result.Item1;
            return result.Item2;
        }

        public async Task<Tuple<System.Web.Security.MembershipCreateStatus, System.Web.Security.MembershipUser>> CreateUserAsync(string username, string password, string email, string passwordQuestion, string passwordAnswer, bool isApproved, object providerUserKey)//, out System.Web.Security.MembershipCreateStatus status)
        {
            MembershipUser zuser = null;
            System.Web.Security.MembershipCreateStatus status;

            if (!Initialized)
            {
                SetConfiguration();
                await InitializeAsync(string.Empty, new NameValueCollection());

                if (!Initialized)
                {
                    string message = String.Format("Membership Provider {0}: {1}", this.applicationName, "The provider was not initialized.");
                    LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                    throw new ProviderException(message);
                }
            }

            List<attrN> properties = new List<attrN>();

            properties.Add(new attrN { name = "zimbraAccountStatus", Value = "active" });

            if (username != email)
            {
                properties.Add(new attrN { name = "zimbraPrefMailLocalDeliveryDisabled", Value = "TRUE" });
                properties.Add(new attrN { name = "zimbraPrefMailForwardingAddress", Value = email });
            }

            Zimbra.Administration.CreateAccountRequest create = new Zimbra.Administration.CreateAccountRequest { name = username, password = password, a = properties };
            Zimbra.Administration.CreateAccountResponse created = await zimbraServer.Message(create) as Zimbra.Administration.CreateAccountResponse;

            if (created != null)
            {
                status = MembershipCreateStatus.Success;
                zuser = GetUser(username, false);
            }
            else
            {
                status = MembershipCreateStatus.ProviderError;
                zuser = null;
            }

            return new Tuple<MembershipCreateStatus,MembershipUser>(status,zuser);
        }

        #endregion

        #region Delete Region

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="username"></param>
        /// <param name="deleteAllRelatedData"></param>
        /// <returns></returns>
        public override bool DeleteUser(string username, bool deleteAllRelatedData)
        {
            return Task.Run(async () => await DeleteUserAsync(username, deleteAllRelatedData)).Result;
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="username"></param>
        /// <param name="deleteAllRelatedData"></param>
        /// <returns></returns>
        public async Task<bool> DeleteUserAsync(string username, bool deleteAllRelatedData)
        {
            if (!Initialized)
            {
                SetConfiguration();
                await InitializeAsync(string.Empty, new NameValueCollection());

                if (!Initialized)
                {
                    string message = String.Format("Membership Provider {0}: {1}", this.applicationName, "The provider was not initialized.");
                    LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                    throw new ProviderException(message);
                }
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

        public async Task UpdateZimbraUserAsync(ZimbraMembershipUser zuser)
        {
            await UpdateUserAsync(zuser as MembershipUser);
        }
        public override void UpdateUser(System.Web.Security.MembershipUser user)
        {
            Task.Run(async () => await UpdateUserAsync(user));
        }

        public async Task UpdateUserAsync(System.Web.Security.MembershipUser user)
        {
            ZimbraMembershipUser zuser = user as ZimbraMembershipUser;

            if (!Initialized)
            {
                SetConfiguration();
                await InitializeAsync(string.Empty, new NameValueCollection());

                if (!Initialized)
                {
                    string message = String.Format("Membership Provider {0}: {1}", this.applicationName, "The provider was not initialized.");
                    LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                    throw new ProviderException(message);
                }
            }

            try
            {
                string zimbraId = null;
                List<attrN> properties = new List<attrN>();

                MembershipUser membershipUser = new MembershipUser(this.Name, "Fake", null, "fake@zimbra.com", "Fake", "Fake", false, true, DateTime.Now, DateTime.Now, DateTime.Now, DateTime.Now, DateTime.Now);
                List<PropertyInfo> basepropertyInfos = membershipUser.GetType().GetProperties().ToList<PropertyInfo>();
                List<PropertyInfo> propertyInfos = zuser.GetType().GetProperties().ToList<PropertyInfo>();

                //Remove Immutables
                PropertyInfo uid = propertyInfos.SingleOrDefault(p => p.Name == "uid");
                propertyInfos.Remove(uid);

                PropertyInfo zimbraMailDeliveryAddress = propertyInfos.SingleOrDefault(p => p.Name == "zimbraMailDeliveryAddress");
                propertyInfos.Remove(zimbraMailDeliveryAddress);

                PropertyInfo zimbraLastLogonTimestamp = propertyInfos.SingleOrDefault(p => p.Name == "zimbraLastLogonTimestamp");
                propertyInfos.Remove(zimbraLastLogonTimestamp);

                PropertyInfo zimbraMailAlias = propertyInfos.SingleOrDefault(p => p.Name == "zimbraMailAlias");
                propertyInfos.Remove(zimbraMailAlias);

                PropertyInfo zimbraPasswordModifiedTime = propertyInfos.SingleOrDefault(p => p.Name == "zimbraPasswordModifiedTime");
                propertyInfos.Remove(zimbraPasswordModifiedTime);

                PropertyInfo Email = propertyInfos.SingleOrDefault(p => p.Name == "Email");
                propertyInfos.Remove(Email);

                PropertyInfo zimbraMail = propertyInfos.SingleOrDefault(p => p.Name == "zimbraMail");
                propertyInfos.Remove(zimbraMail);

                PropertyInfo LastActivityDate = propertyInfos.SingleOrDefault(p => p.Name == "LastActivityDate");
                propertyInfos.Remove(LastActivityDate);

                PropertyInfo LastLoginDate = propertyInfos.SingleOrDefault(p => p.Name == "LastLoginDate");
                propertyInfos.Remove(LastLoginDate);

                PropertyInfo zimbraCreateTimestamp = propertyInfos.SingleOrDefault(p => p.Name == "zimbraCreateTimestamp");
                propertyInfos.Remove(zimbraCreateTimestamp);

                PropertyInfo IsApproved = propertyInfos.SingleOrDefault(p => p.Name == "IsApproved");
                propertyInfos.Remove(IsApproved);
                
                foreach (PropertyInfo propertyInfo in propertyInfos)
                {
                    if (propertyInfo.CanWrite)
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
                }

                if (!string.IsNullOrWhiteSpace(zimbraId) && properties.Count > 0)
                {
                    Zimbra.Administration.ModifyAccountRequest modify = new Zimbra.Administration.ModifyAccountRequest { id = zimbraId, a = properties };
                    Zimbra.Administration.ModifyAccountResponse modified = await zimbraServer.Message(modify) as Zimbra.Administration.ModifyAccountResponse;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Validate User

        public override bool ValidateUser(string username, string password)
        {
            return Task.Run(async () => await ValidateUserAsync(username, password)).Result;
        }

        public async Task<bool> ValidateUserAsync(string username, string password)
        {
            bool validated = false;

            if (!Initialized)
            {
                SetConfiguration();
                await InitializeAsync(string.Empty, new NameValueCollection());

                if (!Initialized)
                {
                    string message = String.Format("Membership Provider {0}: {1}", this.applicationName, "The provider was not initialized.");
                    LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                    throw new ProviderException(message);
                }
            }

            try
            {

                Zimbra.Administration.GetAccountInfoRequest request = new Zimbra.Administration.GetAccountInfoRequest { account = new Zimbra.Global.accountSelector { by = Zimbra.Global.accountBy.Name, Value = username } };
                Zimbra.Administration.GetAccountInfoResponse response = await zimbraServer.Message(request) as Zimbra.Administration.GetAccountInfoResponse;
                if (response != null)
                {
                    using (Zimbra.ZimbraServer clientServer = new Zimbra.ZimbraServer(zimbraconfiguration.Server.ServerName))
                    {
                        string AuthToken = clientServer.Authenticate(username, password);
                        //ZimbraCookie(AuthToken);
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

        #region helpers

        public static string GetZimbraDomain(string url)
        {
            StringBuilder returnUrl = new StringBuilder();

            Uri uri = new Uri(url);
            if (uri.HostNameType == UriHostNameType.Dns)
            {
                string[] parts = uri.DnsSafeHost.Split(new char[] { '.' });
                if (parts.Length > 1)
                {
                    if (parts.Length == 2)
                    {
                        returnUrl.Append(parts[0] + "." + parts[1]);
                    }

                    if (parts.Length == 3)
                    {
                        if ((parts[1].ToLower() == "clubcloud") && ((parts[0].ToLower() != "www") && (parts[0].ToLower() != "mijn") && (parts[0].ToLower() != "afhangen") && (parts[0].ToLower() != "websites") && (parts[0].ToLower() != "development")))
                        {
                            returnUrl.Append(parts[0] + "." + parts[2]);
                        }
                        else
                        {
                            returnUrl.Append(parts[1] + "." + parts[2]);
                        }
                    }
                }
                else
                {
                    return "clubcloud.nl";
                }
            }
            return returnUrl.ToString();
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
