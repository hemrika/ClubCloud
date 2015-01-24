using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration.Claims;

namespace ClubCloud.Provider.Features.Zimbra_Claims
{
    /// <summary>
    /// This class handles events raised during feature activation, deactivation, installation, uninstallation, and upgrade.
    /// </summary>
    /// <remarks>
    /// The GUID attached to this class may be used during packaging and should not be modified.
    /// </remarks>

    [Guid("8f25e656-ca61-4c69-b7c5-aaa6e58a8877")]
    public class Zimbra_ClaimsEventReceiver : SPClaimProviderFeatureReceiver
    {
        public override string ClaimProviderDisplayName
        {
            get { return ZimbraClaimProvider.ZimbraDisplayName; }
        }

        public override string ClaimProviderDescription
        {
            get { return ZimbraClaimProvider.ZimbraDescription; }
        }

        public override string ClaimProviderAssembly
        {
            get { return this.GetType().Assembly.FullName; }
        }

        public override string ClaimProviderType
        {
            get { return typeof(ZimbraClaimProvider).FullName; }
        }

        public override bool ClaimProviderEnabled
        {
            get
            {
                return base.ClaimProviderEnabled;
            }
        }

        public override bool ClaimProviderUsedByDefault
        {
            get
            {
                return base.ClaimProviderUsedByDefault;
            }
        }

        public override void FeatureActivated(SPFeatureReceiverProperties properties)
        {
            try
            {
                base.FeatureActivated(properties);
            }
            catch { }

        }

        public override void FeatureDeactivating(SPFeatureReceiverProperties properties)
        {

            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                base.RemoveClaimProvider(ZimbraClaimProvider.ZimbraName);

            });
            base.FeatureDeactivating(properties);
        }

        public override void FeatureInstalled(SPFeatureReceiverProperties properties)
        {
            base.FeatureInstalled(properties);
        }

        public override void FeatureUninstalling(SPFeatureReceiverProperties properties)
        {
            base.FeatureUninstalling(properties);
        }

        public override void FeatureUpgrading(SPFeatureReceiverProperties properties, string upgradeActionName, System.Collections.Generic.IDictionary<string, string> parameters)
        {
            base.FeatureUpgrading(properties, upgradeActionName, parameters);
        }
    }
}
