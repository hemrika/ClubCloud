using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.SharePoint;

namespace ClubCloud.Provider.Features.Zimbra_Receivers
{
    /// <summary>
    /// This class handles events raised during feature activation, deactivation, installation, uninstallation, and upgrade.
    /// </summary>
    /// <remarks>
    /// The GUID attached to this class may be used during packaging and should not be modified.
    /// </remarks>

    [Guid("2e713462-e1f6-4d9f-93b2-d69c86b2b335")]
    public class Zimbra_ReceiversEventReceiver : SPFeatureReceiver
    {
        // Uncomment the method below to handle the event raised after a feature has been activated.

        public override void FeatureActivated(SPFeatureReceiverProperties properties)
        {
            SPSecurity.RunWithElevatedPrivileges(delegate()
            {

                if (properties.Feature.Parent.GetType() == typeof(SPWeb))
                {
                    SPWeb web = properties.Feature.Parent as SPWeb;

                    ZimbraGroupEventReceiver.CreateReceiverDefinitions(web);
                    ZimbraRoleEventReceiver.CreateReceiverDefinitions(web);

                }
            });
        }


        // Uncomment the method below to handle the event raised before a feature is deactivated.

        public override void FeatureDeactivating(SPFeatureReceiverProperties properties)
        {
            SPSecurity.RunWithElevatedPrivileges(delegate()
            {

                if (properties.Feature.Parent.GetType() == typeof(SPWeb))
                {
                    SPWeb web = properties.Feature.Parent as SPWeb;

                    ZimbraGroupEventReceiver.RemoveReceiverDefinitions(web);
                    ZimbraRoleEventReceiver.RemoveReceiverDefinitions(web);

                }
            });
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
    }
}
