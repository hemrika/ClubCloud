using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.Web.Administration;
using System.Xml;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;
using Microsoft.SharePoint.Administration;
using Microsoft.SharePoint.Utilities;

namespace ClubCloud.Provider.Features.Zimbra_Provider
{
    /// <summary>
    /// This class handles events raised during feature activation, deactivation, installation, uninstallation, and upgrade.
    /// </summary>
    /// <remarks>
    /// The GUID attached to this class may be used during packaging and should not be modified.
    /// </remarks>

    [Guid("a8b6f155-a119-4ab5-9078-b5aa0bec0515")]
    public class Zimbra_ProviderEventReceiver : SPFeatureReceiver
    {
        SPFeaturePropertyCollection configurationproperties = null;

        public override void FeatureActivated(SPFeatureReceiverProperties properties)
        {
            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                configurationproperties = properties.Feature.Properties;
                if (properties.Feature.Parent.GetType() == typeof(SPWebApplication))
                {
                    SPWebApplication webApp = properties.Feature.Parent as SPWebApplication;

                    //SPSite site = webApp.Sites.Where(p => p.ServerRelativeUrl.Equals("/", StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
                    CreateVirtualDirectory(webApp);

                    SPWebApplication wap = SPWebService.ContentService.WebApplications[webApp.Id];

                    List<SPWebConfigModification> process = new List<SPWebConfigModification>();
                    process.AddRange(ZimbraWebConfigModification.Modifications);

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
            });
        }

