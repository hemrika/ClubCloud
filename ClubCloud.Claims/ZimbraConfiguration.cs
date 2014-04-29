using Microsoft.Web.Administration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ClubCloud.Provider
{
    class ZimbraConfiguration
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

        internal static void CreatevDir(string applicationPoolName, string vDirName, string vDirPath)
        {
            //Site site = null;
            try
            {
                foreach (Site site in manager.Sites)
                {

                    Microsoft.Web.Administration.Application siteServices = site.Applications.SingleOrDefault(app => app.ApplicationPoolName == applicationPoolName);

                    if (siteServices != null && siteServices.ApplicationPoolName == applicationPoolName)
                    {
                        try
                        {
                            VirtualDirectory login = siteServices.VirtualDirectories["_login"];
                            
                            VirtualDirectory vDir = login as VirtualDirectory;
                            vDir.PhysicalPath = vDirPath;
                            vDir.Path = vDirName;
                            if (!siteServices.VirtualDirectories.Contains(vDir))
                            {
                                siteServices.VirtualDirectories.Add(vDir);
                            }
                        }
                        catch (Exception)
                        {

                            throw;
                        }

                    }
                }
            }
            catch { return; }
        }

        internal static void GetWebConfig(string configFilePath, ref XmlDocument webConfig)
        {
            //var webConfig = new XmlDocument();
            webConfig.Load(configFilePath);
            //webConfig.Save(configFilePath.ToLower().Replace("web.config", "web_" + DateTime.Now.ToString("yyyy-MM-dd-hh-mm") + "_Zimbra.config"));
            //return webConfig;
        }

        internal static void SetWebConfig(string configFilePath, ref XmlDocument webConfig)
        {
            XmlDocument currentConfig = new XmlDocument();
            currentConfig.Load(configFilePath);
            currentConfig.Save(configFilePath.ToLower().Replace("web.config", "web_" + DateTime.Now.ToString("yyyy-MM-dd-hh-mm") + "_Zimbra.config"));

            webConfig.Save(configFilePath);
            //return webConfig;
        }

        internal static void AppendSectionGroupZimbra(ref XmlDocument webConfig)
        {
            string fullname = Assembly.GetExecutingAssembly().FullName;
            XmlNode configuration = webConfig.SelectSingleNode("/configuration");

            //Section
            XmlNode configSections = webConfig.SelectSingleNode("/configuration/configSections");
            if (configSections != null)
            {
                XmlNode sectionGroup = webConfig.CreateNode(XmlNodeType.Element, "sectionGroup", "");
                XmlAttribute nameAttribute = webConfig.CreateAttribute("name");
                nameAttribute.Value = "Zimbra";
                sectionGroup.Attributes.Append(nameAttribute);
                sectionGroup.InnerXml = string.Format("<section name=\"Configuration\" type=\"ClubCloud.Zimbra.Service.ZimbraConfigurationHandler, {0} \" />", fullname);
                configSections.AppendChild(sectionGroup);
            }

            XmlNode ZimbraSection = webConfig.CreateNode(XmlNodeType.Element, "Zimbra", "");
            ZimbraSection.InnerXml = "<Configuration><Server Name=\"ClubCloud\" ServerName=\"mail.clubcloud.nl\" UserName=\"admin@clubcloud.nl\" Password=\"rjm557308453!\" IsAdmin=\"true\" Encoded=\"false\" /><Binding MaxReceivedMessageSize=\"2147483647\" /></Configuration>";
            configuration.InsertAfter(ZimbraSection, configSections);
        }

        internal static void RemoveSectionGroupZimbra(ref XmlDocument webConfig)
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
                foreach (XmlNode node in configuration.ChildNodes)
                {
                    if (node.Name == "Zimbra")
                    {
                        zimbraNode = node;
                        break;
                    }
                }
                if (zimbraNode != null)
                {
                    configuration.RemoveChild(zimbraNode);
                }
            }
        }

        internal static void AppendProviderZimbra(ref XmlDocument webConfig)
        {
            string fullname = Assembly.GetExecutingAssembly().FullName;

            XmlNode PeoplePickerWildcards = webConfig.SelectSingleNode("/configuration/SharePoint/PeoplePickerWildcards");

            if (PeoplePickerWildcards != null)
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

            //<add name="ZimbraRoleProvider" type="ClubCloud.Provider.ZimbraRoleProvider, ClubCloud.Provider, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" />
            XmlNode roleManager = webConfig.SelectSingleNode("/configuration/system.web/roleManager/providers");
            if (roleManager != null)
            {
                XmlNode rolenode = webConfig.CreateNode(XmlNodeType.Element, "add", "");
                XmlAttribute roleNameAttribute = webConfig.CreateAttribute("name");
                roleNameAttribute.Value = "ZimbraRoleProvider";
                rolenode.Attributes.Append(roleNameAttribute);
                XmlAttribute roleTypeAttribute = webConfig.CreateAttribute("type");
                roleTypeAttribute.Value = string.Format("ClubCloud.Provider.ZimbraRoleProvider, {0} \" />", fullname);
                rolenode.Attributes.Append(roleTypeAttribute);
                roleManager.AppendChild(rolenode);
            }

            //<add name="ZimbraMembershipProvider" type="ClubCloud.Provider.ZimbraMembershipProvider, ClubCloud.Provider, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" />
            XmlNode membership = webConfig.SelectSingleNode("/configuration/system.web/membership/providers");
            if (membership != null)
            {
                XmlNode membernode = webConfig.CreateNode(XmlNodeType.Element, "add", "");
                XmlAttribute memberNameAttribute = webConfig.CreateAttribute("name");
                memberNameAttribute.Value = "ZimbraMembershipProvider";
                membernode.Attributes.Append(memberNameAttribute);
                XmlAttribute memberTypeAttribute = webConfig.CreateAttribute("type");
                memberTypeAttribute.Value = string.Format("ClubCloud.Provider.ZimbraMembershipProvider, {0} \" />", fullname);
                membernode.Attributes.Append(memberTypeAttribute);
                membership.AppendChild(membernode);
            }
        }

        internal static void RemoveProviderZimbra(ref XmlDocument webConfig)
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

            if(peopleMembernode != null)
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

            if(rolenode != null)
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

        internal static void AppendModuleZimbra(ref XmlDocument webConfig)
        {
            string fullname = Assembly.GetExecutingAssembly().FullName;
            XmlNode configuration = webConfig.SelectSingleNode("/configuration");

            //<add name="ZimbraModule" type="ClubCloud.Provider.ZimbraModule, ClubCloud.Provider, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" />
            XmlNode httpModules = webConfig.SelectSingleNode("/configuration/system.web/httpModules");
            if (httpModules != null)
            {
                XmlNode httpModulesZimbranode = webConfig.CreateNode(XmlNodeType.Element, "add", "");
                XmlAttribute httpModulesNameAttribute = webConfig.CreateAttribute("name");
                httpModulesNameAttribute.Value = "ZimbraModule";
                httpModulesZimbranode.Attributes.Append(httpModulesNameAttribute);
                XmlAttribute httpModulesTypeAttribute = webConfig.CreateAttribute("type");
                httpModulesTypeAttribute.Value = string.Format("ClubCloud.Provider.ZimbraModule, {0} \" />", fullname); ;
                httpModulesZimbranode.Attributes.Append(httpModulesTypeAttribute);
                httpModules.AppendChild(httpModulesZimbranode);
            }

            //<add name="ZimbraModule" type="ClubCloud.Provider.ZimbraModule, ClubCloud.Provider, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" />
            XmlNode modules = webConfig.SelectSingleNode("/configuration/system.webServer/modules");
            if (modules != null)
            {
                XmlNode modulesZimbranode = webConfig.CreateNode(XmlNodeType.Element, "add", "");
                XmlAttribute modulesNameAttribute = webConfig.CreateAttribute("name");
                modulesNameAttribute.Value = "ZimbraModule";
                modulesZimbranode.Attributes.Append(modulesNameAttribute);
                XmlAttribute modulesTypeAttribute = webConfig.CreateAttribute("type");
                modulesTypeAttribute.Value = string.Format("ClubCloud.Provider.ZimbraModule, {0} \" />", fullname); ;
                modulesZimbranode.Attributes.Append(modulesTypeAttribute);
                modules.AppendChild(modulesZimbranode);
            }
        }

        internal static void RemoveModuleZimbra(ref XmlDocument webConfig)
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
    }
}
