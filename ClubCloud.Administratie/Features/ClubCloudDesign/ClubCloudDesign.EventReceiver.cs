using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Security;

namespace ClubCloud.Administratie.Features.ClubCloudDesign
{
    /// <summary>
    /// This class handles events raised during feature activation, deactivation, installation, uninstallation, and upgrade.
    /// </summary>
    /// <remarks>
    /// The GUID attached to this class may be used during packaging and should not be modified.
    /// </remarks>

    [Guid("6c26d96a-9a6f-479d-a931-3b9fd67c0de4")]
    public class ClubCloudDesignEventReceiver : SPFeatureReceiver
    {
        // Uncomment the method below to handle the event raised after a feature has been activated.

        [SharePointPermission(SecurityAction.LinkDemand, ObjectModel = true)]
        public override void FeatureActivated(SPFeatureReceiverProperties properties)
        {
            var site = (SPSite)properties.Feature.Parent;
            site.RootWeb.MasterUrl = site.RootWeb.ServerRelativeUrl + "_catalogs/masterpage/ClubCloud.master";
            site.RootWeb.CustomMasterUrl = site.RootWeb.ServerRelativeUrl + "_catalogs/masterpage/ClubCloud.master";
            site.RootWeb.Update();
        }

        /// <summary>
        /// TODO: Add comment to describe the actions during feature deactivation
        /// </summary>
        /// <param name="properties">Properties of the feature</param>
        [SharePointPermission(SecurityAction.LinkDemand, ObjectModel = true)]
        public override void FeatureDeactivating(SPFeatureReceiverProperties properties)
        {
            var site = (SPSite)properties.Feature.Parent;
            site.RootWeb.MasterUrl = site.RootWeb.ServerRelativeUrl + "_catalogs/masterpage/seattle.master";
            site.RootWeb.CustomMasterUrl = site.RootWeb.ServerRelativeUrl + "_catalogs/masterpage/seattle.master";
            site.RootWeb.Update();
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
