using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Security;

namespace ClubCloud.Administratie.Features.ClubCloudPages
{
    /// <summary>
    /// This class handles events raised during feature activation, deactivation, installation, uninstallation, and upgrade.
    /// </summary>
    /// <remarks>
    /// The GUID attached to this class may be used during packaging and should not be modified.
    /// </remarks>

    [Guid("d5efd220-64ea-460d-8107-e37d55cd915b")]
    public class ClubCloudPagesEventReceiver : SPFeatureReceiver
    {
        // Uncomment the method below to handle the event raised after a feature has been activated.

        [SharePointPermission(SecurityAction.LinkDemand, ObjectModel = true)]
        public override void FeatureActivated(SPFeatureReceiverProperties properties)
        {
            SPSecurity.RunWithElevatedPrivileges(delegate()
            {

                try
                {
                    var site = (SPSite)properties.Feature.Parent;
                    site.RootWeb.RootFolder.WelcomePage = "/default.aspx";
                    site.RootWeb.AnonymousState = SPWeb.WebAnonymousState.On;
                    site.RootWeb.RootFolder.Update();
                }
                catch { }

                //Minimale downloadstrategie
                try
                {
                    var site = (SPSite)properties.Feature.Parent;
                    site.Features.Remove(new Guid("87294c72-f260-42f3-a41b-981a2ffce37a"), true);
                    site.WebApplication.Update();
                }
                catch { }

                //Weergave voor mobiele browsers
                try
                {
                    var site = (SPSite)properties.Feature.Parent;
                    site.Features.Remove(new Guid("d95c97f3-e528-4da2-ae9f-32b3535fbb59"), true);
                    site.WebApplication.Update();
                }
                catch { }

                //Documenten standaard openen in clienttoepassingen
                try
                {
                    var site = (SPSite)properties.Feature.Parent;
                    site.RootWeb.Features.Add(new Guid("8a4b8de2-6fd8-41e9-923c-c7c3c00f8295"), true);
                    site.RootWeb.Update();
                }
                catch { }
            });
        }

        /// <summary>
        /// TODO: Add comment to describe the actions during feature deactivation
        /// </summary>
        /// <param name="properties">Properties of the feature</param>
        [SharePointPermission(SecurityAction.LinkDemand, ObjectModel = true)]
        public override void FeatureDeactivating(SPFeatureReceiverProperties properties)
        {
            SPSecurity.RunWithElevatedPrivileges(delegate()
            {

                try
                {
                    var site = (SPSite)properties.Feature.Parent;
                    site.RootWeb.RootFolder.WelcomePage = "/default.aspx";
                    site.RootWeb.AnonymousState = SPWeb.WebAnonymousState.Disabled;
                    site.RootWeb.RootFolder.Update();
                }
                catch { }

                //Minimale downloadstrategie
                try
                {
                    var site = (SPSite)properties.Feature.Parent;
                    site.Features.Add(new Guid("87294c72-f260-42f3-a41b-981a2ffce37a"), true);
                    site.WebApplication.Update();
                }
                catch { }

                //Weergave voor mobiele browsers
                try
                {
                    var site = (SPSite)properties.Feature.Parent;
                    site.Features.Add(new Guid("d95c97f3-e528-4da2-ae9f-32b3535fbb59"), true);
                    site.WebApplication.Update();
                }
                catch { }

                //Documenten standaard openen in clienttoepassingen
                try
                {
                    var site = (SPSite)properties.Feature.Parent;
                    site.RootWeb.Features.Remove(new Guid("8a4b8de2-6fd8-41e9-923c-c7c3c00f8295"), true);
                    site.RootWeb.Update();
                }
                catch { }
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
