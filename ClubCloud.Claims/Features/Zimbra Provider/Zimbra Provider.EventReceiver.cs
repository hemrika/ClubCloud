using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.Web.Administration;
using System.Xml;

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

        public override void FeatureActivated(SPFeatureReceiverProperties properties)
        {
            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
            });
        }

        public override void FeatureDeactivating(SPFeatureReceiverProperties properties)
        {
            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
            });
        }

        public override void FeatureInstalled(SPFeatureReceiverProperties properties)
        {
            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                AppendConfigurationCentralAdministration();
                AppendConfigurationSecureTokenServices();
                AppendConfigurationRootWebServices();
            });
        }

        public override void FeatureUninstalling(SPFeatureReceiverProperties properties)
        {
            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                RemoveConfigurationCentralAdministration();
                RemoveConfigurationSecureTokenServices();
                RemoveConfigurationRootWebServices();
            });
        }

        public override void FeatureUpgrading(SPFeatureReceiverProperties properties, string upgradeActionName, System.Collections.Generic.IDictionary<string, string> parameters)
        {
            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                RemoveConfigurationCentralAdministration();
                AppendConfigurationCentralAdministration();

                RemoveConfigurationSecureTokenServices();
                AppendConfigurationSecureTokenServices();

                RemoveConfigurationRootWebServices();
                AppendConfigurationRootWebServices();
            });
        }

        private void AppendConfigurationCentralAdministration()
        {
            XmlDocument caConfig = new XmlDocument();
            ZimbraConfiguration.GetWebConfig(ZimbraConfiguration.caServicesConfigPath, ref caConfig);
            ZimbraConfiguration.AppendSectionGroupZimbra(ref caConfig);
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

        private void AppendConfigurationRootWebServices()
        {
            XmlDocument wsConfig = new XmlDocument();
            ZimbraConfiguration.GetWebConfig(ZimbraConfiguration.rootServicesConfigPath, ref wsConfig);
            ZimbraConfiguration.AppendSectionGroupZimbra(ref wsConfig);
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

        private void AppendConfigurationSecureTokenServices()
        {
            XmlDocument stsConfig = new XmlDocument();
            ZimbraConfiguration.GetWebConfig(ZimbraConfiguration.stsServicesConfigPath, ref stsConfig);
            ZimbraConfiguration.AppendSectionGroupZimbra(ref stsConfig);
            ZimbraConfiguration.AppendProviderZimbra(ref stsConfig);
            //ZimbraConfiguration.AppendModuleZimbra(ref stsConfig);
            ZimbraConfiguration.SetWebConfig(ZimbraConfiguration.stsServicesConfigPath, ref stsConfig);
            stsConfig = null;

            ZimbraConfiguration.STSAppPool.Recycle();
        }

        private void RemoveConfigurationRootWebServices()
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

        private void RemoveConfigurationSecureTokenServices()
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

        private void RemoveConfigurationCentralAdministration()
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

    }
}
