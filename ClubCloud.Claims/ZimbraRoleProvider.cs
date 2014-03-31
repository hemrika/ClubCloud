using Microsoft.SharePoint.Administration;
using System;
using System.Collections.Generic;
using System.Configuration.Provider;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;

namespace ClubCloud.Provider
{
    class ZimbraRoleProvider : System.Web.Security.RoleProvider
    {
        private bool Initialized;
        private string applicationName;
        private Zimbra.ZimbraServer zimbraServer;
        private ZimbraProviderSettings zimbraSettings;
        private Zimbra.Global.VersionInfo zimbraVersion;
        private string AdminToken;

        protected ZimbraRoleProvider() : base()
        {

        }

        public override string Name
        {
            get
            {
                return "ZimbraRoleProvider";
            }
        }

        public override string Description
        {
            get
            {
                return "Zimbra Role Provider";
            }
        }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
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
                    string message = String.Format("Error while initializing settings Role Provider {0}: {1}", this.applicationName, "Zimbra Provider kan niet in AspNetHostingPermissionLevel.Low werken.");
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
                this.applicationName = "ZimbraRoleProvider";
            }
            else
            {
                this.applicationName = name;
            }

            try
            {
                zimbraSettings = ZimbraProviderSettings.Current;

                if (zimbraSettings == null || String.IsNullOrEmpty(zimbraSettings.ZimbraServer) || String.IsNullOrEmpty(zimbraSettings.ZimbraUserName) || String.IsNullOrEmpty(zimbraSettings.ZimbraPassword))
                {
                    string message = String.Format("Error while initializing settings Role Provider {0}: {1}", this.applicationName, "The setting for Zimbra are not complete.");
                    LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                    throw new ProviderException(message);

                }
            }
            catch (ZimbraSettingsException zex)
            {
                string message = String.Format("Error while initializing settings Role Provider {0}: {1}", this.applicationName, zex.Message);
                LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                throw new ProviderException(message, zex);
            }

            if (string.IsNullOrEmpty(zimbraSettings.ZimbraServer.Trim()))
            {
                string message = String.Format("Error while initializing settings Role Provider {0}: {1}", this.applicationName, "The Zimbra server name can not be empty.");
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
            //GetPasswordProperties();

            //GetLockProperties();

            this.Initialized = true;
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public override string[] GetRolesForUser(string username)
        {
            throw new NotImplementedException();
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool IsUserInRole(string username, string roleName)
        {
            throw new NotImplementedException();
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }

        #region ULS

        public static void LogToULS(string message, TraceSeverity traceSeverity, EventSeverity eventSeverity)
        {
            try
            {
                SPDiagnosticsCategory category = new SPDiagnosticsCategory("Zimbra Role Provider", traceSeverity, eventSeverity);
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
