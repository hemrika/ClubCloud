using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;

namespace ClubCloud.Provider.Features.Zimbra_UserSettings
{
    /// <summary>
    /// This class handles events raised during feature activation, deactivation, installation, uninstallation, and upgrade.
    /// </summary>
    /// <remarks>
    /// The GUID attached to this class may be used during packaging and should not be modified.
    /// </remarks>

    [Guid("e1b6fa45-fee3-4e6d-ba63-1a37efcc049c")]
    public class Zimbra_UserSettingsEventReceiver : SPUserSettingsProviderFeatureReceiver
    {
        // Uncomment the method below to handle the event raised after a feature has been activated.

        public override void FeatureActivated(SPFeatureReceiverProperties properties)
        {
            base.FeatureActivated(properties);
        }


        // Uncomment the method below to handle the event raised before a feature is deactivated.

        public override void FeatureDeactivating(SPFeatureReceiverProperties properties)
        {
            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                //base.RemoveClaimProvider(ZimbraClaimProvider.ZimbraName);

            });
            base.FeatureDeactivating(properties);
        }


        // Uncomment the method below to handle the event raised after a feature has been installed.

        //public override void FeatureInstalled(SPFeatureReceiverProperties properties)
        //{
        //}


        // Uncomment the method below to handle the event raised before a feature is uninstalled.

        //public override void FeatureUninstalling(SPFeatureReceiverProperties properties)
        //{
        //}

        // Uncomment the method below to handle the event raised when a feature is upgrading.

        //public override void FeatureUpgrading(SPFeatureReceiverProperties properties, string upgradeActionName, System.Collections.Generic.IDictionary<string, string> parameters)
        //{
        //}

        public override string UserSettingsProviderAssemblyName
        {
            get { return this.GetType().Assembly.FullName; }
        }

        public override string UserSettingsProviderDisplayName
        {
            get { return "ZimbraUserSettings"; }
        }

        public override Guid UserSettingsProviderIdentifier
        {
            get { return new Guid("B0FB9FD3-F138-49CA-A928-5209253D3036"); }
        }

        public override string UserSettingsProviderTypeName
        {
            get { return typeof(ZimbraUserSettingsProvider).FullName; }
        } 
    }
}
