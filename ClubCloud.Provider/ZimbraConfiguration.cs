using Microsoft.SharePoint.Utilities;
using Microsoft.Web.Administration;
using System;
using System.Linq;
using System.Reflection;
using System.Xml;

namespace ClubCloud.Provider
{
    internal class ZimbraConfiguration
    {
        private static ServerManager manager = new ServerManager();
        private static Site SPServices = manager.Sites["SharePoint Web Services"];
        private static Site SPAdminv4 = manager.Sites["SharePoint Central Administration v4"];

        internal static ApplicationPool WSAppPool = manager.ApplicationPools["SharePoint Web Services Root"];
        internal static ApplicationPool CAAppPool = manager.ApplicationPools["SharePoint Central Administration v4"];
        internal static ApplicationPool STSAppPool = manager.ApplicationPools["SecurityTokenServiceApplicationPool"];
        
        private static Configuration SPServicesConfiguration = SPServices.GetWebConfiguration();
        private static Configuration SPAdminv4Configuration = SPAdminv4.GetWebConfiguration();

        private static SectionGroup SPServicesZimbraSection = SPServicesConfiguration.RootSectionGroup.SectionGroups.SingleOrDefault(section => section.Name == "Zimbra");
        private static SectionGroup SPAdminv4ZimbraSection = SPAdminv4Configuration.RootSectionGroup.SectionGroups.SingleOrDefault(section => section.Name == "Zimbra");

        private static Microsoft.Web.Administration.Application rootServices = SPServices.Applications.SingleOrDefault(app => app.ApplicationPoolName == "SharePoint Web Services Root");
        private static Microsoft.Web.Administration.Application stsServices = SPServices.Applications.SingleOrDefault(app => app.ApplicationPoolName == "SecurityTokenServiceApplicationPool");
        private static Microsoft.Web.Administration.Application caServices = SPAdminv4.Applications.SingleOrDefault(app => app.ApplicationPoolName == "SharePoint Central Administration v4");

        internal static string rootServicesConfigPath = rootServices.VirtualDirectories.FirstOrDefault().PhysicalPath + @"\web.config";
        internal static string stsServicesConfigPath = stsServices.VirtualDirectories.FirstOrDefault().PhysicalPath + @"\web.config";
        internal static string caServicesConfigPath = caServices.VirtualDirectories.FirstOrDefault().PhysicalPath + @"\web.config";

        #region Zimbra Virtual Directory

