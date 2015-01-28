using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;
using System.Collections.Generic;
using ClubCloud.Common;

namespace ClubCloud.SignalR.Features.SignalR
{
    /// <summary>
    /// This class handles events raised during feature activation, deactivation, installation, uninstallation, and upgrade.
    /// </summary>
    /// <remarks>
    /// The GUID attached to this class may be used during packaging and should not be modified.
    /// </remarks>
    [Guid("f4869fab-87a8-435b-a5c9-a3aee99703ec")]
    public class SignalREventReceiver : SPFeatureReceiver
    {
        // Uncomment the method below to handle the event raised after a feature has been activated.
        internal SPWebApplication webApp;

        public override void FeatureActivated(SPFeatureReceiverProperties properties)
        {
            ClubCloud.Common.RemoteAdministrator.Enable();

            FeatureCleaning(properties);

            if (properties.Feature.Parent.GetType() == typeof(SPWebApplication))
            {
                webApp = properties.Feature.Parent as SPWebApplication;
                SPWebApplication wap = SPWebService.ContentService.WebApplications[webApp.Id];

                List<SPWebConfigModification> process = new List<SPWebConfigModification>();
                process.AddRange(ClubCloud.SignalR.SignalR.Modifications);

                foreach (SPWebConfigModification mod in process)
                {
                    try
                    {
                        if (!wap.WebConfigModifications.Contains(mod))
                        {
                            wap.WebConfigModifications.Add(mod);
                        }

                        if (!SPWebService.ContentService.WebApplications[wap.Id].WebConfigModifications.Contains(mod))
                        {
                            SPWebService.ContentService.WebApplications[wap.Id].WebConfigModifications.Add(mod);
                        }
                    }
                    catch { };
                }

                try
                {
                    wap.Update();
                    SPWebService.ContentService.WebApplications[wap.Id].Update();
                    SPWebService.ContentService.WebApplications[wap.Id].WebService.ApplyWebConfigModifications();
                    //webApp.Farm.Services.GetValue<SPWebService>().ApplyWebConfigModifications();
                }
                catch { };
            }

        }


        public override void FeatureDeactivating(SPFeatureReceiverProperties properties)
        {
            ClubCloud.Common.RemoteAdministrator.Enable();

            FeatureCleaning(properties);

            if (properties.Feature.Parent.GetType() == typeof(SPWebApplication))
            {
                webApp = properties.Feature.Parent as SPWebApplication;
                SPWebApplication wap = SPWebService.ContentService.WebApplications[webApp.Id];

                List<SPWebConfigModification> process = new List<SPWebConfigModification>();
                process.AddRange(ClubCloud.SignalR.SignalR.Modifications);

                foreach (SPWebConfigModification mod in process)
                {
                    try
                    {
                        if (wap.WebConfigModifications.Contains(mod))
                        {
                            wap.WebConfigModifications.Remove(mod);
                        }

                        if (SPWebService.ContentService.WebApplications[wap.Id].WebConfigModifications.Contains(mod))
                        {
                            SPWebService.ContentService.WebApplications[wap.Id].WebConfigModifications.Remove(mod);
                        }
                    }
                    catch { };
                }

                try
                {
                    wap.Update();
                    SPWebService.ContentService.WebApplications[wap.Id].Update();
                    SPWebService.ContentService.WebApplications[wap.Id].WebService.ApplyWebConfigModifications();
                    //webApp.Farm.Services.GetValue<SPWebService>().ApplyWebConfigModifications();
                }
                catch { };
            }
        }


        // Uncomment the method below to handle the event raised after a feature has been installed.

        //public override void FeatureInstalled(SPFeatureReceiverProperties properties)
        //{
        //}

        /// <summary>
        /// ClubCloud Common deinstallation, clear all modification owned by this feature.
        /// </summary>
        /// <param name="properties"></param>
        public override void FeatureUninstalling(SPFeatureReceiverProperties properties)
        {

            ClubCloud.Common.RemoteAdministrator.Enable();

            bool found = false;
            foreach (SPWebApplication wap in SPWebService.ContentService.WebApplications)
            {
                List<SPWebConfigModification> toDelete = new List<SPWebConfigModification>();

                try
                {

                    foreach (SPWebConfigModification mod in wap.WebConfigModifications)
                    {
                        if (mod.Owner.Contains("SignalR"))
                        {
                            toDelete.Add(mod);
                            found = true;
                        }
                    }

                    foreach (SPWebConfigModification mod in toDelete)
                    {
                        wap.WebConfigModifications.Remove(mod);
                        SPWebService.ContentService.WebApplications[wap.Id].WebConfigModifications.Remove(mod);
                    }

                    wap.Update(false);
                    SPWebService.ContentService.WebApplications[wap.Id].Update(false);
                    SPWebService.ContentService.WebApplications[wap.Id].WebService.ApplyWebConfigModifications();

                }
                catch { found = true; }
            }

            if (found)
            {
                FeatureUninstalling(properties);
            }
        }

        // Uncomment the method below to handle the event raised when a feature is upgrading.

        //public override void FeatureUpgrading(SPFeatureReceiverProperties properties, string upgradeActionName, System.Collections.Generic.IDictionary<string, string> parameters)
        //{
        //}

        private void FeatureCleaning(SPFeatureReceiverProperties properties)
        {
            if (properties.Feature.Parent.GetType() == typeof(SPWebApplication))
            {
                webApp = properties.Feature.Parent as SPWebApplication;
                SPWebApplication wap = SPWebService.ContentService.WebApplications[webApp.Id];

                List<SPWebConfigModification> toDelete = new List<SPWebConfigModification>();
                bool found = false;
                try
                {

                    foreach (SPWebConfigModification mod in wap.WebConfigModifications)
                    {
                        if (mod.Owner.Contains("SignalR"))
                        {
                            toDelete.Add(mod);
                            found = true;
                        }
                    }

                    foreach (SPWebConfigModification mod in toDelete)
                    {
                        wap.WebConfigModifications.Remove(mod);
                        SPWebService.ContentService.WebApplications[wap.Id].WebConfigModifications.Remove(mod);
                    }

                    wap.Update();
                    SPWebService.ContentService.WebApplications[wap.Id].Update();
                    SPWebService.ContentService.WebApplications[wap.Id].WebService.ApplyWebConfigModifications();

                }
                catch { found = true; }
                finally { toDelete = new List<SPWebConfigModification>(); }

                if (found)
                {
                    FeatureUninstalling(properties);
                }
            }
        }
    }
}
