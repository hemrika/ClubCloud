using Microsoft.SharePoint.Administration.Claims;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.LDAP
{
    [Microsoft.SharePoint.Security.SharePointPermission(System.Security.Permissions.SecurityAction.Demand, ObjectModel = true)]
    class ZimbraClaimProviderFeatureReceiver : SPClaimProviderFeatureReceiver
    {
        public override string ClaimProviderAssembly
        {
            get
            {
                return typeof(ZimbraClaimProvider).Assembly.FullName;
            }
        }

        public override string ClaimProviderDescription
        {
            get
            {
                return "This feature adds SampleNameId claim type in the SAML token created by the STS.";
            }
        }

        public override string ClaimProviderDisplayName
        {
            get { return "Sample NameId Claim Provider"; }
        }

        public override string ClaimProviderType
        {
            get { return typeof(ZimbraClaimProvider).FullName; }
        }

        public override void FeatureActivated(Microsoft.SharePoint.SPFeatureReceiverProperties properties)
        {
            {
                ExecBaseFeatureActivated(properties);
            }
        }

        private void ExecBaseFeatureActivated(Microsoft.SharePoint.SPFeatureReceiverProperties properties)
        {
            base.FeatureActivated(properties);
        }

    }
}
