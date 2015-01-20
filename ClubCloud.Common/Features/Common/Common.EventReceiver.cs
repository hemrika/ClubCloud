using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;
using System.Collections.Generic;

namespace ClubCloud.Common.Features.Common
{
    /// <summary>
    /// This class handles events raised during feature activation, deactivation, installation, uninstallation, and upgrade.
    /// </summary>
    /// <remarks>
    /// The GUID attached to this class may be used during packaging and should not be modified.
    /// </remarks>

    [Guid("afe536c3-51b4-4191-a828-cdb26704c50e")]
    public class CommonEventReceiver : SPFeatureReceiver
    {
        // Uncomment the method below to handle the event raised after a feature has been activated.
        internal SPWebApplication webApp;

        public override void FeatureActivated(SPFeatureReceiverProperties properties)
        {
            if (properties.Feature.Parent.GetType() == typeof(SPWebApplication))
            {
                webApp = properties.Feature.Parent as SPWebApplication;

                List<SPWebConfigModification> process = new List<SPWebConfigModification>();
                process.AddRange(ClubCloud.Common.Common.Modifications);
                process.AddRange(Syncfusion.Modifications);
                process.AddRange(Ajax.Modifications);
                //process.AddRange(CrossSiteScripting.Modifications);

                foreach (SPWebConfigModification mod in process)
                {
                    try
                    {
                        webApp.WebConfigModifications.Add(mod);
                        SPWebService.ContentService.WebApplications[webApp.Id].WebConfigModifications.Add(mod);
                    }
                    catch { };
                }

                try
                {
                    webApp.Update();

                    SPWebService.ContentService.WebApplications[webApp.Id].Update();
                    SPWebService.ContentService.WebApplications[webApp.Id].WebService.ApplyWebConfigModifications();
                    //webApp.Farm.Services.GetValue<SPWebService>().ApplyWebConfigModifications();
                }
                catch { };
            }
        }


        public override void FeatureDeactivating(SPFeatureReceiverProperties properties)
        {
            if (properties.Feature.Parent.GetType() == typeof(SPWebApplication))
            {
                webApp = properties.Feature.Parent as SPWebApplication;

                List<SPWebConfigModification> process = new List<SPWebConfigModification>();
                process.AddRange(ClubCloud.Common.Common.Modifications);
                process.AddRange(Syncfusion.Modifications);
                process.AddRange(Ajax.Modifications);
                process.AddRange(CrossSiteScripting.Modifications);

                foreach (SPWebConfigModification mod in process)
                {
                    try
                    {
                        webApp.WebConfigModifications.Remove(mod);                        
                        SPWebService.ContentService.WebApplications[webApp.Id].WebConfigModifications.Remove(mod);
                    }
                    catch { };
                }

                try
                {
                    webApp.Update();
                    SPWebService.ContentService.WebApplications[webApp.Id].Update();
                    SPWebService.ContentService.WebApplications[webApp.Id].WebService.ApplyWebConfigModifications();
                    //webApp.Farm.Services.GetValue<SPWebService>().ApplyWebConfigModifications();
                }
                catch { };

                /*
                foreach (SPWebConfigModification mod in ClubCloud.Common.Common.Modifications)
                {
                    webApp.WebConfigModifications.Remove(mod);
                    SPWebService.ContentService.WebApplications[webApp.Id].WebConfigModifications.Remove(mod);
                }

                foreach (SPWebConfigModification mod in Syncfusion.Modifications)
                {
                    webApp.WebConfigModifications.Remove(mod);
                    SPWebService.ContentService.WebApplications[webApp.Id].WebConfigModifications.Remove(mod);
                }

                foreach (SPWebConfigModification mod in Ajax.Modifications)
                {
                    webApp.WebConfigModifications.Remove(mod);
                    SPWebService.ContentService.WebApplications[webApp.Id].WebConfigModifications.Remove(mod);
                }
                */
                
                //List<SPWebConfigModification> toDelete = new List<SPWebConfigModification>();
                /*
                foreach (SPWebConfigModification mod in webApp.WebConfigModifications)
                {
                    string name = mod.Name;
                    string owner = mod.Owner;
                    string path = mod.Path;
                    Microsoft.SharePoint.Administration.SPWebConfigModification.SPWebConfigModificationType type = mod.Type;
                    string value = mod.Value;

                    if (mod.Name == "ClubCloudSaveControls")
                    {
                        mod.Name = "SafeControl[@Assembly='ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e'][@Namespace='ClubCloud.Common.Controls'][@TypeName='*'][@Safe='True'][SafeAgainstScript='True']";
                        mod.Value = "<SafeControl Assembly='ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e' Namespace='ClubCloud.Common.Controls' TypeName='*' Safe='True' SafeAgainstScript='True' />";

                        //toDelete.Add(mod);
                    }

                }
                */
                /*
                foreach (SPWebApplication wap in SPWebService.ContentService.WebApplications)
                {
                    try
                    {

                        Console.WriteLine(wap.Name);
                        Console.WriteLine("==========================================================");
                        foreach (SPWebConfigModification mod in wap.WebConfigModifications)
                        {
                            string name = mod.Name;
                            string owner = mod.Owner;
                            string path = mod.Path;
                            Microsoft.SharePoint.Administration.SPWebConfigModification.SPWebConfigModificationType type = mod.Type;
                            string value = mod.Value;

                            Console.WriteLine(mod.ToString());
                            if (mod.Owner == "ClubCloudSaveControls" || mod.Owner == "ClubCloudCommonSaveControls" || mod.Owner == "ClubCloudCommonControls")
                            {
                                mod.Name = "SafeControl[@Assembly='ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e'][@Namespace='ClubCloud.Common.Controls'][@TypeName='*'][@Safe='True'][SafeAgainstScript='True']";
                                mod.Value = "<SafeControl Assembly='ClubCloud.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e' Namespace='ClubCloud.Common.Controls' TypeName='*' Safe='True' SafeAgainstScript='True' />";

                                //toDelete.Add(mod);
                            }
                        }

                        SPWebService.ContentService.WebApplications[wap.Id].Update();
                        SPWebService.ContentService.WebApplications[wap.Id].WebService.ApplyWebConfigModifications();


                        Console.WriteLine("==========================================================");

                    }
                    catch { }

                }
                */
                /*
                foreach (SPWebConfigModification mod in toDelete)
                {

                    webApp.WebConfigModifications.Remove(mod);
                    SPWebService.ContentService.WebApplications[webApp.Id].WebConfigModifications.Remove(mod);
                }
                */
                /*
                try
                {
                    webApp.Update();
                    SPWebService.ContentService.WebApplications[webApp.Id].Update();
                    SPWebService.ContentService.WebApplications[webApp.Id].WebService.ApplyWebConfigModifications();
                }
                catch { };
                */
            }
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