        /*
        private static void CreateVirtualDirectories(string serverComment, SPProvisioningAssistant.VirtualDirectorySettings[] virtualDirectories, SPIisVirtualDirectory.AuthorizationFlags? additionalAuthorization)
        {
            if ((int)virtualDirectories.Length == 0)
            {
                return;
            }
            SPIisServerManager.CommitChanges((ServerManager manager) => {
                Configuration applicationHostConfiguration = manager.GetApplicationHostConfiguration();
                Site item = manager.Sites[serverComment];
                Application application = item.Applications["/"];
                string physicalPath = application.VirtualDirectories["/"].PhysicalPath;
                SPProvisioningAssistant.VirtualDirectorySettings[] virtualDirectorySettingsArray = virtualDirectories;
                for (int i = 0; i < (int)virtualDirectorySettingsArray.Length; i++)
                {
                    SPProvisioningAssistant.VirtualDirectorySettings virtualDirectorySetting = virtualDirectorySettingsArray[i];
                    string str = virtualDirectorySetting.GetPhysicalPath(physicalPath);
                    if (!(new DirectoryInfo(str)).Exists)
                    {
                        Directory.CreateDirectory(str);
                    }
                    Application applicationPoolName = item.Applications[virtualDirectorySetting.ApplicationPath];
                    if (applicationPoolName != null)
                    {
                        VirtualDirectory virtualDirectory = applicationPoolName.VirtualDirectories[virtualDirectorySetting.VirtualDirectoryPath];
                        if (virtualDirectory != null)
                        {
                            virtualDirectory.PhysicalPath = str;
                        }
                        else
                        {
                            ULS.SendTraceTag(959866485, ULSCat.msoulscat_WSS_Topology, ULSTraceLevel.Medium, "Creating the virtual directory {0} ({1}).", new object[] { virtualDirectorySetting.Url, str });
                            applicationPoolName.VirtualDirectories.Add(virtualDirectorySetting.VirtualDirectoryPath, str);
                        }
                    }
                    else
                    {
                        if (!string.Equals(virtualDirectorySetting.VirtualDirectoryPath, "/", StringComparison.OrdinalIgnoreCase))
                        {
                            throw new NotSupportedException();
                        }
                        ULS.SendTraceTag(959866488, ULSCat.msoulscat_WSS_Topology, ULSTraceLevel.Medium, "{0}", new object[] { "Creating a new application for the virtual directory." });
                        applicationPoolName = item.Applications.Add(virtualDirectorySetting.ApplicationPath, str);
                        if (!string.IsNullOrEmpty(virtualDirectorySetting.ApplicationPoolName))
                        {
                            applicationPoolName.ApplicationPoolName = virtualDirectorySetting.ApplicationPoolName;
                        }
                        else
                        {
                            applicationPoolName.ApplicationPoolName = application.ApplicationPoolName;
                        }
                    }
                    string location = virtualDirectorySetting.GetLocation(serverComment);
                    ULS.SendTraceTag(959866487, ULSCat.msoulscat_WSS_Topology, ULSTraceLevel.Medium, "Setting the virtual directory access flags to {0}.", new object[] { (int)virtualDirectorySetting.AccessFlags });
                    SPProvisioningAssistant.SetAccessPolicy(applicationHostConfiguration, location, virtualDirectorySetting.AccessFlags);
                    if (!virtualDirectorySetting.InheritParentAuthorizationFlags)
                    {
                        ULS.SendTraceTag(963864951, ULSCat.msoulscat_WSS_Topology, ULSTraceLevel.Medium, "{0}", new object[] { "Configuring the virtual directory to specific access." });
                        SPIisVirtualDirectory.AuthorizationFlags value = (SPIisVirtualDirectory.AuthorizationFlags)0;
                        if (additionalAuthorization.HasValue)
                        {
                            value = value | additionalAuthorization.Value;
                        }
                        SPProvisioningAssistant.SetAuthFlags(applicationHostConfiguration, location, value);
                    }
                    if (virtualDirectorySetting.AllowAnonymousAccess)
                    {
                        ULS.SendTraceTag(959866490, ULSCat.msoulscat_WSS_Topology, ULSTraceLevel.Medium, "{0}", new object[] { "Configuring the virtual directory to allow anonymous access." });
                        SPProvisioningAssistant.SetAuthentication(applicationHostConfiguration, location, "anonymousAuthentication", true);
                    }
                    ULS.SendTraceTag(959866672, ULSCat.msoulscat_WSS_Topology, ULSTraceLevel.Medium, "{0}", new object[] { "Configuring the virtual directory content expiration." });
                    ConfigurationElement childElement = applicationHostConfiguration.GetSection("system.webServer/staticContent", location).GetChildElement("clientCache");
                    childElement.SetAttributeValue("cacheControlMode", "UseMaxAge");
                    childElement.SetAttributeValue("cacheControlMaxAge", new TimeSpan(365, 0, 0, 0));
                }
                return true;
            });
        }
        */
        internal static void CreatevDir(string applicationPoolName, string vDirName, string vDirPath)
        {
            using (new SPMonitoredScope("Create Virtual Directory"))
            {
                try
                {

                    foreach (Site site in manager.Sites)
                    {
                        Microsoft.Web.Administration.Application siteServices = site.Applications.SingleOrDefault(app => app.ApplicationPoolName == applicationPoolName);

                        if (siteServices != null && siteServices.ApplicationPoolName == applicationPoolName)
                        {
                            try
                            {
                                VirtualDirectory login = siteServices.VirtualDirectories.Add(vDirName, vDirPath);
                            }
                            catch { }
                        }

                    }

                    manager.CommitChanges();
                }
                catch (Exception ex)
                {
                    ProviderLogging.LogError(ex);
                }
            }

            return;

        }

