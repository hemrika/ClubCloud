using Microsoft.SharePoint.Administration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.SignalR
{
    internal class SignalR
    {
        #region Modifications

        private static List<SPWebConfigModification> _modifications;
        private static string _owner = "SignalR";

        public static string Owner
        {
            get { return SignalR._owner; }
            set { SignalR._owner = value; }
        }

        public static List<SPWebConfigModification> Modifications
        {
            get {
                _modifications = new List<SPWebConfigModification>();

                AddSignalRHandler();
                AddRuntimeAssemblyBinding();
                AddOwinAppSettings();

                return _modifications; 
            }
        }


        private static void AddSignalRHandler()
        {
            var configModSyncfusionPageCompressionHandlerWeb = new SPWebConfigModification
            {
                //<add name="SignalR" type="ClubCloud.SignalR.SignalRModule, ClubCloud.SignalR, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e" />
                Name = "add[@name='SignalR'][type='ClubCloud.SignalR.SignalRModule, ClubCloud.SignalR, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e']",
                Owner = Owner,
                Sequence = 0,
                Path = "configuration/system.web/httpModules",
                Type = SPWebConfigModification.SPWebConfigModificationType.EnsureChildNode,
                Value = "<add name='SignalR' type='ClubCloud.SignalR.SignalRModule, ClubCloud.SignalR, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e' />"

            };
            _modifications.Add(configModSyncfusionPageCompressionHandlerWeb);

            var configModSyncfusionPageCompressionHandlerwebServer = new SPWebConfigModification
            {
                Name = "add[@name='SignalR'][type='ClubCloud.SignalR.SignalRModule, ClubCloud.SignalR, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e']",
                Owner = Owner,
                Sequence = 0,
                Path = "configuration/system.webServer/modules",
                Type = SPWebConfigModification.SPWebConfigModificationType.EnsureChildNode,
                Value = "<add name='SignalR' type='ClubCloud.SignalR.SignalRModule, ClubCloud.SignalR, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e' />"

            };
            _modifications.Add(configModSyncfusionPageCompressionHandlerwebServer);
        }

        private static void AddRuntimeAssemblyBinding()
        {
            /*
            <runtime>

                <assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1">
            */
            /*
                  <dependentAssembly>

                    <assemblyIdentity name="Microsoft.AspNet.SignalR.Core" publicKeyToken="31bf3856ad364e35" culture="neutral" />

                    <bindingRedirect oldVersion="0.0.0.0-2.2.0.0" newVersion="2.2.0.0" />

                  </dependentAssembly>
            */
            /*
            var configModMicrosoftAspNetSignalRCore = new SPWebConfigModification
            {
                Name = "add[@name='SignalR'][type='ClubCloud.SignalR.SignalRModule, ClubCloud.SignalR, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e']",
                Owner = Owner,
                Sequence = 0,
                Path = "configuration/runtime/assemblyBinding",
                Type = SPWebConfigModification.SPWebConfigModificationType.EnsureSection,
                Value = "<add name='SignalR' type='ClubCloud.SignalR.SignalRModule, ClubCloud.SignalR, Version=1.0.0.0, Culture=neutral, PublicKeyToken=144fd205e283172e' />"

            };
            _modifications.Add(configModMicrosoftAspNetSignalRCore);
            */
            /*
                  <dependentAssembly>

                    <assemblyIdentity name="Microsoft.Owin" publicKeyToken="31bf3856ad364e35" culture="neutral" />

                    <bindingRedirect oldVersion="0.0.0.0-3.0.0.0" newVersion="3.0.0.0" />

                  </dependentAssembly>
            */
            /*
                  <dependentAssembly>

                    <assemblyIdentity name="System.Web.Cors" publicKeyToken="31bf3856ad364e35" culture="neutral" />

                    <bindingRedirect oldVersion="0.0.0.0-5.2.2.0" newVersion="5.2.2.0" />

                  </dependentAssembly>
            */
            /*
                  <dependentAssembly>

                    <assemblyIdentity name="Microsoft.Owin.Security" publicKeyToken="31bf3856ad364e35" culture="neutral" />

                    <bindingRedirect oldVersion="0.0.0.0-3.0.0.0" newVersion="3.0.0.0" />

                  </dependentAssembly>
            */
            /*
                  <dependentAssembly>

                    <assemblyIdentity name="Microsoft.ServiceBus" publicKeyToken="31bf3856ad364e35" culture="neutral" />

                    <bindingRedirect oldVersion="0.0.0.0-2.5.0.0" newVersion="2.5.0.0" />

                  </dependentAssembly>
            */
            /*
                  <dependentAssembly>

                    <assemblyIdentity name="Microsoft.Owin.Security.OAuth" publicKeyToken="31bf3856ad364e35" culture="neutral" />

                    <bindingRedirect oldVersion="0.0.0.0-3.0.0.0" newVersion="3.0.0.0" />

                  </dependentAssembly>
            */
            /*
                  <dependentAssembly>

                    <assemblyIdentity name="Microsoft.Owin.Security.Cookies" publicKeyToken="31bf3856ad364e35" culture="neutral" />

                    <bindingRedirect oldVersion="0.0.0.0-3.0.0.0" newVersion="3.0.0.0" />

                  </dependentAssembly>
            */
            /*
                </assemblyBinding>

              </runtime>
             */
        }

        private static void AddOwinAppSettings()
        {
            var configModappSettings = new SPWebConfigModification
            {
                Name = "appSettings",
                Owner = Owner,
                Sequence = 0,
                Path = "configuration/runtime",
                Type = SPWebConfigModification.SPWebConfigModificationType.EnsureSection,
                Value = "<appSettings></appSettings>"

            };
            _modifications.Add(configModappSettings);

            var configModowinAppStartup = new SPWebConfigModification
            {
                Name = "add[@key='owin:AppStartup'][value='ClubCloud.SignalR.Startup, ClubCloud.SignalR']",
                Owner = Owner,
                Sequence = 1,
                Path = "configuration/runtime/appSettings",
                Type = SPWebConfigModification.SPWebConfigModificationType.EnsureSection,
                Value = "<add key='owin:AppStartup' type='ClubCloud.SignalR.Startup, ClubCloud.SignalR' />"

            };
            _modifications.Add(configModappSettings);

            var configModowinAutomaticAppStartup = new SPWebConfigModification
            {
                Name = "add[@key='owin:AutomaticAppStartup'][value='true']",
                Owner = Owner,
                Sequence = 2,
                Path = "configuration/runtime/appSettings",
                Type = SPWebConfigModification.SPWebConfigModificationType.EnsureSection,
                Value = "<add key='owin:AutomaticAppStartup' type='true' />"

            };
            _modifications.Add(configModowinAutomaticAppStartup);

            /*
            <runtime> 
            <appSettings>
              <add key="owin:AppStartup" value="ClubCloud.SignalR.Startup, ClubCloud.SignalR" />
              <add key="owin:AutomaticAppStartup" value="true" />
              <add key="webpages:Enabled" value="false" />
            </appSettings>
            <!-- End Owin Binding -->
          </runtime>
          */
        }
        #endregion
    }
}
