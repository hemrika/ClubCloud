using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;

namespace ClubCloud.Afhangen.Features.Afhangen
{
    /// <summary>
    /// This class handles events raised during feature activation, deactivation, installation, uninstallation, and upgrade.
    /// </summary>
    /// <remarks>
    /// The GUID attached to this class may be used during packaging and should not be modified.
    /// </remarks>

    [Guid("cc952f26-a866-4cec-a8cf-c22634653927")]
    public class AfhangenEventReceiver : SPFeatureReceiver
    {
        // Uncomment the method below to handle the event raised after a feature has been activated.

        public override void FeatureActivated(SPFeatureReceiverProperties properties)
        {
            SPWebApplication webApp = properties.Feature.Parent as SPWebApplication;

            var configModAssembly = new SPWebConfigModification
            {
                Name = "add[@assembly=\"AjaxControlToolkit, Version=4.5.7.1213, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e\"]",
                Owner = "AjaxControlToolkitWebConfig",
                Path = "configuration/system.web/compilation/assemblies",
                Type = SPWebConfigModification.SPWebConfigModificationType.EnsureChildNode,
                Value = "<add assembly=\"AjaxControlToolkit, Version=4.5.7.1213, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e\" />"

            };

            webApp.WebConfigModifications.Add(configModAssembly);

            var configModcontrols = new SPWebConfigModification
            {
                Name = "add[@tagPrefix=\"ajaxToolkit\" assembly=\"AjaxControlToolkit, Version=4.5.7.1213, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e\" namespace=\"AjaxControlToolkit\"]",
                Owner = "AjaxControlToolkitWebConfig",
                Path = "configuration/system.web/compilation/assemblies",
                Type = SPWebConfigModification.SPWebConfigModificationType.EnsureChildNode,
                Value = "<add tagPrefix=\"ajaxToolkit\" assembly=\"AjaxControlToolkit, Version=4.5.7.1213, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e\" namespace=\"AjaxControlToolkit\" />"

            };

            webApp.WebConfigModifications.Add(configModcontrols);

            /*Call Update and ApplyWebConfigModifications to save changes*/
            SPWebService.ContentService.WebApplications[webApp.Id].WebConfigModifications.Add(configModAssembly);
            SPWebService.ContentService.WebApplications[webApp.Id].WebConfigModifications.Add(configModcontrols);
            SPWebService.ContentService.WebApplications[webApp.Id].Update();
            SPWebService.ContentService.WebApplications[webApp.Id].WebService.ApplyWebConfigModifications();
        }


        // Uncomment the method below to handle the event raised before a feature is deactivated.

        //public override void FeatureDeactivating(SPFeatureReceiverProperties properties)
        //{
        //}


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