        public override void FeatureDeactivating(SPFeatureReceiverProperties properties)
        {
            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                configurationproperties = properties.Feature.Properties;
                if (properties.Feature.Parent.GetType() == typeof(SPWebApplication))
                {
                    SPWebApplication webApp = properties.Feature.Parent as SPWebApplication;

                    //SPSite site = webApp.Sites.Where(p => p.ServerRelativeUrl.Equals("/", StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
                    RemoveVirtualDirectory(webApp);

                    SPWebApplication wap = SPWebService.ContentService.WebApplications[webApp.Id];

                    List<SPWebConfigModification> process = new List<SPWebConfigModification>();
                    process.AddRange(ZimbraWebConfigModification.Modifications);

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
                }
            });
        }

        public override void FeatureInstalled(SPFeatureReceiverProperties properties)
        {
            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                configurationproperties = properties.Feature.Properties;
                AppendConfigurationSecureTokenServices();
                AppendConfigurationRootWebServices();
                AppendConfigurationCentralAdministration();
            });
        }

        public override void FeatureUninstalling(SPFeatureReceiverProperties properties)
        {
            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                configurationproperties = properties.Feature.Properties;
                RemoveConfigurationSecureTokenServices();
                RemoveConfigurationRootWebServices();
                RemoveConfigurationCentralAdministration();
            });
        }

        public override void FeatureUpgrading(SPFeatureReceiverProperties properties, string upgradeActionName, System.Collections.Generic.IDictionary<string, string> parameters)
        {
            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                configurationproperties = properties.Feature.Properties;
                RemoveConfigurationSecureTokenServices();
                AppendConfigurationSecureTokenServices();

                RemoveConfigurationRootWebServices();
                AppendConfigurationRootWebServices();

                RemoveConfigurationCentralAdministration();
                AppendConfigurationCentralAdministration();
            });
        }

        #region Virtual Directory
        private void CreateVirtualDirectory(SPWebApplication webApp)
        {
            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                //TODO
                string vDirPath = SPUtility.GetVersionedGenericSetupPath(@"TEMPLATE\IDENTITYMODEL\ZIMBRA", 15);
                ZimbraConfiguration.CreatevDir(webApp.ApplicationPool.Name, "/_zimbra", vDirPath);
            });
        }

        private void RemoveVirtualDirectory(SPWebApplication webApp)
        {
            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                //TODO
                string vDirPath = SPUtility.GetVersionedGenericSetupPath(@"TEMPLATE\IDENTITYMODEL\ZIMBRA", 15);
                ZimbraConfiguration.RemovevDir(webApp.ApplicationPool.Name, "/_zimbra", vDirPath);
            });
        }

        #endregion

        #region Append Configuration

        private void AppendConfigurationCentralAdministration()
        {
            try
            {
                XmlDocument caConfig = new XmlDocument();
                ZimbraConfiguration.GetWebConfig(ZimbraConfiguration.caServicesConfigPath, ref caConfig);

                List<string> properties = new List<string>();
                foreach (SPFeatureProperty property in configurationproperties)
                {
                    properties.Add(property.Value);
                }

                ZimbraConfiguration.AppendSectionGroupZimbra(ref caConfig, properties.ToArray());
                //ZimbraConfiguration.AppendSectionGroupZimbra(ref caConfig);
                ZimbraConfiguration.AppendProviderZimbra(ref caConfig);
                ZimbraConfiguration.AppendModuleZimbra(ref caConfig);
                ZimbraConfiguration.SetWebConfig(ZimbraConfiguration.caServicesConfigPath, ref caConfig);
                caConfig = null;

                ZimbraConfiguration.CAAppPool.Recycle();

                //while (ZimbraConfiguration.SPAdminv4.State == ObjectState.Starting || ZimbraConfiguration.SPAdminv4.State == ObjectState.Stopping)
                //{
                //    System.Threading.Thread.Yield();
                //}

                //if (ZimbraConfiguration.SPAdminv4.State == ObjectState.Started)
                //{
                //    ZimbraConfiguration.SPAdminv4.Stop();
                //}


                //while (ZimbraConfiguration.SPAdminv4.State != ObjectState.Stopped || ZimbraConfiguration.SPAdminv4.State == ObjectState.Stopping)
                //{
                //    System.Threading.Thread.Yield();
                //}

                //if (ZimbraConfiguration.SPAdminv4.State == ObjectState.Stopped)
                //{
                //    ZimbraConfiguration.SPAdminv4.Start();
                //}
            }
            catch { }
        }

        private void AppendConfigurationRootWebServices()
        {
            try
            {
                XmlDocument wsConfig = new XmlDocument();
                ZimbraConfiguration.GetWebConfig(ZimbraConfiguration.rootServicesConfigPath, ref wsConfig);

                List<string> properties = new List<string>();
                foreach (SPFeatureProperty property in configurationproperties)
                {
                    properties.Add(property.Value);
                }

                ZimbraConfiguration.AppendSectionGroupZimbra(ref wsConfig, properties.ToArray());
                //ZimbraConfiguration.AppendSectionGroupZimbra(ref wsConfig,);
                ZimbraConfiguration.AppendProviderZimbra(ref wsConfig);
                //ZimbraConfiguration.AppendModuleZimbra(ref wsConfig);
                ZimbraConfiguration.SetWebConfig(ZimbraConfiguration.rootServicesConfigPath, ref wsConfig);
                wsConfig = null;

                ZimbraConfiguration.WSAppPool.Recycle();

                //while (ZimbraConfiguration.SPServices.State == ObjectState.Starting || ZimbraConfiguration.SPServices.State == ObjectState.Stopping)
                //{
                //    System.Threading.Thread.Yield();
                //}

                //if (ZimbraConfiguration.SPServices.State == ObjectState.Started)
                //{
                //    ZimbraConfiguration.SPServices.Stop();
                //}


                //while (ZimbraConfiguration.SPServices.State != ObjectState.Stopped || ZimbraConfiguration.SPServices.State == ObjectState.Stopping)
                //{
                //    System.Threading.Thread.Yield();
                //}

                //if (ZimbraConfiguration.SPServices.State == ObjectState.Stopped)
                //{
                //    ZimbraConfiguration.SPServices.Start();
                //}
            }
            catch { }
        }

        private void AppendConfigurationSecureTokenServices()
        {
            try
            {
                XmlDocument stsConfig = new XmlDocument();
                ZimbraConfiguration.GetWebConfig(ZimbraConfiguration.stsServicesConfigPath, ref stsConfig);
                //ZimbraConfiguration.AppendSectionGroupZimbra(ref stsConfig);
                ZimbraConfiguration.AppendProviderZimbra(ref stsConfig);
                //ZimbraConfiguration.AppendModuleZimbra(ref stsConfig);
                ZimbraConfiguration.SetWebConfig(ZimbraConfiguration.stsServicesConfigPath, ref stsConfig);
                stsConfig = null;

                ZimbraConfiguration.STSAppPool.Recycle();
            }
            catch { }
        }

        #endregion

        #region Remove Configuration

        private void RemoveConfigurationRootWebServices()
        {
            try
            {
                XmlDocument wsConfig = new XmlDocument();
                ZimbraConfiguration.GetWebConfig(ZimbraConfiguration.rootServicesConfigPath, ref wsConfig);
                ZimbraConfiguration.RemoveSectionGroupZimbra(ref wsConfig);
                ZimbraConfiguration.RemoveProviderZimbra(ref wsConfig);
                //ZimbraConfiguration.AppendModuleZimbra(ref wsConfig);
                ZimbraConfiguration.SetWebConfig(ZimbraConfiguration.rootServicesConfigPath, ref wsConfig);
                wsConfig = null;

                ZimbraConfiguration.WSAppPool.Recycle();

                //while (ZimbraConfiguration.SPServices.State == ObjectState.Starting || ZimbraConfiguration.SPServices.State == ObjectState.Stopping)
                //{
                //    System.Threading.Thread.Yield();
                //}

                //if (ZimbraConfiguration.SPServices.State == ObjectState.Started)
                //{
                //    ZimbraConfiguration.SPServices.Stop();
                //}


                //while (ZimbraConfiguration.SPServices.State != ObjectState.Stopped || ZimbraConfiguration.SPServices.State == ObjectState.Stopping)
                //{
                //    System.Threading.Thread.Yield();
                //}

                //if (ZimbraConfiguration.SPServices.State == ObjectState.Stopped)
                //{
                //    ZimbraConfiguration.SPServices.Start();
                //}
            }
            catch { }
        }

        private void RemoveConfigurationSecureTokenServices()
        {
            try
            {
                XmlDocument stsConfig = new XmlDocument();
                ZimbraConfiguration.GetWebConfig(ZimbraConfiguration.stsServicesConfigPath, ref stsConfig);
                ZimbraConfiguration.RemoveSectionGroupZimbra(ref stsConfig);
                ZimbraConfiguration.RemoveProviderZimbra(ref stsConfig);
                //ZimbraConfiguration.AppendModuleZimbra(ref stsConfig);
                ZimbraConfiguration.SetWebConfig(ZimbraConfiguration.stsServicesConfigPath, ref stsConfig);
                stsConfig = null;

                ZimbraConfiguration.STSAppPool.Recycle();
            }
            catch { }
        }

        private void RemoveConfigurationCentralAdministration()
        {
            try
            {
                XmlDocument caConfig = new XmlDocument();
                ZimbraConfiguration.GetWebConfig(ZimbraConfiguration.caServicesConfigPath, ref caConfig);
                ZimbraConfiguration.RemoveSectionGroupZimbra(ref caConfig);
                ZimbraConfiguration.RemoveProviderZimbra(ref caConfig);
                ZimbraConfiguration.RemoveModuleZimbra(ref caConfig);
                ZimbraConfiguration.SetWebConfig(ZimbraConfiguration.caServicesConfigPath, ref caConfig);
                caConfig = null;

                ZimbraConfiguration.CAAppPool.Recycle();

                //while (ZimbraConfiguration.SPAdminv4.State == ObjectState.Starting || ZimbraConfiguration.SPAdminv4.State == ObjectState.Stopping)
                //{
                //    System.Threading.Thread.Yield();
                //}

                //if (ZimbraConfiguration.SPAdminv4.State == ObjectState.Started)
                //{
                //    ZimbraConfiguration.SPAdminv4.Stop();
                //}


                //while (ZimbraConfiguration.SPAdminv4.State != ObjectState.Stopped || ZimbraConfiguration.SPAdminv4.State == ObjectState.Stopping)
                //{
                //    System.Threading.Thread.Yield();
                //}

                //if (ZimbraConfiguration.SPAdminv4.State == ObjectState.Stopped)
                //{
                //    ZimbraConfiguration.SPAdminv4.Start();
                //}
            }
            catch { }
        }

        #endregion

    }
}