        internal static void RemovevDir(string applicationPoolName, string vDirName, string vDirPath)
        {
            using (new SPMonitoredScope("Remove Virtual Directory"))
            {
                try
                {
                    foreach (Site site in manager.Sites)
                    {
                        Microsoft.Web.Administration.Application siteServices = site.Applications.SingleOrDefault(app => app.ApplicationPoolName == applicationPoolName);

                        if (siteServices != null && siteServices.ApplicationPoolName == applicationPoolName)
                        {
                            try
                            {
                                VirtualDirectory login = siteServices.VirtualDirectories[vDirName];
                                if (login != null)
                                {
                                    siteServices.VirtualDirectories.Remove(login);
                                }
                            }
                            catch { }
                        }

                    }

                    manager.CommitChanges();
                }
                catch (Exception ex)
                {
                    ProviderLogging.LogError(ex);
                }
            }
            return;
        }

        #endregion

        #region Web.Config

        /// <summary>
        /// Loads web.config into reference XMLDocument from the given path.
        /// </summary>
        /// <param name="configFilePath"></param>
        /// <param name="webConfig"></param>
        internal static void GetWebConfig(string configFilePath, ref XmlDocument webConfig)
        {
            using (new SPMonitoredScope("Load WebConfig"))
            {
                try
                {

                    webConfig.Load(configFilePath);
                }
                catch (Exception ex)
                {
                    ProviderLogging.LogError(ex);
                }
            }
        }

        /// <summary>
        /// Creates a backup and saves the referenced XMLDocument to the given path 
        /// </summary>
        /// <param name="configFilePath"></param>
        /// <param name="webConfig"></param>
        internal static void SetWebConfig(string configFilePath, ref XmlDocument webConfig)
        {
            using (new SPMonitoredScope("Save WebConfig"))
            {
                try
                {
                    XmlDocument currentConfig = new XmlDocument();
                    currentConfig.Load(configFilePath);
                    currentConfig.Save(configFilePath.ToLower().Replace("web.config", "web_" + DateTime.Now.ToString("yyyy-MM-dd-hh-mm") + "_Zimbra.config"));
                    webConfig.Save(configFilePath);
                }
                catch (Exception ex)
                {
                    ProviderLogging.LogError(ex);
                }
            }
        }

        #endregion

        #region Zimbra Section

        internal static void AppendSectionGroupZimbra(ref XmlDocument webConfig, string[] properties = null)
        {
            using (new SPMonitoredScope("Append Group Zimbra"))
            {
                try
                {
                    string fullname = Assembly.GetExecutingAssembly().FullName;
                    fullname = fullname.Replace("ClubCloud.Provider", "ClubCloud.Zimbra");
                    XmlNode configuration = webConfig.SelectSingleNode("/configuration");

                    bool section = ContainsNode("name", "Zimbra", "/configuration/configSections", ref webConfig);

                    //Section
                    XmlNode configSections = webConfig.SelectSingleNode("/configuration/configSections");
                    if (configSections != null && !section)
                    {
                        XmlNode sectionGroup = webConfig.CreateNode(XmlNodeType.Element, "sectionGroup", "");
                        XmlAttribute nameAttribute = webConfig.CreateAttribute("name");
                        nameAttribute.Value = "Zimbra";
                        sectionGroup.Attributes.Append(nameAttribute);
                        sectionGroup.InnerXml = string.Format("<section name=\"Configuration\" type=\"ClubCloud.Zimbra.Service.ZimbraConfigurationHandler, {0} \" />", fullname);
                        configSections.AppendChild(sectionGroup);
                    }

                    bool exists = false;

                    foreach (XmlNode node in webConfig.ChildNodes)
                    {
                        if (node.Name == "Zimbra")
                        {
                            exists = true;
                            break;
                        }
                    }
                    if (!exists)
                    {
                        XmlNode ZimbraSection = webConfig.CreateNode(XmlNodeType.Element, "Zimbra", "");
                        string config = "<Configuration><Server Name=\"{0}\" ServerName=\"{1}\" UserName=\"{2}\" Password=\"{3}\" IsAdmin=\"{4}\" Encoded=\"{5}\" /><Binding MaxReceivedMessageSize=\"{6}\" /></Configuration>";

                        ZimbraSection.InnerXml = config;

                        if (properties != null)
                        {
                            string innerXML = string.Format(config, properties);
                            ZimbraSection.InnerXml = innerXML;
                        }

                        //ZimbraSection.InnerXml = "<Configuration><Server Name=\"ClubCloud\" ServerName=\"mail.clubcloud.nl\" UserName=\"admin@clubcloud.nl\" Password=\"rjm557308453!\" IsAdmin=\"true\" Encoded=\"false\" /><Binding MaxReceivedMessageSize=\"2147483647\" /></Configuration>";                
                        configuration.InsertAfter(ZimbraSection, configSections);
                    }
                }
                catch (Exception ex)
                {
                    ProviderLogging.LogError(ex);
                }
            }
        }

