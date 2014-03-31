using Microsoft.SharePoint.Administration;
using Microsoft.SharePoint.Administration.Claims;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Provider
{
    //result.Add(SPClaimEncodingManager.EncodeClaimIntoFormsSuffix("http://schemas.microsoft.com/ws/2008/06/identity/claims/groupsid", current4.Sid.Value, "http://www.w3.org/2001/XMLSchema#string", SPOriginalIssuers.Format(SPOriginalIssuerType.Windows)));
    public class ZimbraClaimProvider : Microsoft.SharePoint.Administration.Claims.SPClaimProvider 
    {
        public ZimbraClaimProvider(string displayName) : base(displayName)
        { 
        
        }

        protected override SPClaim CreateClaimForArguments(SPClaimArguments arguments)
        {
            return base.CreateClaimForArguments(arguments);
        }

        protected override void FillClaimsForEntity(Uri context, SPClaim entity, SPClaimProviderContext claimProviderContext, List<SPClaim> claims)
        {
            base.FillClaimsForEntity(context, entity, claimProviderContext, claims);
        }

        protected override void FillDefaultLocalizedDisplayName(System.Globalization.CultureInfo culture, out string localizedName)
        {
            base.FillDefaultLocalizedDisplayName(culture, out localizedName);
        }

        public override string GetClaimTypeForUserKey()
        {
            return base.GetClaimTypeForUserKey();
        }

        protected override SPClaim GetUserKeyForEntity(SPClaim entity)
        {
            return base.GetUserKeyForEntity(entity);
        }

        public override bool SupportsUserKey
        {
            get
            {
                return base.SupportsUserKey;
            }
        }

        public override bool SupportsUserSpecificHierarchy
        {
            get
            {
                return base.SupportsUserSpecificHierarchy;
            }
        }

        protected override void FillClaimTypes(List<string> claimTypes)
        {
            throw new NotImplementedException();
        }

        protected override void FillClaimValueTypes(List<string> claimValueTypes)
        {
            throw new NotImplementedException();
        }

        protected override void FillClaimsForEntity(Uri context, Microsoft.SharePoint.Administration.Claims.SPClaim entity, List<Microsoft.SharePoint.Administration.Claims.SPClaim> claims)
        {
            throw new NotImplementedException();
        }

        protected override void FillEntityTypes(List<string> entityTypes)
        {
            throw new NotImplementedException();
        }

        protected override void FillHierarchy(Uri context, string[] entityTypes, string hierarchyNodeID, int numberOfLevels, Microsoft.SharePoint.WebControls.SPProviderHierarchyTree hierarchy)
        {
            throw new NotImplementedException();
        }

        protected override void FillResolve(Uri context, string[] entityTypes, Microsoft.SharePoint.Administration.Claims.SPClaim resolveInput, List<Microsoft.SharePoint.WebControls.PickerEntity> resolved)
        {
            throw new NotImplementedException();
        }

        protected override void FillResolve(Uri context, string[] entityTypes, string resolveInput, List<Microsoft.SharePoint.WebControls.PickerEntity> resolved)
        {
            throw new NotImplementedException();
        }

        protected override void FillSchema(Microsoft.SharePoint.WebControls.SPProviderSchema schema)
        {
            throw new NotImplementedException();
        }

        protected override void FillSearch(Uri context, string[] entityTypes, string searchPattern, string hierarchyNodeID, int maxCount, Microsoft.SharePoint.WebControls.SPProviderHierarchyTree searchTree)
        {
            throw new NotImplementedException();
        }

        public override string Name
        {
            get { throw new NotImplementedException(); }
        }

        public override bool SupportsEntityInformation
        {
            get { throw new NotImplementedException(); }
        }

        public override bool SupportsHierarchy
        {
            get { throw new NotImplementedException(); }
        }

        public override bool SupportsResolve
        {
            get { throw new NotImplementedException(); }
        }

        public override bool SupportsSearch
        {
            get { throw new NotImplementedException(); }
        }

        #region ULS

        public static void LogToULS(string message, TraceSeverity traceSeverity, EventSeverity eventSeverity)
        {
            try
            {
                SPDiagnosticsCategory category = new SPDiagnosticsCategory("Zimbra Claim Provider", traceSeverity, eventSeverity);
                SPDiagnosticsService ds = SPDiagnosticsService.Local;
                ds.WriteTrace(0, category, traceSeverity, message);
            }
            catch
            {
            }
        }

        #endregion
    }
}
