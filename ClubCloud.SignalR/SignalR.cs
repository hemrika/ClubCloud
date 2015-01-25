using Microsoft.SharePoint.Administration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Common
{
    internal class SignalR
    {
        #region Modifications

        private static List<SPWebConfigModification> _modifications;

        public static List<SPWebConfigModification> Modifications
        {
            get {
                _modifications = new List<SPWebConfigModification>();

                AddajaxToolkit();
                AddAssemblies();
                AddSaveControls();

                return _modifications; 
            }
        }


        private static void AddSignalRHandler()
        {
            var configModSyncfusionPageCompressionHandlerWeb = new SPWebConfigModification
            {
                //<add name="SignalR" type="ClubCloud.SignalR.SignalRModule, ClubCloud.SignalR, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" />
                Name = "add[@name='HttpCompressModule'][type='Syncfusion.Web.UI.WebControls.Handler.PageCompressHandler, Syncfusion.Shared.Web, Version=12.4450.0.24, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89']",
                Owner = "ClubCloud",
                Sequence = 0,
                Path = "configuration/system.web/httpModules",
                Type = SPWebConfigModification.SPWebConfigModificationType.EnsureChildNode,
                Value = "<add name='HttpCompressModule' type='Syncfusion.Web.UI.WebControls.Handler.PageCompressHandler, Syncfusion.Shared.Web, Version=12.4450.0.24, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89' />"

            };
            _modifications.Add(configModSyncfusionPageCompressionHandlerWeb);

            var configModSyncfusionPageCompressionHandlerwebServer = new SPWebConfigModification
            {
                Name = "add[@name='HttpCompressModule'][type='Syncfusion.Web.UI.WebControls.Handler.PageCompressHandler, Syncfusion.Shared.Web, Version=12.4450.0.24, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89']",
                Owner = "ClubCloud",
                Sequence = 0,
                Path = "configuration/system.webServer/modules",
                Type = SPWebConfigModification.SPWebConfigModificationType.EnsureChildNode,
                Value = "<add name='HttpCompressModule' type='Syncfusion.Web.UI.WebControls.Handler.PageCompressHandler,Syncfusion.Shared.Web, Version=12.4450.0.24, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89' />"

            };
            _modifications.Add(configModSyncfusionPageCompressionHandlerwebServer);
        }

        private static void AddajaxToolkit()
        {
            var configModajaxToolkit = new SPWebConfigModification
            {
                Name = "add[@tagPrefix='ajaxToolkit'][assembly='AjaxControlToolkit, Version=4.5.7.1213, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e'][namespace='AjaxControlToolkit']",
                //Name = "add[@tagPrefix=\"ajaxToolkit\" assembly=\"AjaxControlToolkit, Version=4.5.7.1213, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e\" namespace=\"AjaxControlToolkit\"]",
                //Name = "ajaxToolkit",
                Owner = "ClubCloud",
                Sequence = 0,
                Path = "configuration/system.web/pages/controls",
                Type = SPWebConfigModification.SPWebConfigModificationType.EnsureChildNode,
                Value = "<add tagPrefix='ajaxToolkit' assembly='AjaxControlToolkit, Version=4.5.7.1213, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e' namespace='AjaxControlToolkit' />"

            };
            _modifications.Add(configModajaxToolkit);

        }

        private static void AddAssemblies()
        {
            var configModAjaxControlToolkit = new SPWebConfigModification
            {
                //<add assembly="ClubCloud.SignalR, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" />
                Name = "add[@Assembly='AjaxControlToolkit, Version=4.5.7.1213, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e']",
                //Name = "add[@assembly=\"AjaxControlToolkit, Version=4.5.7.1213, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e\"]",
                //Name = "AjaxControlToolkit",
                Owner = "ClubCloud",
                Sequence = 0,
                Path = "configuration/system.web/compilation/assemblies",
                Type = SPWebConfigModification.SPWebConfigModificationType.EnsureChildNode,
                Value = "<add assembly='AjaxControlToolkit, Version=4.5.7.1213, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e' />"

            };
            _modifications.Add(configModAjaxControlToolkit);
        }

        private static void AddSaveControls()
        {
            var configModAjaxControlToolkit = new SPWebConfigModification
            {
                Name = "SafeControl[@Assembly='AjaxControlToolkit, Version=4.5.7.1213, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e'][@Namespace='AjaxControlToolkit'][@TypeName='*'][@Safe='True'][SafeAgainstScript='True']",
                Owner = "ClubCloud",
                Sequence = 0,
                Path = "configuration/SharePoint/SafeControls",
                Type = SPWebConfigModification.SPWebConfigModificationType.EnsureChildNode,
                Value = "<SafeControl Assembly='AjaxControlToolkit, Version=4.5.7.1213, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e' Namespace='AjaxControlToolkit' TypeName='*' Safe='True' SafeAgainstScript='True' />"

            };
            _modifications.Add(configModAjaxControlToolkit);

            var configModAjaxMin = new SPWebConfigModification
            {
                Name = "SafeControl[@Assembly='AjaxMin, Version=4.97.4951.28478, Culture=neutral, PublicKeyToken=21ef50ce11b5d80f'][@Namespace='Microsoft.Ajax.Utilities'][@TypeName='*'][@Safe='True'][SafeAgainstScript='True']",
                Owner = "ClubCloud",
                Sequence = 0,
                Path = "configuration/SharePoint/SafeControls",
                Type = SPWebConfigModification.SPWebConfigModificationType.EnsureChildNode,
                Value = "<SafeControl Assembly='AjaxMin, Version=4.97.4951.28478, Culture=neutral, PublicKeyToken=21ef50ce11b5d80f' Namespace='Microsoft.Ajax.Utilities' TypeName='*' Safe='True' SafeAgainstScript='True' />"

            };
            _modifications.Add(configModAjaxMin);

            var configModHtmlAgilityPack = new SPWebConfigModification
            {
                Name = "SafeControl[@Assembly='HtmlAgilityPack, Version=1.4.6.0, Culture=neutral, PublicKeyToken=bd319b19eaf3b43a'][@Namespace='HtmlAgilityPack'][@TypeName='*'][@Safe='True'][SafeAgainstScript='True']",
                Owner = "ClubCloud",
                Sequence = 0,
                Path = "configuration/SharePoint/SafeControls",
                Type = SPWebConfigModification.SPWebConfigModificationType.EnsureChildNode,
                Value = "<SafeControl Assembly='HtmlAgilityPack, Version=1.4.6.0, Culture=neutral, PublicKeyToken=bd319b19eaf3b43a' Namespace='HtmlAgilityPack' TypeName='*' Safe='True' SafeAgainstScript='True' />"

            };
            _modifications.Add(configModHtmlAgilityPack);
            
        }

        private static void AddRuntimeAssemblyBinding()
        {
            /*
            <runtime>

                <assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1">

                  <dependentAssembly>

                    <assemblyIdentity name="Microsoft.AspNet.SignalR.Core" publicKeyToken="31bf3856ad364e35" culture="neutral" />

                    <bindingRedirect oldVersion="0.0.0.0-2.2.0.0" newVersion="2.2.0.0" />

                  </dependentAssembly>

                  <dependentAssembly>

                    <assemblyIdentity name="Microsoft.Owin" publicKeyToken="31bf3856ad364e35" culture="neutral" />

                    <bindingRedirect oldVersion="0.0.0.0-3.0.0.0" newVersion="3.0.0.0" />

                  </dependentAssembly>

                  <dependentAssembly>

                    <assemblyIdentity name="System.Web.Cors" publicKeyToken="31bf3856ad364e35" culture="neutral" />

                    <bindingRedirect oldVersion="0.0.0.0-5.2.2.0" newVersion="5.2.2.0" />

                  </dependentAssembly>

                  <dependentAssembly>

                    <assemblyIdentity name="Microsoft.Owin.Security" publicKeyToken="31bf3856ad364e35" culture="neutral" />

                    <bindingRedirect oldVersion="0.0.0.0-3.0.0.0" newVersion="3.0.0.0" />

                  </dependentAssembly>

                  <dependentAssembly>

                    <assemblyIdentity name="Microsoft.ServiceBus" publicKeyToken="31bf3856ad364e35" culture="neutral" />

                    <bindingRedirect oldVersion="0.0.0.0-2.5.0.0" newVersion="2.5.0.0" />

                  </dependentAssembly>

                  <dependentAssembly>

                    <assemblyIdentity name="Microsoft.Owin.Security.OAuth" publicKeyToken="31bf3856ad364e35" culture="neutral" />

                    <bindingRedirect oldVersion="0.0.0.0-3.0.0.0" newVersion="3.0.0.0" />

                  </dependentAssembly>

                  <dependentAssembly>

                    <assemblyIdentity name="Microsoft.Owin.Security.Cookies" publicKeyToken="31bf3856ad364e35" culture="neutral" />

                    <bindingRedirect oldVersion="0.0.0.0-3.0.0.0" newVersion="3.0.0.0" />

                  </dependentAssembly>

                </assemblyBinding>

              </runtime>
             */
        }

        private static void AddOwinAppSettings()
        {
            /*
    <appSettings>
      <add key="owin:AppStartup" value="ClubCloud.SignalR.Startup, ClubCloud.SignalR" />
      <add key="owin:AutomaticAppStartup" value="true" />
      <add key="webpages:Enabled" value="false" />
      <add key="aspnet:FormsAuthReturnUrlVar" value="../profiel.aspx" />
    </appSettings>

            */
        }
        #endregion
    }
}
