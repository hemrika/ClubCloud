using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;
using System.Collections.Generic;
using System.Diagnostics;

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
            ClubCloud.Common.RemoteAdministrator.Enable();
             
            FeatureCleaning(properties);
            SetCustomPages(properties);

            if (properties.Feature.Parent.GetType() == typeof(SPWebApplication))
            {
                webApp = properties.Feature.Parent as SPWebApplication;
                SPWebApplication wap = SPWebService.ContentService.WebApplications[webApp.Id];

                List<SPWebConfigModification> process = new List<SPWebConfigModification>();
                process.AddRange(ClubCloud.Common.Common.Modifications);
                //process.AddRange(Syncfusion.Modifications);
                process.AddRange(Ajax.Modifications);
                //process.AddRange(CrossSiteScripting.Modifications);

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
                    wap.Update(false);
                    SPWebService.ContentService.WebApplications[wap.Id].Update(false);
                    SPWebService.ContentService.WebApplications[wap.Id].WebService.ApplyWebConfigModifications();
                    //webApp.Farm.Services.GetValue<SPWebService>().ApplyWebConfigModifications();
                    wap.WebConfigModifications.Clear();
                    wap.Update(false);
                }
                catch { };
            }

        }


        public override void FeatureDeactivating(SPFeatureReceiverProperties properties)
        {
            ClubCloud.Common.RemoteAdministrator.Enable();
            
            //FeatureCleaning(properties);
            
            if (properties.Feature.Parent.GetType() == typeof(SPWebApplication))
            {
                webApp = properties.Feature.Parent as SPWebApplication;
                SPWebApplication wap = SPWebService.ContentService.WebApplications[webApp.Id];
                
                List<SPWebConfigModification> process = new List<SPWebConfigModification>();
                process.AddRange(ClubCloud.Common.Common.Modifications);
                process.AddRange(Syncfusion.Modifications);
                process.AddRange(Ajax.Modifications);
                //process.AddRange(CrossSiteScripting.Modifications);

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
                    wap.Update(false);
                    SPWebService.ContentService.WebApplications[wap.Id].Update(false);
                    SPWebService.ContentService.WebApplications[wap.Id].WebService.ApplyWebConfigModifications();
                    //webApp.Farm.Services.GetValue<SPWebService>().ApplyWebConfigModifications();
                    wap.WebConfigModifications.Clear();
                    wap.Update();
                }
                catch { };
                

                //FeatureUninstalling(properties);
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
                    List<SPWebConfigModification> toDelete = new List<SPWebConfigModification>();
                    try
                    {
                        Debug.Write(wap.Name);
                        //Console.WriteLine(wap.Name);
                        //Console.WriteLine("==========================================================");
                        foreach (SPWebConfigModification mod in wap.WebConfigModifications)
                        {
                            string name = mod.Name;
                            string owner = mod.Owner;
                            string path = mod.Path;
                            Microsoft.SharePoint.Administration.SPWebConfigModification.SPWebConfigModificationType type = mod.Type;
                            string value = mod.Value;

                            //Console.WriteLine(mod.ToString());
                            Debug.Write(mod.ToString());
                            if (mod.Owner.Contains("ClubCloud") || mod.Owner.Contains("Syncfusion") || mod.Owner.Contains("ajax") || mod.Owner.Contains("Ajax")) // == "ClubCloudCommonSaveControls" || mod.Owner == "ClubCloudCommonControls")
                            {
                                toDelete.Add(mod);
                            }
                        }

                        foreach (SPWebConfigModification mod in toDelete)
                        {
                                wap.WebConfigModifications.Remove(mod);
                                SPWebService.ContentService.WebApplications[wap.Id].WebConfigModifications.Remove(mod);
                        }

                        SPWebService.ContentService.WebApplications[wap.Id].Update();
                        SPWebService.ContentService.WebApplications[wap.Id].WebService.ApplyWebConfigModifications();


                        Console.WriteLine("==========================================================");

                    }
                    catch(Exception ex)
                    {
                        Debug.Write(ex.ToString());
                    }

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

        public override void FeatureInstalled(SPFeatureReceiverProperties properties)
        {
            SPWebService.AdministrationService.ApplyApplicationContentToLocalServer();
        }

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
                        if (mod.Owner.Contains("ClubCloud"))
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
                finally { toDelete = new List<SPWebConfigModification>(); }
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
                        if (mod.Owner.Contains("ClubCloud"))
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
                    wap.WebConfigModifications.Clear();
                    wap.Update();
                }
                catch { found = true; }
                finally { toDelete = new List<SPWebConfigModification>(); }

                if(found)
                {
                    FeatureUninstalling(properties);
                }
            }
        }

        private void SetCustomPages(SPFeatureReceiverProperties properties)
        {
            if (properties.Feature.Parent.GetType() == typeof(SPWebApplication))
            {
                webApp = properties.Feature.Parent as SPWebApplication;
                SPWebApplication wap = SPWebService.ContentService.WebApplications[webApp.Id];


                try
                {
                    wap.UpdateMappedPage(SPWebApplication.SPCustomPage.AccessDenied, 15, "/_layouts/ClubCloud/Common/403.aspx");
                    //webApp.UpdateMappedPage(SPWebApplication.SPCustomPage.Confirmation, "");
                    wap.UpdateMappedPage(SPWebApplication.SPCustomPage.Error, 15, "/_layouts/ClubCloud/Common/500.aspx");
                    wap.UpdateMappedPage(SPWebApplication.SPCustomPage.None, 15, "/_layouts/ClubCloud/Common/404.aspx");
                    //webApp.UpdateMappedPage(SPWebApplication.SPCustomPage.RequestAccess, "");
                    //webApp.UpdateMappedPage(SPWebApplication.SPCustomPage.Signout, "");
                    wap.UpdateMappedPage(SPWebApplication.SPCustomPage.WebDeleted, 15, "/_layouts/ClubCloud/Common/404.aspx");
                    wap.Update(false);
                    SPWebService.ContentService.WebApplications[wap.Id].Update(false);
                }
                catch { }
            }
        }
    }
}
