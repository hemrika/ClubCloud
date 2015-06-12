using Microsoft.SharePoint.Administration;
using Microsoft.SharePoint.Administration.Claims;
using Microsoft.SharePoint.IdentityModel.OAuth2;
using Microsoft.SharePoint.WebControls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Security;

namespace ClubCloud.Provider
{
    //result.Add(SPClaimEncodingManager.EncodeClaimIntoFormsSuffix("http://schemas.microsoft.com/ws/2008/06/identity/claims/groupsid", current4.Sid.Value, "http://www.w3.org/2001/XMLSchema#string", SPOriginalIssuers.Format(SPOriginalIssuerType.Windows)));
    [Guid("E504EC65-27B3-4281-BF74-60FB81DFA898")]
    public class ZimbraClaimProvider : Microsoft.SharePoint.Administration.Claims.SPClaimProvider
    {
        public ZimbraClaimProvider()
            : base(ZimbraDisplayName)
        {
            ServicePointManager.ServerCertificateValidationCallback += delegate { return true; };
        }

        public ZimbraClaimProvider(string displayName)
            : base(ZimbraDisplayName)
        {
            ServicePointManager.ServerCertificateValidationCallback += delegate { return true; };
        }

        internal static string ZimbraName = "ZimbraClaimProvider";
        internal static string ZimbraDisplayName = "Zimbra Claim Provider";
        internal static string ZimbraDescription = "Zimbra Claim Provider";

        public override bool SupportsEntityInformation
        {
            get { return true; }
        }

        public override bool SupportsHierarchy
        {
            get { return true; }
        }

        public override bool SupportsResolve
        {
            get { return true; }
        }

        public override bool SupportsSearch
        {
            get { return true; }
        }

        public override string Name
        {
            get { return ZimbraName; }
        }

        public string Description
        {
            get { return ZimbraDescription; }
        }

        private string m_providerName = "ZimbraMembershipProvider";

        public string ProviderName
        {
            get
            {
                return this.m_providerName;
            }
        }

        private MembershipProvider m_membershipProvider;
        public MembershipProvider Provider
        {
            get
            {
                if (this.m_membershipProvider == null)
                {
                    this.m_membershipProvider = Membership.Providers[this.ProviderName];
                }
                return this.m_membershipProvider;
            }
        }
        protected override SPClaim CreateClaimForArguments(SPClaimArguments arguments)
        {
            return base.CreateClaimForArguments(arguments);
        }