        internal static void RemoveSectionGroupZimbra(ref XmlDocument webConfig)
        {
            using (new SPMonitoredScope("Remove Group Zimbra"))
            {

                try
                {
                    XmlNode configSections = webConfig.SelectSingleNode("/configuration/configSections");
                    XmlNode sectionGroup = null;
                    if (configSections != null)
                    {
                        foreach (XmlNode node in configSections.ChildNodes)
                        {
                            if (node.Attributes["name"].Value == "Zimbra")
                            {
                                sectionGroup = node;
                                break;
                            }
                        }
                        if (sectionGroup != null)
                        {
                            configSections.RemoveChild(sectionGroup);
                        }
                    }

                    XmlNode configuration = webConfig.SelectSingleNode("/configuration");
                    XmlNode zimbraNode = null;
                    if (configuration != null)
                    {
                        foreach (XmlNode node in webConfig.ChildNodes)
                        {
                            if (node.Name == "Zimbra")
                            {
                                zimbraNode = node;
                                break;
                            }
                        }
                        if (zimbraNode != null)
                        {
                            webConfig.RemoveChild(zimbraNode);
                        }
                    }
                }
                catch (Exception ex)
                {
                    ProviderLogging.LogError(ex);
                }
            }
        }

        #endregion

        #region Zimbra Provider

        internal static void AppendProviderZimbra(ref XmlDocument webConfig)
        {
            using (new SPMonitoredScope("Append Provider Zimbra"))
            {

                try
                {
                    string fullname = Assembly.GetExecutingAssembly().FullName;

                    bool role = ContainsNode("key", "ZimbraRoleProvider", "/configuration/SharePoint/PeoplePickerWildcards", ref webConfig);
                    bool member = ContainsNode("key", "ZimbraMembershipProvider", "/configuration/SharePoint/PeoplePickerWildcards", ref webConfig);

                    XmlNode PeoplePickerWildcards = webConfig.SelectSingleNode("/configuration/SharePoint/PeoplePickerWildcards");

                    if (PeoplePickerWildcards != null)
                    {
                        if (!role)
                        {
                            //<add key="ZimbraMembershipProvider" value="%" />
                            XmlNode peopleRolenode = webConfig.CreateNode(XmlNodeType.Element, "add", "");
                            XmlAttribute peopleRolekeyAttribute = webConfig.CreateAttribute("key");
                            peopleRolekeyAttribute.Value = "ZimbraRoleProvider";
                            peopleRolenode.Attributes.Append(peopleRolekeyAttribute);
                            XmlAttribute peopleRoleValueAttribute = webConfig.CreateAttribute("value");
                            peopleRoleValueAttribute.Value = "";
                            peopleRolenode.Attributes.Append(peopleRoleValueAttribute);
                            PeoplePickerWildcards.AppendChild(peopleRolenode);
                        }
                        if (!member)
                        {
                            //<add key="ZimbraRoleProvider" value="%" />
                            XmlNode peopleMembernode = webConfig.CreateNode(XmlNodeType.Element, "add", "");
                            XmlAttribute peopleMemberkeyAttribute = webConfig.CreateAttribute("key");
                            peopleMemberkeyAttribute.Value = "ZimbraMembershipProvider";
                            peopleMembernode.Attributes.Append(peopleMemberkeyAttribute);
                            XmlAttribute peopleMemberValueAttribute = webConfig.CreateAttribute("value");
                            peopleMemberValueAttribute.Value = "";
                            peopleMembernode.Attributes.Append(peopleMemberValueAttribute);
                            PeoplePickerWildcards.AppendChild(peopleMembernode);
                        }
                    }

                    role = ContainsNode("name", "ZimbraRoleProvider", "/configuration/system.web/roleManager/providers", ref webConfig);

                    //<add name="ZimbraRoleProvider" type="ClubCloud.Provider.ZimbraRoleProvider, ClubCloud.Provider, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" />
                    XmlNode roleManager = webConfig.SelectSingleNode("/configuration/system.web/roleManager/providers");

                    if (roleManager != null && !role)
                    {
                        XmlNode rolenode = webConfig.CreateNode(XmlNodeType.Element, "add", "");
                        XmlAttribute roleNameAttribute = webConfig.CreateAttribute("name");
                        roleNameAttribute.Value = "ZimbraRoleProvider";
                        rolenode.Attributes.Append(roleNameAttribute);
                        XmlAttribute roleTypeAttribute = webConfig.CreateAttribute("type");
                        roleTypeAttribute.Value = string.Format("ClubCloud.Provider.ZimbraRoleProvider, {0} ", fullname);
                        rolenode.Attributes.Append(roleTypeAttribute);
                        roleManager.AppendChild(rolenode);
                    }

                    member = ContainsNode("name", "ZimbraMembershipProvider", "/configuration/system.web/membership/providers", ref webConfig);

                    //<add name="ZimbraMembershipProvider" type="ClubCloud.Provider.ZimbraMembershipProvider, ClubCloud.Provider, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" />
                    XmlNode membership = webConfig.SelectSingleNode("/configuration/system.web/membership/providers");
                    if (membership != null && !member)
                    {
                        XmlNode membernode = webConfig.CreateNode(XmlNodeType.Element, "add", "");
                        XmlAttribute memberNameAttribute = webConfig.CreateAttribute("name");
                        memberNameAttribute.Value = "ZimbraMembershipProvider";
                        membernode.Attributes.Append(memberNameAttribute);
                        XmlAttribute memberTypeAttribute = webConfig.CreateAttribute("type");
                        memberTypeAttribute.Value = string.Format("ClubCloud.Provider.ZimbraMembershipProvider, {0} ", fullname);
                        membernode.Attributes.Append(memberTypeAttribute);
                        membership.AppendChild(membernode);
                    }
                }
                catch (Exception ex)
                {
                    ProviderLogging.LogError(ex);
                }
            }
        }

