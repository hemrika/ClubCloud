using Microsoft.SharePoint.Administration;
using Microsoft.SharePoint.Administration.Backup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Provider
{
    [GuidAttribute("2F657B81-3710-41F5-B4B9-4A2B3522B897")]
    internal class ZimbraProviderSettings : SPPersistedObject, IBackupRestore
    {

        public const string ZimbraPersistedObjectName = "ZimbraProviderSettings";
        public const string ZimbraPersistedObjectDisplayName = "Zimbra Provider Settings";
        public const string ZimbraPersistedObjectId = "2F657B81-3710-41F5-B4B9-4A2B3522B897";

        public ZimbraProviderSettings()
            : base(ZimbraPersistedObjectName, SPFarm.Local, Guid.Parse(ZimbraPersistedObjectId))
        {
            this.Name = ZimbraPersistedObjectName;
            this.Id = Guid.Parse(ZimbraPersistedObjectId);
        }

        public ZimbraProviderSettings(SPPersistedObject parent)
            : base(ZimbraPersistedObjectName, parent, Guid.Parse(ZimbraPersistedObjectId))
        {
        }

        protected override bool HasAdditionalUpdateAccess()
        {
            return false;
        }

        public override string DisplayName
        {
            get
            {
                return ZimbraPersistedObjectDisplayName;
            }
        }

        [Persisted]
        public string ZimbraServer;

        [Persisted]
        public string ZimbraUserName;

        [Persisted]
        public string ZimbraPassword;

        [Persisted]
        public string ZimbraClassOfService;
        
        public static ZimbraProviderSettings Current
        {
            get
            {
                ZimbraProviderSettings child = null;
                SPPersistedObject parent = SPFarm.Local;
                try
                {
                    child = parent.GetChild<ZimbraProviderSettings>();

                    if (child == null)
                    {
                        child = parent.GetChild<ZimbraProviderSettings>(ZimbraPersistedObjectName);
                    }
                }
                catch (Exception ex)
                {
                    string message = String.Format("Error while retrieving SPPersistedObject {0}: {1}", ZimbraPersistedObjectName, ex.Message);
                    LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                    throw new ZimbraSettingsException(message, ex);
                }
                return child;
            }
        }

        public static ZimbraProviderSettings Default
        {
            get
            {
                ZimbraProviderSettings child = null;
                SPPersistedObject parent = SPFarm.Local;
                try
                {
                    child = parent.GetChild<ZimbraProviderSettings>();

                    if (child == null)
                    {
                        child = parent.GetChild<ZimbraProviderSettings>(ZimbraPersistedObjectName);
                    }
                }
                catch (Exception)
                {
                    child = new ZimbraProviderSettings();
                    child.ZimbraServer = "mail.clubcloud.nl";
                    child.ZimbraUserName = "admin@clubcloud.nl";
                    child.ZimbraPassword = "rjm557308453!";
                    child.ZimbraClassOfService = "clubcloud";
                }

                try
                {
                    if (!child.WasCreated)
                    { child.Provision(); }
                    else
                    { child.Update(true); }
                }
                catch (Exception ex)
                {
                    string message = String.Format("Error while provisioning SPPersistedObject {0}: {1}", ZimbraPersistedObjectName, ex.Message);
                    LogToULS(message, TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                    throw new ZimbraSettingsException(message, ex);
                }

                return child;
            }
        }

        public static void LogToULS(string message, TraceSeverity traceSeverity, EventSeverity eventSeverity)
        {
            try
            {
                SPDiagnosticsCategory category = new SPDiagnosticsCategory("Zimbra Settings", traceSeverity, eventSeverity);
                SPDiagnosticsService ds = SPDiagnosticsService.Local;
                ds.WriteTrace(0, category, traceSeverity, message);
            }
            catch
            {
            }
        }

        #region Backup
        public void AddBackupObjects(SPBackupRestoreObject parent)
        {
            throw new NotImplementedException();
        }

        public bool CanRenameOnRestore
        {
            get { throw new NotImplementedException(); }
        }

        public bool CanSelectForBackup
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public bool CanSelectForRestore
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public ulong DiskSizeRequired
        {
            get { throw new NotImplementedException(); }
        }

        public bool OnAbort(object sender, SPBackupRestoreInformation args)
        {
            throw new NotImplementedException();
        }

        public bool OnBackup(object sender, SPBackupInformation args)
        {
            throw new NotImplementedException();
        }

        public bool OnBackupComplete(object sender, SPBackupInformation args)
        {
            throw new NotImplementedException();
        }

        public bool OnPostRestore(object sender, SPRestoreInformation args)
        {
            throw new NotImplementedException();
        }

        public bool OnPreRestore(object sender, SPRestoreInformation args)
        {
            throw new NotImplementedException();
        }

        public bool OnPrepareBackup(object sender, SPBackupInformation args)
        {
            throw new NotImplementedException();
        }

        public bool OnRestore(object sender, SPRestoreInformation args)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