        protected override void FillClaimsForEntity(Uri context, SPClaim entity, SPClaimProviderContext claimProviderContext, List<SPClaim> claims)
        {
            //base.FillClaimsForEntity(context, entity, claimProviderContext, claims);
            string provider = entity.OriginalIssuer.ToLower();
            //if (entity.Value.Contains("zimbramembershipprovider") || entity.Value.Contains("zimbraroleprovider"))
            //if((entity.OriginalIssuer.Contains("ZimbraClaimProvider")) || (entity.Value.Contains("zimbramembershipprovider")) || (entity.Value.Contains("zimbraroleprovider")))
            //if (provider.Contains("zimbramembershipprovider") || provider.Contains("zimbraroleprovider") || provider.Contains("zimbraclaimprovider") || provider.Contains("securitytokenservice"))
            if (provider.Contains("zimbraclaimprovider") || (provider.Contains("securitytokenservice") && entity.Value.Contains("zimbraclaimprovider")))
            {
                //0#.f|zimbramembershipprovider|12073385
                string identifier = entity.Value.Split('|').Last();
                MembershipUser user;
                if (!string.IsNullOrWhiteSpace(identifier))
                {
                    user = Provider.GetUser(identifier, true);
                }
                else
                {
                    user = Provider.GetUser(entity.Value, true);
                }

                ZimbraMembershipUser zuser = null;
                if(user != null && user.GetType() == typeof(ZimbraMembershipUser))
                {
                     zuser = user as ZimbraMembershipUser;
                }

                if (zuser != null)
                {
                    Type tuser = zuser.GetType();
                    PropertyInfo[] properties= tuser.GetProperties();
                    IEnumerable<ZimbraClaim> zimbraClaims = ZimbraClaimsMapped.Claims.Where(x => x.ClaimTypeValue != null);

                    foreach (ZimbraClaim claim in zimbraClaims)
                    {
                        PropertyInfo propertyInfo = properties.SingleOrDefault(p => p.Name == claim.Name);
                        if (propertyInfo != null && propertyInfo.Name == claim.Name)
                        {
                            if (propertyInfo.PropertyType == typeof(string))
                            {
                                string value = propertyInfo.GetValue(zuser) as string;
                                if (!string.IsNullOrWhiteSpace(value))
                                {
                                    
                                    SPClaim spclaim = CreateClaim(claim.ClaimType, value, claim.ClaimTypeValue);
                                    if (!claims.Contains(spclaim))
                                    {
                                        claims.Add(spclaim);
                                    }
                                }
                            }
                            else
                            {
                                IList values = (IList)propertyInfo.GetValue(zuser);
                                if (values != null)
                                {
                                    foreach (string value in values)
                                    {
                                        if (!string.IsNullOrWhiteSpace(value))
                                        {
                                            SPClaim spclaim = CreateClaim(claim.ClaimType, value, claim.ClaimTypeValue);
                                            if (!claims.Contains(spclaim))
                                            {
                                                claims.Add(spclaim);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
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
                //return true;
                return base.SupportsUserKey;
            }
        }

        public override bool SupportsUserSpecificHierarchy
        {
            get
            {
                //return true;
                return base.SupportsUserSpecificHierarchy;
            }
        }

        protected override void FillClaimTypes(List<string> claimTypes)
        {
            if (claimTypes == null)
                throw new ArgumentNullException(Name + ":Invalid Claim Types");

            IEnumerable<ZimbraClaim> claims = ZimbraClaimsMapped.Claims.Where(x => x.ClaimType != null);

            foreach (ZimbraClaim claim in claims)
            {
                claimTypes.Add(claim.ClaimType);
            }
            //throw new NotImplementedException();
        }

        protected override void FillClaimValueTypes(List<string> claimValueTypes)
        {
            if (claimValueTypes == null)
                throw new ArgumentNullException(Name + ":Invalid Claim Value Types");

            IEnumerable<ZimbraClaim> claims = ZimbraClaimsMapped.Claims.Where(x => x.ClaimTypeValue != null);

            foreach (ZimbraClaim claim in claims)
            {
                claimValueTypes.Add(claim.ClaimTypeValue);
            }

            //throw new NotImplementedException();
        }

        protected override void FillClaimsForEntity(Uri context, Microsoft.SharePoint.Administration.Claims.SPClaim entity, List<Microsoft.SharePoint.Administration.Claims.SPClaim> claims)
        {
            string provider = entity.OriginalIssuer.ToLower();

            //if ((entity.OriginalIssuer.Contains("ZimbraClaimProvider")) || (entity.OriginalIssuer.Contains("ZimbraMembershipProvider")) || (entity.OriginalIssuer.Contains("ZimbraRoleProvider")))
            //if (provider.Contains("zimbramembershipprovider") || provider.Contains("zimbraroleprovider") || provider.Contains("zimbraclaimprovider"))
            if (provider.Contains("zimbraclaimprovider"))
            {
                string identifier = entity.Value.Split('|').Last();
                MembershipUser user;
                if (!string.IsNullOrWhiteSpace(identifier))
                {
                     user = Provider.GetUser(identifier, true);
                }
                else
                {
                    user = Provider.GetUser(entity.Value,true);
                }

                ZimbraMembershipUser zuser = null;
                if (user != null && user.GetType() == typeof(ZimbraMembershipUser))
                {
                    zuser = user as ZimbraMembershipUser;
                }

                if (zuser != null)
                {
                    Type tuser = zuser.GetType();
                    PropertyInfo[] properties = tuser.GetProperties();
                    IEnumerable<ZimbraClaim> zimbraClaims = ZimbraClaimsMapped.Claims.Where(x => x.ClaimTypeValue != null);

                    foreach (ZimbraClaim claim in zimbraClaims)
                    {
                        PropertyInfo propertyInfo = properties.SingleOrDefault(p => p.Name == claim.Name);
                        if (propertyInfo != null && propertyInfo.Name == claim.Name)
                        {
                            if (propertyInfo.PropertyType == typeof(string))
                            {
                                string value = propertyInfo.GetValue(zuser) as string;
                                if (!string.IsNullOrWhiteSpace(value))
                                {
                                    SPClaim spclaim = CreateClaim(claim.ClaimType, value, claim.ClaimTypeValue);
                                    if (!claims.Contains(spclaim))
                                    {
                                        claims.Add(spclaim);
                                    }
                                }
                            }
                            else
                            {
                                IList values = (IList)propertyInfo.GetValue(zuser);
                                if (values != null)
                                {
                                    foreach (string value in values)
                                    {
                                        if (!string.IsNullOrWhiteSpace(value))
                                        {
                                            SPClaim spclaim = CreateClaim(claim.ClaimType, value, claim.ClaimTypeValue);
                                            if (!claims.Contains(spclaim))
                                            {
                                                claims.Add(spclaim);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            //throw new NotImplementedException();
        }

        protected override void FillEntityTypes(List<string> entityTypes)
        {
            if (entityTypes == null)
                throw new ArgumentNullException(Name + ":Invalid Entity Types");

            IEnumerable<ZimbraClaim> claims = ZimbraClaimsMapped.Claims.Where(x => x.EntityType != null);

            foreach (ZimbraClaim claim in claims)
            {
                entityTypes.Add(claim.EntityType);
            }
        }

        protected override void FillHierarchy(Uri context, string[] entityTypes, string hierarchyNodeID, int numberOfLevels, Microsoft.SharePoint.WebControls.SPProviderHierarchyTree hierarchy)
        {
            hierarchy.AddChild(new Microsoft.SharePoint.WebControls.SPProviderHierarchyNode("ZimbraClaimProvider", "Users", "Users", true));
        }

        protected override void FillResolve(Uri context, string[] entityTypes, Microsoft.SharePoint.Administration.Claims.SPClaim resolveInput, List<Microsoft.SharePoint.WebControls.PickerEntity> resolved)
        {
            //PickerEntity[] baseResolved = base.Resolve(context, entityTypes, resolveInput);
            //List<SPClaim> claims = base.GetClaimsForEntity(context,resolveInput).ToList<SPClaim>();
            //FillClaimsForEntity(context, resolveInput, claims);
            string provider = resolveInput.OriginalIssuer.ToLower();
            //if (resolveInput.OriginalIssuer.Contains("zimbramembershipprovider") || resolveInput.OriginalIssuer.Contains("zimbraroleprovider") || resolveInput.OriginalIssuer.Contains("zimbraclaimprovider"))
            //if (provider.Contains("zimbramembershipprovider") || provider.Contains("zimbraroleprovider") || provider.Contains("zimbraclaimprovider"))
            if (provider.Contains("zimbraclaimprovider"))
            {
                if (resolved.Count == 0)// || resolved.Count == 1)
                {
                    string identifier = resolveInput.Value.Split('|').Last();
                    MembershipUser user;
                    if (!string.IsNullOrWhiteSpace(identifier))
                    {
                        user = Provider.GetUser(identifier, true);
                    }
                    else
                    {
                        user = Provider.GetUser(resolveInput.Value, true);
                    }

                    //MembershipUser user = Provider.GetUser(resolveInput.Value, true);
                    ZimbraMembershipUser zuser = null;
                    if (user != null && user.GetType() == typeof(ZimbraMembershipUser))
                    {
                        zuser = user as ZimbraMembershipUser;
                    }

                    if (zuser != null)
                    {
                        PickerEntity pe = CreatePickerEntity();
                        //pe.Claim = base.CreateClaim(SPClaimTypes.UserLogonName, zuser.uid, "http://www.w3.org/2001/XMLSchema#string");
                        pe.Claim = resolveInput;
                        pe.DisplayText = zuser.displayName;
                        pe.EntityType = SPClaimEntityTypes.User;
                        pe.IsResolved = true;
                        pe.EntityData[PeopleEditorEntityDataKeys.DisplayName] = zuser.displayName;
                        pe.EntityData[PeopleEditorEntityDataKeys.Email] = zuser.Email;
                        pe.EntityData[PeopleEditorEntityDataKeys.SIPAddress] = zuser.Email;
                        pe.EntityData[PeopleEditorEntityDataKeys.UserId] = zuser.uid;
                        pe.EntityData[PeopleEditorEntityDataKeys.AccountName] = zuser.uid;
                        //pe.ProviderName = resolveInput.OriginalIssuer;
                        //pe.Description = resolveInput.OriginalIssuer + ":" + zuser.displayName;
                        List<SPClaim> claims = base.GetClaimsForEntity(context, pe.Claim).ToList<SPClaim>();
                        resolved.Add(pe);

                    }
                }
                //FillResolve(context, entityTypes, resolveInput.Value, resolved);
                //throw new NotImplementedException();
            }
        }

        protected override void FillResolve(Uri context, string[] entityTypes, string resolveInput, List<Microsoft.SharePoint.WebControls.PickerEntity> resolved)
        {
            if (resolved.Count == 0)// || resolved.Count == 1)
            {
                if (resolveInput.Contains("zimbraclaimprovider"))
                {
                    string identifier = resolveInput.Split('|').Last();
                    MembershipUser user;
                    if (!string.IsNullOrWhiteSpace(identifier))
                    {
                        user = Provider.GetUser(identifier, false);
                    }
                    else
                    {
                        user = Provider.GetUser(resolveInput, false);
                    }

                    ZimbraMembershipUser zuser = null;
                    if (user != null && user.GetType() == typeof(ZimbraMembershipUser))
                    {
                        zuser = user as ZimbraMembershipUser;
                    }

                    if (zuser != null)
                    {
                        PickerEntity pe = CreatePickerEntity();
                        pe.Claim = base.CreateClaim(SPClaimTypes.UserLogonName, zuser.uid, "http://www.w3.org/2001/XMLSchema#string");
                        pe.DisplayText = zuser.displayName;
                        pe.EntityType = SPClaimEntityTypes.User;
                        pe.IsResolved = true;
                        pe.EntityData[PeopleEditorEntityDataKeys.DisplayName] = zuser.displayName;
                        pe.EntityData[PeopleEditorEntityDataKeys.Email] = zuser.Email;
                        pe.EntityData[PeopleEditorEntityDataKeys.SIPAddress] = zuser.Email;
                        pe.EntityData[PeopleEditorEntityDataKeys.UserId] = zuser.uid;
                        pe.EntityData[PeopleEditorEntityDataKeys.AccountName] = zuser.uid;
                        resolved.Add(pe);

                        List<SPClaim> claims = base.GetClaimsForEntity(context, pe.Claim).ToList<SPClaim>();
                        //FillClaimsForEntity(context, pe.Claim, claims);
                    }
                }
            }
            //MembershipUser user = Provider.GetUser(resolveInput, true);
            //ZimbraMembershipUser zuser = null;
            /*
            if (user != null && user.GetType() == typeof(ZimbraMembershipUser))
            {
                zuser = user as ZimbraMembershipUser;
            }
            */
            //if (zuser != null)
            //{
                /*
                PickerEntity pe = CreatePickerEntity();
                pe.Claim = new SPClaim(SPClaimTypes.UserLogonName, zuser.uid, "http://www.w3.org/2001/XMLSchema#string", "Forms:ZimbraMembershipProvider");
                //pe.ProviderName = Provider.Name;
                //pe.Description = Provider.Description;
                pe.DisplayText = zuser.displayName;
                pe.EntityType = SPClaimEntityTypes.User;
                pe.IsResolved = true;
                //pe.EntityGroupName = "Leden";
                pe.EntityData[PeopleEditorEntityDataKeys.DisplayName] = zuser.displayName;
                pe.EntityData[PeopleEditorEntityDataKeys.Email] = zuser.Email;
                pe.EntityData[PeopleEditorEntityDataKeys.UserId] = zuser.uid;
                pe.EntityData[PeopleEditorEntityDataKeys.AccountName] = zuser.uid;
                resolved.Add(pe);
                */
                /*
                Type tuser = zuser.GetType();
                PropertyInfo[] properties = tuser.GetProperties();
                IEnumerable<ZimbraClaim> zimbraClaims = ZimbraClaimsMapped.Claims.Where(x => x.ClaimTypeValue != null);

                foreach (ZimbraClaim claim in zimbraClaims)
                {
                    PropertyInfo propertyInfo = properties.SingleOrDefault(p => p.Name == claim.Name);
                    if (propertyInfo != null && propertyInfo.Name == claim.Name)
                    {
                        if (propertyInfo.PropertyType == typeof(string))
                        {
                            string value = propertyInfo.GetValue(zuser) as string;
                            SPClaim spclaim = CreateClaim(claim.ClaimType, value, claim.ClaimTypeValue);
                            claims.Add(spclaim);
                        }
                        else
                        {
                            IList values = (IList)propertyInfo.GetValue(zuser);
                            if (values != null)
                            {
                                foreach (string value in values)
                                {
                                    SPClaim spclaim = CreateClaim(claim.ClaimType, value, claim.ClaimTypeValue);
                                    claims.Add(spclaim);
                                }
                            }
                        }
                    }
                }
                */
            //} 
            //throw new NotImplementedException();
        }

        protected override void FillSchema(Microsoft.SharePoint.WebControls.SPProviderSchema schema)
        {
            if (schema == null)
                throw new ArgumentNullException(Name + ":Invalid Schema Provider");

            IEnumerable<ZimbraClaim> claims = ZimbraClaimsMapped.Claims.Where(x => x.EntityDataKey != null);

            foreach (ZimbraClaim claim in claims)
            {
                schema.AddSchemaElement(new SPSchemaElement(claim.EntityDataKey, claim.Name, SPSchemaElementType.Both));
            }

            /*
            schema.AddSchemaElement(new SPSchemaElement(PeopleEditorEntityDataKeys.AccountName, "Account Naam", SPSchemaElementType.Both));
            schema.AddSchemaElement(new SPSchemaElement(PeopleEditorEntityDataKeys.Department, "Group Naam", SPSchemaElementType.Both));
            schema.AddSchemaElement(new SPSchemaElement(PeopleEditorEntityDataKeys.DisplayName, "Display Naam", SPSchemaElementType.Both));
            schema.AddSchemaElement(new SPSchemaElement(PeopleEditorEntityDataKeys.Email, "Email", SPSchemaElementType.Both));
            schema.AddSchemaElement(new SPSchemaElement(PeopleEditorEntityDataKeys.Email, "Email Alias", SPSchemaElementType.Both));
            schema.AddSchemaElement(new SPSchemaElement(PeopleEditorEntityDataKeys.MobilePhone, "Mobiel", SPSchemaElementType.Both));
            schema.AddSchemaElement(new SPSchemaElement(PeopleEditorEntityDataKeys.PrincipalType, "zimbraId", SPSchemaElementType.Both));
            schema.AddSchemaElement(new SPSchemaElement(PeopleEditorEntityDataKeys.SharePointGroupId, "Group", SPSchemaElementType.Both));
            schema.AddSchemaElement(new SPSchemaElement(PeopleEditorEntityDataKeys.UserId, "uid", SPSchemaElementType.Both));
            schema.AddSchemaElement(new SPSchemaElement(PeopleEditorEntityDataKeys.WorkPhone, "Telefoon", SPSchemaElementType.Both));
            */
        }

        protected override void FillSearch(Uri context, string[] entityTypes, string searchPattern, string hierarchyNodeID, int maxCount, Microsoft.SharePoint.WebControls.SPProviderHierarchyTree searchTree)
        {
            //SPProviderHierarchyNode matchNode = null;
            //throw new NotImplementedException();
        }



        /*
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
        */
    }
}