        internal static void RemoveProviderZimbra(ref XmlDocument webConfig)
        {
            using (new SPMonitoredScope("Remove Provider Zimbra"))
            {

                try
                {
                    XmlNode PeoplePickerWildcards = webConfig.SelectSingleNode("/configuration/SharePoint/PeoplePickerWildcards");
                    XmlNode peopleRolenode = null;
                    XmlNode peopleMembernode = null;
                    if (PeoplePickerWildcards != null)
                    {
                        foreach (XmlNode node in PeoplePickerWildcards.ChildNodes)
                        {
                            if (node.Attributes["key"].Value == "ZimbraMembershipProvider")
                            {
                                peopleMembernode = node;
                            }

                            if (node.Attributes["key"].Value == "ZimbraRoleProvider")
                            {
                                peopleRolenode = node;
                            }

                        }
                    }

                    if (peopleMembernode != null)
                    {
                        PeoplePickerWildcards.RemoveChild(peopleMembernode);
                    }

                    if (peopleRolenode != null)
                    {
                        PeoplePickerWildcards.RemoveChild(peopleRolenode);
                    }

                    XmlNode rolenode = null;
                    XmlNode roleManager = webConfig.SelectSingleNode("/configuration/system.web/roleManager/providers");
                    if (roleManager != null)
                    {
                        foreach (XmlNode node in PeoplePickerWildcards.ChildNodes)
                        {
                            if (node.Attributes["name"].Value == "ZimbraRoleProvider")
                            {
                                rolenode = node;
                            }
                        }
                    }

                    if (rolenode != null)
                    {
                        roleManager.RemoveChild(rolenode);
                    }

                    XmlNode membernode = null;
                    XmlNode membership = webConfig.SelectSingleNode("/configuration/system.web/membership/providers");
                    if (membership != null)
                    {
                        foreach (XmlNode node in PeoplePickerWildcards.ChildNodes)
                        {
                            if (node.Attributes["name"].Value == "ZimbraMembershipProvider")
                            {
                                membernode = node;
                            }
                        }
                    }

                    if (membernode != null)
                    {
                        membership.RemoveChild(membernode);
                    }
                }
                catch (Exception ex)
                {
                    ProviderLogging.LogError(ex);
                }
            }
        }

        #endregion

        #region Zimbra Module

        internal static void AppendModuleZimbra(ref XmlDocument webConfig)
        {
            using (new SPMonitoredScope("Append Module Zimbra"))
            {

                try
                {
                    string fullname = Assembly.GetExecutingAssembly().FullName;
                    XmlNode configuration = webConfig.SelectSingleNode("/configuration");

                    bool module = ContainsNode("name", "ZimbraModule", "/configuration/system.web/httpModules", ref webConfig);
                    //<add name="ZimbraModule" type="ClubCloud.Provider.ZimbraModule, ClubCloud.Provider, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" />
                    XmlNode httpModules = webConfig.SelectSingleNode("/configuration/system.web/httpModules");
                    if (httpModules != null && !module)
                    {
                        XmlNode httpModulesZimbranode = webConfig.CreateNode(XmlNodeType.Element, "add", "");
                        XmlAttribute httpModulesNameAttribute = webConfig.CreateAttribute("name");
                        httpModulesNameAttribute.Value = "ZimbraModule";
                        httpModulesZimbranode.Attributes.Append(httpModulesNameAttribute);
                        XmlAttribute httpModulesTypeAttribute = webConfig.CreateAttribute("type");
                        httpModulesTypeAttribute.Value = string.Format("ClubCloud.Provider.ZimbraModule, {0} ", fullname); ;
                        httpModulesZimbranode.Attributes.Append(httpModulesTypeAttribute);
                        httpModules.AppendChild(httpModulesZimbranode);
                    }

                    module = ContainsNode("name", "ZimbraModule", "/configuration/system.webServer/modules", ref webConfig);
                    //<add name="ZimbraModule" type="ClubCloud.Provider.ZimbraModule, ClubCloud.Provider, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" />
                    XmlNode modules = webConfig.SelectSingleNode("/configuration/system.webServer/modules");
                    if (modules != null && !module)
                    {
                        XmlNode modulesZimbranode = webConfig.CreateNode(XmlNodeType.Element, "add", "");
                        XmlAttribute modulesNameAttribute = webConfig.CreateAttribute("name");
                        modulesNameAttribute.Value = "ZimbraModule";
                        modulesZimbranode.Attributes.Append(modulesNameAttribute);
                        XmlAttribute modulesTypeAttribute = webConfig.CreateAttribute("type");
                        modulesTypeAttribute.Value = string.Format("ClubCloud.Provider.ZimbraModule, {0} ", fullname); ;
                        modulesZimbranode.Attributes.Append(modulesTypeAttribute);
                        modules.AppendChild(modulesZimbranode);
                    }
                }
                catch (Exception ex)
                {
                    ProviderLogging.LogError(ex);
                }
            }
        }

        internal static void RemoveModuleZimbra(ref XmlDocument webConfig)
        {
            using (new SPMonitoredScope("Remove Module Zimbra"))
            {

                try
                {
                    XmlNode httpModulesZimbranode = null;
                    XmlNode httpModules = webConfig.SelectSingleNode("/configuration/system.web/httpModules");
                    if (httpModules != null)
                    {
                        foreach (XmlNode node in httpModules.ChildNodes)
                        {
                            if (node.Attributes["name"].Value == "ZimbraModule")
                            {
                                httpModulesZimbranode = node;
                            }
                        }
                    }

                    if (httpModulesZimbranode != null)
                    {
                        httpModules.RemoveChild(httpModulesZimbranode);
                    }

                    XmlNode modulesZimbranode = null;
                    XmlNode modules = webConfig.SelectSingleNode("/configuration/system.webServer/modules");
                    if (modules != null)
                    {
                        foreach (XmlNode node in modules.ChildNodes)
                        {
                            if (node.Attributes["name"].Value == "ZimbraModule")
                            {
                                modulesZimbranode = node;
                            }
                        }

                        if (modulesZimbranode != null)
                        {
                            modules.RemoveChild(modulesZimbranode);
                        }
                    }
                }
                catch (Exception ex)
                {
                    ProviderLogging.LogError(ex);
                }
            }
        }

        #endregion

        #region Zimbra Helper functions

        internal static bool ContainsNode(string Key, string Name, string path, ref XmlDocument webConfig)
        {
            XmlNode baseNode = webConfig.SelectSingleNode(path);
            if (baseNode != null)
            {
                foreach (XmlNode node in baseNode.ChildNodes)
                {
                    XmlAttribute attrib = node.Attributes[Key];
                    if (attrib != null)
                    {
                        if (attrib.Value == Name)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        #endregion

    }
}
