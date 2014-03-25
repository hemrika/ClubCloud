using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;
using Microsoft.SharePoint.Administration.Claims;
using Microsoft.SharePoint.Utilities;
using Microsoft.SharePoint.WebControls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.DirectoryServices;
using System.Linq;

namespace ClubCloud.Zimbra.LDAP
{
    /// </summary>
    public class ZimbraClaimProvider : SPClaimProvider
    {
        public ZimbraClaimProvider(string displayName) : base(displayName)
        {
        }

        protected override void FillClaimTypes(List<string> claimTypes)
        {
            throw new NotImplementedException();
        }

        protected override void FillClaimValueTypes(List<string> claimValueTypes)
        {
            throw new NotImplementedException();
        }

        protected override void FillClaimsForEntity(Uri context, SPClaim entity, List<SPClaim> claims)
        {
            throw new NotImplementedException();
        }

        protected override void FillEntityTypes(List<string> entityTypes)
        {
            throw new NotImplementedException();
        }

        protected override void FillHierarchy(Uri context, string[] entityTypes, string hierarchyNodeID, int numberOfLevels, SPProviderHierarchyTree hierarchy)
        {
            throw new NotImplementedException();
        }

        protected override void FillResolve(Uri context, string[] entityTypes, SPClaim resolveInput, List<PickerEntity> resolved)
        {
            throw new NotImplementedException();
        }

        protected override void FillResolve(Uri context, string[] entityTypes, string resolveInput, List<PickerEntity> resolved)
        {
            throw new NotImplementedException();
        }

        protected override void FillSchema(SPProviderSchema schema)
        {
            throw new NotImplementedException();
        }

        protected override void FillSearch(Uri context, string[] entityTypes, string searchPattern, string hierarchyNodeID, int maxCount, SPProviderHierarchyTree searchTree)
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

        /*
        public const string _ProviderDisplayName = "Zimbra Claims Provider";
        public virtual string ProviderDisplayName
        {
            get { return "Zimbra Claims Provider"; }
        }
        public const string _ProviderInternalName = "Zimbra Claims Provider";
        public virtual string ProviderInternalName
        {
            get { return "Zimbra Claims Provider"; }
        }

        public static string LDAPCPUlsCategory = "Zimbra Claims Provider";

        private string _LDAPConnectionString;
        private string _LDAPUserName;
        private string _LDAPPassword;
        private bool _LDAPUseSharePointDomain;
        private bool _LDAPUseServerBind;

        protected virtual string LDAPObjectClassName
        {
            get { return "objectclass"; }
        }

        protected virtual string LDAPFilter
        {
            get { return "(&(" + LDAPObjectClassName + "={2}) ({0}={1}){3})"; }
        }

        protected virtual string PickerEntityDisplayText
        {
            get { return "({0}) {1}"; }
        }

        protected virtual string PickerEntityOnMouseOver
        {
            //get { return "[{0}] {1}={2}"; }
            get { return "{0}={1}"; }
        }

        protected string PickerEntityGroupName
        {
            get { return _PickerEntityGroupName; }
            set { _PickerEntityGroupName = value; }
        }
        private string _PickerEntityGroupName;

        public bool FilterEnabledUsersOnly
        {
            get { return _FilterEnabledUsersOnly; }
            set { _FilterEnabledUsersOnly = value; }
        }
        private bool _FilterEnabledUsersOnly;

        protected virtual string EnabledUsersOnlyLDAPFilter
        {
            get { return "(&(!(userAccountControl:1.2.840.113556.1.4.803:=2))"; }
        }

        public bool FilterSecurityGroupsOnly
        {
            get { return _FilterSecurityGroupsOnly; }
            set { _FilterSecurityGroupsOnly = value; }
        }
        private bool _FilterSecurityGroupsOnly;

        protected virtual string FilterSecurityGroupsOnlyLDAPFilter
        {
            get { return "(groupType:1.2.840.113556.1.4.803:=2147483648)"; }
        }

        /// <summary>
        /// Set whether 2 values with same claim type but different case (for ex. "value" and "VAlue") should be considered as identical
        /// SharePoint itself seems to ignore case because FillResolve with SPClaim parameter seems to always receive input in lowercase
        /// </summary>
        protected bool IgnoreCaseToDetectDuplicatesValues
        {
            get { return _IgnoreCaseToDetectDuplicatesValues; }
            set { _IgnoreCaseToDetectDuplicatesValues = value; }
        }
        private bool _IgnoreCaseToDetectDuplicatesValues;

        /// <summary>
        /// For identity claim only: set to true to display the value that actually matched the user input
        /// </summary>
        protected bool DisplayLdapMatchForIdentityClaimType
        {
            get { return _DisplayLdapMatchForIdentityClaimType; }
            set { _DisplayLdapMatchForIdentityClaimType = value; }
        }
        private bool _DisplayLdapMatchForIdentityClaimType;

        /// <summary>
        /// Set to true to always resolve user input against each claim type
        /// </summary>
        protected bool AlwaysResolveValue
        {
            get { return _AlwaysResolveValue; }
            set { _AlwaysResolveValue = value; }
        }
        private bool _AlwaysResolveValue;

        /// <summary>
        /// false bu default, setting to true is NOT RECOMMENDED to maintain optimal performance considerations on LDAP server
        /// </summary>
        protected bool AddWildcardInFrontOfQuery
        {
            get { return _AddWildcardInFrontOfQuery; }
            set { _AddWildcardInFrontOfQuery = value; }
        }
        private bool _AddWildcardInFrontOfQuery;

        /// <summary>
        /// List of attributes with thei claim type associated.
        /// LDAPCP will only search against attributes in this list.
        /// </summary>
        protected IEnumerable<ZimbraAttribute> AttributesDefinitionList
        {
            get { return _AttributesDefinitionList; }
        }
        private IEnumerable<ZimbraAttribute> _AttributesDefinitionList;

        /// <summary>
        /// List of attributes actually defined in the trust
        /// + list of LDAP attributes that are always queried, even if not defined in the trust (typically the displayName)
        /// </summary>
        protected IEnumerable<ZimbraAttribute> AttributesToQuery
        {
            get { return _AttributesToQuery; }
        }
        private IEnumerable<ZimbraAttribute> _AttributesToQuery;

        /// <summary>
        /// Contains the attribute mapped to the identity claim in the SPTrustedLoginProvider
        /// </summary>
        protected ZimbraAttribute IdentityAttribute;

        /// <summary>
        /// Contains the results of the LDAP query
        /// </summary>
        protected SearchResult[] LDAPSearchResults;

        protected ZimbraConsolidatedResultCollection ConsolidatedResults;

        /// <summary>
        /// Contains attributes that are not used in the filter (both claimType AND ResolveAsIdentityClaim are not set), but have peopleEditorEntityDataKey set
        /// </summary>
        protected IEnumerable<ZimbraAttribute> MetadataAttributes;

        /// <summary>
        /// Name of the SPTrustedLoginProvider associated with the claim provider
        /// </summary>
        protected SPTrustedLoginProvider AssociatedSPTrustedLoginProvider;
        
        protected ZimbraConfig zimbraConfig;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="displayName"></param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ZimbraClaimProvider(string displayName)
            : base(displayName)
        {
            zimbraConfig = ZimbraConfig.GetDefaultSettings(new ZimbraConfig());
            ZimbraClaimProvider.LogToULS(
                String.Format("[{0}] Constructor called", ProviderInternalName),
                TraceSeverity.Verbose,
                EventSeverity.Information);

            Initialize();
        }
        
        /// <summary>
        /// Initializes claim provider. This method is reserved for internal use and is not intended to be called from external code or changed
        /// </summary>
        protected void Initialize()
        {
            AssociatedSPTrustedLoginProvider = GetSPTrustAssociatedWithCP(ProviderInternalName);
            if (AssociatedSPTrustedLoginProvider != null)
            {
                zimbraConfig = ZimbraConfig.GetFromConfigDB;
                if (zimbraConfig == null)
                {
                    // Failed to get it from config database, which is expected if LDAPCP is inherited.
                    // Create a fake persisted object just to get the default settings, it will not be saved in config database
                    zimbraConfig = ZimbraConfig.GetDefaultSettings(new ZimbraConfig());
                    ZimbraClaimProvider.LogToULS(
                        String.Format("[{0}] No LdapcpConfig PersistedObject found in the config database. This is expected if class was inherited.", ProviderInternalName),
                        TraceSeverity.Medium,
                        EventSeverity.Information);
                }

                // Initialize settings from persisted object
                this._LDAPUseSharePointDomain = zimbraConfig.UseSharePointDomain;
                if (!_LDAPUseSharePointDomain)
                {
                    this._LDAPConnectionString = zimbraConfig.LDAPConnectionString;
                    this._LDAPUserName = zimbraConfig.LDAPUserName;
                    this._LDAPPassword = zimbraConfig.LDAPPassword;
                    this._LDAPUseServerBind = zimbraConfig.LDAPUseServerBind;
                }
                this._AlwaysResolveValue = zimbraConfig.AlwaysResolveUserInput;
                this._AddWildcardInFrontOfQuery = zimbraConfig.AddWildcardInFrontOfQuery;
                this._PickerEntityGroupName = zimbraConfig.PickerEntityGroupName;
                this._DisplayLdapMatchForIdentityClaimType = zimbraConfig.DisplayLdapMatchForIdentityClaimType;

                // I verified that FillResolve methods always receive value in lowercase so case sensitive doesn't mak sense
                this._IgnoreCaseToDetectDuplicatesValues = true;

                this._FilterEnabledUsersOnly = zimbraConfig.FilterEnabledUsersOnly;
                this._FilterSecurityGroupsOnly = zimbraConfig.FilterSecurityGroupsOnly;

                // Compute attributes list
                _AttributesDefinitionList = PopulateAttributesDefinition();
                PopulateActualAttributesList();

                SetCustomSettings();
            }
        }

        /// <summary>
        /// Override this method to customize settings and behavior of LDAPCP
        /// </summary>
        protected virtual void SetCustomSettings()
        {
        }

        /// <summary>
        /// Populate list that defines the mapping between claim types and LDAP attributes, and other common settings
        /// </summary>
        protected virtual List<ZimbraAttribute> PopulateAttributesDefinition()
        {
            return zimbraConfig.AttributesList;
        }

        /// <summary>
        /// Initializes claim provider. This method is reserved for internal use and is not intended to be called from external code or changed
        /// </summary>
        private void PopulateActualAttributesList()
        {
            if (AssociatedSPTrustedLoginProvider == null)
                return;

            try
            {
                // Get attributes defined in trust based on their claim type (unique way to map them)
                Collection<ZimbraAttribute> attributesDefinedInTrust = new Collection<ZimbraAttribute>();
                // There is a bug in the SharePoint API: SPTrustedLoginProvider.ClaimTypes should retrieve SPTrustedClaimTypeInformation.MappedClaimType, but it returns SPTrustedClaimTypeInformation.InputClaimType instead, so we cannot rely on it
                //foreach (var attr in _AttributesDefinitionList.Where(x => AssociatedSPTrustedLoginProvider.ClaimTypes.Contains(x.claimType)))
                //{
                //    attributesDefinedInTrust.Add(attr);
                //}
                foreach (SPTrustedClaimTypeInformation ClaimTypeInformation in AssociatedSPTrustedLoginProvider.ClaimTypeInformation)
                {
                    try
                    {
                        attributesDefinedInTrust.Add(_AttributesDefinitionList.First(x => x.claimType == ClaimTypeInformation.MappedClaimType && !x.ResolveAsIdentityClaim));
                    }
                    catch (InvalidOperationException ex)
                    {// As documented in http://msdn.microsoft.com/en-us/library/bb535050.aspx, Enumerable.First throws InvalidOperationException if no element satisfies the condition in predicate
                    }
                }

                // Make sure that the identity claim is in this collection. Should always check property SPTrustedClaimTypeInformation.MappedClaimType: http://msdn.microsoft.com/en-us/library/microsoft.sharepoint.administration.claims.sptrustedclaimtypeinformation.mappedclaimtype.aspx
                if (attributesDefinedInTrust == null || attributesDefinedInTrust.Count(x => x.claimType == AssociatedSPTrustedLoginProvider.IdentityClaimTypeInformation.MappedClaimType) == 0)
                {
                    LogToULS(String.Format("[{0}] Impossible to continue because identity claim type \"{1}\" configured in the SharePoint trust is missing in the LDAPCP list. Please use one of the standard LDAPCP claim types as identity claim, or inherit LDAPCP and override method PopulateAttributesDefinition() to add it", ProviderInternalName, AssociatedSPTrustedLoginProvider.IdentityClaimTypeInformation.MappedClaimType), TraceSeverity.Unexpected, EventSeverity.ErrorCritical);
                    return;
                }

                // Get identity attribute from SPTrustedLoginProvider configuration
                IdentityAttribute = attributesDefinedInTrust.Where(x => x.claimType == AssociatedSPTrustedLoginProvider.IdentityClaimTypeInformation.MappedClaimType).First();

                // Check if there are attributes that should be always queried (ResolveAsIdentityClaim) to add in the list
                Collection<ZimbraAttribute> additionalAttributes = new Collection<ZimbraAttribute>();
                foreach (var attr in _AttributesDefinitionList.Where(x => x.ResolveAsIdentityClaim && !attributesDefinedInTrust.Contains(x, new ZimbraPropertiesComparer())))
                {
                    attr.claimType = AssociatedSPTrustedLoginProvider.IdentityClaimTypeInformation.MappedClaimType;
                    attr.claimEntityType = SPClaimEntityTypes.User;
                    attr.LDAPAttributeToDisplay = IdentityAttribute.LDAPAttributeToDisplay; // Must be set otherwise display text of permissions will be inconsistent
                    additionalAttributes.Add(attr);
                }

                _AttributesToQuery = attributesDefinedInTrust.Union(additionalAttributes);
                // Parse each attribute to configure its settings from the corresponding claim types defined in the SPTrustedLoginProvider
                foreach (var attr in _AttributesToQuery.Where(x => x.claimType != null))
                {
                    var trustedClaim = AssociatedSPTrustedLoginProvider.GetClaimTypeInformationFromMappedClaimType(attr.claimType);
                    // Normally it cannot be null except if an attribute exists in following conditions:
                    // a claimType that does not exist in the trust AND AttributeUsage.AlwaysSearchAgainstLDAP
                    if (trustedClaim == null)
                        continue;

                    attr.peoplePickerAttributeDisplayName = trustedClaim.DisplayName;
                    attr.peoplePickerAttributeHierarchyNodeId = trustedClaim.MappedClaimType;
                }

                // Some attributes are not necessarily used in the filter, but they bring additional info about the resolved user and should be included in the result
                // They can be missing in _AttributesToQuery list only if they don't have a claim type defined AND ResolveAsIdentityClaim is not set (will be false)
                MetadataAttributes = _AttributesDefinitionList.Where(x => !String.IsNullOrEmpty(x.peopleEditorEntityDataKey) && !String.IsNullOrEmpty(x.LDAPAttributeName) && String.IsNullOrEmpty(x.claimType) && !x.ResolveAsIdentityClaim);
            }
            catch (Exception ex)
            {
                LogToULS(String.Format("[{0}] Unexpected error while building attributes list: {1}, Callstack: {2}.", ProviderInternalName, ex.Message, ex.StackTrace), TraceSeverity.Unexpected, EventSeverity.Error);
            }
        }

        protected virtual bool SetSPTrustInCurrentContext(Uri context)
        {
            var webApp = SPWebApplication.Lookup(context);
            if (webApp == null)
                return false;

            // Consider following scenario: default zone is NTLM, intranet zone is claims
            // In intranet zone, when creating permission, claim provider will get request 2 times for default and intranet zone
            // So it cannot exclude zones where it is not used
            // otherwise permissions cannot be created and SharePoint will throw error "The user does not exist or is not unique"
            foreach (var zone in Enum.GetValues(typeof(SPUrlZone)))
            {
                SPIisSettings iisSettings = webApp.GetIisSettingsWithFallback((SPUrlZone)zone);

                if (!iisSettings.UseTrustedClaimsAuthenticationProvider)
                    continue;

                // Get the list of authentication providers associated with the zone
                foreach (SPAuthenticationProvider prov in iisSettings.ClaimsAuthenticationProviders)
                {
                    if (prov.GetType() == typeof(Microsoft.SharePoint.Administration.SPTrustedAuthenticationProvider))
                    {
                        // Check if the current SPTrustedAuthenticationProvider is associated with the claim provider
                        if (String.Equals(prov.ClaimProviderName, ProviderInternalName, StringComparison.OrdinalIgnoreCase))
                        {
                            AssociatedSPTrustedLoginProvider = ZimbraClaimProvider.GetSPTrustAssociatedWithCP(ProviderInternalName);
                            return AssociatedSPTrustedLoginProvider == null ? false : true;
                        }
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Get the first TrustedLoginProvider associated with current claim provider
        /// LIMITATION: The same claims provider (uniquely identified by its name) cannot be associated to multiple TrustedLoginProvider because at runtime there is no way to determine what TrustedLoginProvider is currently calling
        /// </summary>
        /// <param name="ProviderInternalName"></param>
        /// <returns></returns>
        public static SPTrustedLoginProvider GetSPTrustAssociatedWithCP(string ProviderInternalName)
        {
            var lp = SPSecurityTokenServiceManager.Local.TrustedLoginProviders.Where(x => String.Equals(x.ClaimProviderName, ProviderInternalName, StringComparison.OrdinalIgnoreCase));

            if (lp != null && lp.Count() == 1)
                return lp.First();

            if (lp != null && lp.Count() > 1)
                LogToULS(String.Format("[{0}] Claims provider is associated to multiple TrustedLoginProvider, which is not supported because at runtime there is no way to determine what TrustedLoginProvider is currently calling", ProviderInternalName), TraceSeverity.Unexpected, EventSeverity.Error);

            LogToULS(String.Format("[{0}] Claims provider {1} is not associated with any SPTrustedLoginProvider, so it cannot create permissions.\r\nVisit http://ldapcp.codeplex.com for installation procedure or set property ClaimProviderName with PowerShell cmdlet Get-SPTrustedIdentityTokenIssuer to create association.", ProviderInternalName, ProviderInternalName), TraceSeverity.Unexpected, EventSeverity.Warning);

            return null;
        }

        protected override void FillClaimTypes(List<string> claimTypes)
        {
            if (claimTypes == null)
                throw new ArgumentNullException("claimTypes");

            if (_AttributesToQuery == null)
                return;

            foreach (var attribute in _AttributesToQuery.Where(x => !String.IsNullOrEmpty(x.claimType)))
            {
                claimTypes.Add(attribute.claimType);
            }
        }

        protected override void FillClaimValueTypes(List<string> claimValueTypes)
        {
            if (claimValueTypes == null)
                throw new ArgumentNullException("claimValueTypes");

            if (_AttributesToQuery == null)
                return;

            foreach (var attribute in _AttributesToQuery.Where(x => !String.IsNullOrEmpty(x.claimValueType)))
            {
                claimValueTypes.Add(attribute.claimValueType);
            }
        }

        protected override void FillClaimsForEntity(Uri context, SPClaim entity, List<SPClaim> claims)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// the type of SPClaimEntityTypes that this provider support, such as SPClaimEntityTypes.User or SPClaimEntityTypes.FormsRole
        /// </summary>
        /// <param name="entityTypes"></param>
        protected override void FillEntityTypes(List<string> entityTypes)
        {
            if (_AttributesToQuery == null)
                return;

            var spUniqueEntitytypes = from attributes in _AttributesToQuery
                                      where attributes.claimEntityType != null
                                      group attributes by new { attributes.claimEntityType } into groupedByEntityType
                                      select new { value = groupedByEntityType.Key.claimEntityType };

            if (null == spUniqueEntitytypes) return;

            foreach (var spEntityType in spUniqueEntitytypes)
            {
                entityTypes.Add(spEntityType.value);
            }
        }

        /// <summary>
        /// Populates the list of attributes in the left side of the people picker
        /// </summary>
        /// <param name="context">the current web application</param>
        /// <param name="entityTypes">the type of SPClaimEntityTypes we should return</param>
        /// <param name="hierarchyNodeID"></param>
        /// <param name="numberOfLevels"></param>
        /// <param name="hierarchy"></param>
        protected override void FillHierarchy(Uri context, string[] entityTypes, string hierarchyNodeID, int numberOfLevels, Microsoft.SharePoint.WebControls.SPProviderHierarchyTree hierarchy)
        {
            if (!SetSPTrustInCurrentContext(context) || _AttributesToQuery == null)
                return;

            if (hierarchyNodeID == null)
            {
                // Root level
                foreach (var attribute in _AttributesToQuery.Where(x => !String.IsNullOrEmpty(x.peoplePickerAttributeHierarchyNodeId) && !x.ResolveAsIdentityClaim && entityTypes.Contains(x.claimEntityType)))
                {
                    hierarchy.AddChild(
                        new Microsoft.SharePoint.WebControls.SPProviderHierarchyNode(
                            _ProviderInternalName,
                            attribute.peoplePickerAttributeDisplayName,
                            attribute.peoplePickerAttributeHierarchyNodeId,
                            true));
                }
            }
        }

        /// <summary>
        /// PickerEntity is resolved (underlined) but claim must be resolved to provide again a PickerEntity so that SharePoint can actually create the permission
        /// </summary>
        /// <param name="context"></param>
        /// <param name="entityTypes"></param>
        /// <param name="resolveInput"></param>
        /// <param name="resolved"></param>
        protected override void FillResolve(Uri context, string[] entityTypes, SPClaim resolveInput, List<Microsoft.SharePoint.WebControls.PickerEntity> resolved)
        {
            if (!String.Equals(resolveInput.OriginalIssuer, SPOriginalIssuers.Format(SPOriginalIssuerType.TrustedProvider, AssociatedSPTrustedLoginProvider.Name), StringComparison.InvariantCultureIgnoreCase))
                return;

            // There is no need to check if LDAPCP is associated to current context at this stage, only thing needed is to create permission once again
            if (_AttributesToQuery == null)
                return;

            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                try
                {
                    Initialize();
                    // Resolve value only against the incoming claim type that uniquely identifies the user (mail, sAMAccountName)
                    var attributes = _AttributesToQuery.Where(x => x.claimType == resolveInput.ClaimType && !x.ResolveAsIdentityClaim);
                    if (attributes.Count() != 1)
                    {
                        // Should always find only 1 attribute at this stage
                        LogToULS(String.Format("[{0}] Found {1} attributes that match the claim type \"{2}\", but exactly 1 is expected. Verify that there is no duplicate claim type. Cancelling resolution of the permission.", ProviderInternalName, attributes.Count().ToString(), resolveInput.ClaimType), TraceSeverity.Unexpected, EventSeverity.Error);
                        return;
                    }
                    var attribute = attributes.FirstOrDefault();

                    string valueToResolve = (!String.IsNullOrEmpty(attribute.PrefixToAddToValueReturned) && resolveInput.Value.StartsWith(attribute.PrefixToAddToValueReturned, StringComparison.InvariantCultureIgnoreCase)) ? resolveInput.Value.Substring(attribute.PrefixToAddToValueReturned.Length) : resolveInput.Value;

                    // At this stage, it is impossible to know if user typed input with a keyword so that it should be validated without LDAP lookup
                    // So best we can do is to check whether this claim type can be resolved without lookup, and create permission if so
                    if (!String.IsNullOrEmpty(attribute.KeywordToValidateInputWithoutLookup))
                    {
                        bool inputHasKeyword = (!String.IsNullOrEmpty(attribute.PrefixToAddToValueReturned) && !resolveInput.Value.StartsWith(attribute.PrefixToAddToValueReturned, StringComparison.InvariantCultureIgnoreCase) && attribute.DoNotAddPrefixIfInputHasKeyword) ? true : false;
                        Collection<PickerEntity> entities = CreatePickerEntityForSpecificClaimTypes(
                                valueToResolve,
                                attribute,
                                inputHasKeyword);
                        if (entities != null)
                        {
                            resolved.Add(entities.FirstOrDefault());
                            LogToULS(String.Format("[{0}] Validated permission without LDAP lookup because corresponding claim type has a keyword associated. Value: {1}, claim type: \"{2}\"", ProviderInternalName, entities.FirstOrDefault().Claim.Value, entities.FirstOrDefault().Claim.ClaimType), TraceSeverity.Medium, EventSeverity.Information);
                            return;
                        }
                    }
                    else
                    {
                        // Search input in LDAP
                        BuildFilterAndProcessResults(valueToResolve, attributes, true, context, entityTypes);
                        if (ConsolidatedResults != null && ConsolidatedResults.Count > 0)
                        {
                            resolved.Add(ConsolidatedResults[0].PickerEntity);
                            LogToULS(String.Format("[{0}] Validated permission with LDAP lookup. Value: {1}, claim type: \"{2}\"", ProviderInternalName, ConsolidatedResults[0].PickerEntity.Claim.Value, ConsolidatedResults[0].PickerEntity.Claim.ClaimType), TraceSeverity.Medium, EventSeverity.Information);
                            return;
                        }
                    }

                    if (_AlwaysResolveValue)
                    {
                        Collection<PickerEntity> entities = CreatePickerEntityForSpecificClaimTypes(
                            valueToResolve,
                            _AttributesToQuery.Where(x => x.claimType == resolveInput.ClaimType),
                            false);

                        if (entities != null)
                        {
                            resolved.Add(entities.FirstOrDefault());
                            LogToULS(String.Format("[{0}] Validated permission without LDAP lookup because LDAPCP configured to always resolve input. claim value: {1}, claim type: \"{2}\"", ProviderInternalName, entities.FirstOrDefault().Claim.Value, entities.FirstOrDefault().Claim.ClaimType), TraceSeverity.Medium, EventSeverity.Information);
                            return;
                        }
                    }
                }
                catch (Exception ex)
                {
                    LogToULS(String.Format("[{0}] Unexpected error in FillResolve: {1}. Callstack: {2}", ProviderInternalName, ex.Message, ex.StackTrace), TraceSeverity.Unexpected, EventSeverity.Error);
                }
            });
        }

        /// <summary>
        /// Called during a search in the small people picker control
        /// </summary>
        /// <param name="context"></param>
        /// <param name="entityTypes"></param>
        /// <param name="resolveInput"></param>
        /// <param name="resolved"></param>
        protected override void FillResolve(Uri context, string[] entityTypes, string resolveInput, List<Microsoft.SharePoint.WebControls.PickerEntity> resolved)
        {
            if (!SetSPTrustInCurrentContext(context) || _AttributesToQuery == null)
                return;

            string input = resolveInput;
            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                try
                {
                    Initialize();

                    //IEnumerable<AttributeHelper> attributes = _AttributesToQuery.Where(x => entityTypes.Contains(x.claimEntityType) && !x.ResolveAsIdentityClaim);
                    IEnumerable<ZimbraAttribute> attributeCollection = _AttributesToQuery.Where(x => entityTypes.Contains(x.claimEntityType) || x.ResolveAsIdentityClaim);

                    // Check if user typed input with a keyword that matches property KeywordToValidateInputWithoutLookup in 1 or several attributes
                    // If so, input should be validated with no lookup in LDAP
                    var claimTypesToCreate = attributeCollection.Where(x => !String.IsNullOrEmpty(x.KeywordToValidateInputWithoutLookup) && input.StartsWith(x.KeywordToValidateInputWithoutLookup, StringComparison.InvariantCultureIgnoreCase));
                    if (claimTypesToCreate != null && claimTypesToCreate.Count() > 0)
                    {
                        LogToULS(String.Format("[{0}] Input \"{1}\" matches keyword defined in {2} claim types. Create 1 permission for each claim type without LDAP lookup.", ProviderInternalName, input, claimTypesToCreate.Count().ToString()), TraceSeverity.Medium, EventSeverity.Information);
                        foreach (var claimTypeToCreate in claimTypesToCreate)
                        {
                            Collection<PickerEntity> entities = CreatePickerEntityForSpecificClaimTypes(
                                input.Substring(claimTypeToCreate.KeywordToValidateInputWithoutLookup.Length),
                                claimTypeToCreate,
                                true);
                            if (entities != null)
                            {
                                foreach (var entity in entities)
                                {
                                    resolved.Add(entity);
                                    LogToULS(String.Format("[{0}] Added permission created without LDAP lookup because input matches a keyword: claim value: \"{1}\", claim type: \"{2}\"", ProviderInternalName, entity.Claim.Value, entity.Claim.ClaimType), TraceSeverity.Medium, EventSeverity.Information);
                                }
                            }
                        }
                    }
                    else
                    {
                        // User input does not contain any keyword
                        // Search input in LDAP
                        BuildFilterAndProcessResults(input, attributeCollection, false, context, entityTypes);
                        if (ConsolidatedResults != null && ConsolidatedResults.Count > 0)
                        {
                            foreach (var result in ConsolidatedResults)
                            {
                                resolved.Add(result.PickerEntity);
                                LogToULS(String.Format("[{0}] Added permission created with LDAP lookup: claim value: \"{1}\", claim type: \"{2}\"", ProviderInternalName, result.PickerEntity.Claim.Value, result.PickerEntity.Claim.ClaimType), TraceSeverity.Medium, EventSeverity.Information);
                            }
                        }
                    }

                    if (_AlwaysResolveValue)
                    {
                        Collection<PickerEntity> entities = CreatePickerEntityForSpecificClaimTypes(
                            input,
                            _AttributesToQuery.Where(x => !x.ResolveAsIdentityClaim && entityTypes.Contains(x.claimEntityType)),
                            false);
                        if (entities != null)
                            foreach (var entity in entities)
                            {
                                resolved.Add(entity);
                                LogToULS(String.Format("[{0}] Added permission created without LDAP lookup because LDAPCP configured to always resolve input: claim value: {1}, claim type: \"{2}\"", ProviderInternalName, entity.Claim.Value, entity.Claim.ClaimType), TraceSeverity.Medium, EventSeverity.Information);
                            }
                    }
                }
                catch (Exception ex)
                {
                    LogToULS(String.Format("[{0}] Unexpected error in FillResolve: {1}. Callstack: {2}", ProviderInternalName, ex.Message, ex.StackTrace), TraceSeverity.Unexpected, EventSeverity.Error);
                }
            });
        }

        private string AddAttributeToFilter(string LDAPAttributeName, string LDAPObjectClass, string searchPattern)
        {
            string filter;
            if (this._FilterSecurityGroupsOnly && String.Equals(LDAPObjectClass, "group", StringComparison.OrdinalIgnoreCase))
                filter = String.Format(LDAPFilter, LDAPAttributeName, searchPattern, LDAPObjectClass, FilterSecurityGroupsOnlyLDAPFilter);
            else
                filter = String.Format(LDAPFilter, LDAPAttributeName, searchPattern, LDAPObjectClass, String.Empty);
            return filter;
        }

        protected void BuildFilterAndProcessResults(string input, IEnumerable<ZimbraAttribute> attributesToQuery, bool exactSearch, Uri context, string[] entityTypes)
        {
            // Build LDAP filter as documented in http://technet.microsoft.com/fr-fr/library/aa996205(v=EXCHG.65).aspx
            string filter = String.Empty;
            if (_FilterEnabledUsersOnly) filter += EnabledUsersOnlyLDAPFilter;
            filter += "(|";

            string searchPattern;
            if (exactSearch)
                searchPattern = input;
            else
                searchPattern = _AddWildcardInFrontOfQuery ? "*" + input + "*" : input + "*";

            foreach (var attribute in attributesToQuery)
            {
                filter += AddAttributeToFilter(attribute.LDAPAttributeName, attribute.LDAPObjectClass, searchPattern);
            }
            if (_FilterEnabledUsersOnly) filter += ")";
            filter += ")";

            ConsolidatedResults = new ZimbraConsolidatedResultCollection();
            ConsolidatedResults.Clear();

            bool resultsfound = false;
            using (new SPMonitoredScope(String.Format("[{0}] Sending query to LDAP server(s)", ProviderInternalName), 1000))
            {
                resultsfound = SearchObjectsInLDAP(filter, context, entityTypes);
            }

            if (resultsfound)
            {
                LogToULS(String.Format("[{0}] Got {1} results with query \"{2}\"", ProviderInternalName, LDAPSearchResults.Length.ToString(), filter), TraceSeverity.Medium, EventSeverity.Information);
                ResultPropertyCollection resultPropertyCollection;
                foreach (SearchResult LDAPresult in this.LDAPSearchResults)
                {
                    resultPropertyCollection = LDAPresult.Properties;
                    // objectclass attribute should never be missing because it is explicitely requested in LDAP query
                    if (!resultPropertyCollection.Contains(LDAPObjectClassName))
                        continue;

                    foreach (var attr in attributesToQuery)
                    {
                        // Check if current attribute object class matches the current LDAP result
                        if (!resultPropertyCollection[LDAPObjectClassName].Contains(attr.LDAPObjectClass))
                            continue;

                        // Check if current LDAP result contains LDAP attribute of current attribute
                        if (!resultPropertyCollection.Contains(attr.LDAPAttributeName))
                            continue;

                        // Check if current attribute matches the input
                        if (exactSearch)
                        {
                            if (String.Compare(resultPropertyCollection[attr.LDAPAttributeName][0].ToString(), input, true) > 0)
                                continue;
                        }
                        else
                        {
                            if (!resultPropertyCollection[attr.LDAPAttributeName][0].ToString().ToLower().Contains(input.ToLower()))
                                continue;
                        }

                        // Add to collection of objectclass/ldap attribute in list of results if it doesn't already exist
                        if (attr.ResolveAsIdentityClaim)
                        {
                            if (!resultPropertyCollection.Contains(IdentityAttribute.LDAPAttributeName) || ConsolidatedResults.Contains(LDAPresult, IdentityAttribute, this._IgnoreCaseToDetectDuplicatesValues))
                                continue;
                        }
                        else
                        {
                            if (ConsolidatedResults.Contains(LDAPresult, attr, this._IgnoreCaseToDetectDuplicatesValues))
                                continue;
                        }

                        ConsolidatedResults.Add(
                            new ZimbraConsolidatedResult
                            {
                                Attribute = attr,
                                LDAPResults = resultPropertyCollection,
                                //DEBUG = String.Format("LDAPAttributeName: {0}, LDAPAttributeValue: {1}, AlwaysResolveAgainstIdentityClaim: {2}", attr.LDAPAttributeName, resultPropertyCollection[attr.LDAPAttributeName][0].ToString(), attr.AlwaysResolveAgainstIdentityClaim.ToString())
                            });
                    }
                }

                foreach (var result in ConsolidatedResults)
                {
                    PickerEntity pe = CreatePickerEntityHelper(result);

                    // Add it to the return list of picker entries.
                    result.PickerEntity = pe;
                }
            }
            else
            {
                LogToULS(String.Format("[{0}] this LDAP query did not return any result result: \"{1}\"", ProviderInternalName, filter), TraceSeverity.Medium, EventSeverity.Information);
            }
        }

        /// <summary>
        /// Create the SPClaim with proper trust name
        /// </summary>
        /// <param name="type">Claim type</param>
        /// <param name="value">Claim value</param>
        /// <param name="valueType">Claim valueType</param>
        /// <param name="inputHasKeyword">Did the original input contain a keyword?</param>
        /// <returns></returns>
        protected virtual SPClaim CreateClaim(string type, string value, string valueType, bool inputHasKeyword)
        {
            string claimValue = String.Empty;
            var attr = _AttributesToQuery.Where(x => x.claimType == type).FirstOrDefault();
            //if (inputHasKeyword && attr.DoNotAddPrefixIfInputHasKeyword)
            if (!inputHasKeyword || !attr.DoNotAddPrefixIfInputHasKeyword)
                //claimValue = _AttributesToQuery.Where(x => x.claimType == type).FirstOrDefault().PrefixToAddToValueReturned;
                claimValue = attr.PrefixToAddToValueReturned;
            claimValue += value;
            return new SPClaim(type, claimValue, valueType, SPOriginalIssuers.Format(SPOriginalIssuerType.TrustedProvider, AssociatedSPTrustedLoginProvider.Name));
        }

        protected virtual PickerEntity CreatePickerEntityHelper(ZimbraConsolidatedResult result)
        {
            PickerEntity pe = CreatePickerEntity();
            SPClaim claim;
            string displayText = String.Empty;

            if (result.Attribute.ResolveAsIdentityClaim)
            {
                // This attribute is not directly linked to a claim type, so permission is created with identity claim type
                claim = CreateClaim(
                    IdentityAttribute.claimType,
                    result.LDAPResults[IdentityAttribute.LDAPAttributeName][0].ToString(),
                    IdentityAttribute.claimValueType,
                    false);
                pe.EntityType = IdentityAttribute.claimEntityType;
            }
            else
            {
                claim = CreateClaim(
                    result.Attribute.claimType,
                    result.LDAPResults[result.Attribute.LDAPAttributeName][0].ToString(),
                    result.Attribute.claimValueType,
                    false);
                pe.EntityType = result.Attribute.claimEntityType;
            }

            bool displayAsIdentityClaimType = false;
            bool displayLdapMatchForIdentityClaimType = false;
            string valueDisplayedInPermission = String.Empty;
            if (String.Equals(result.Attribute.claimType, AssociatedSPTrustedLoginProvider.IdentityClaimTypeInformation.MappedClaimType, StringComparison.InvariantCultureIgnoreCase)
                || result.Attribute.ResolveAsIdentityClaim)
            {
                displayAsIdentityClaimType = true;
                displayLdapMatchForIdentityClaimType = DisplayLdapMatchForIdentityClaimType;
            }

            if (!String.IsNullOrEmpty(result.Attribute.LDAPAttributeToDisplay) && result.LDAPResults.Contains(result.Attribute.LDAPAttributeToDisplay))
            {   // AttributeHelper is set to use a specific LDAP attribute as display text of permission
                if (!displayAsIdentityClaimType)
                    displayText = "(" + result.Attribute.peoplePickerAttributeDisplayName + ") ";
                displayText += valueDisplayedInPermission = result.LDAPResults[result.Attribute.LDAPAttributeToDisplay][0].ToString();
            }
            else
            {   // AttributeHelper is set to use its actual LDAP attribute as display text of permission
                if (!displayAsIdentityClaimType)
                {
                    valueDisplayedInPermission = result.LDAPResults[result.Attribute.LDAPAttributeName][0].ToString();
                    displayText = String.Format(
                        PickerEntityDisplayText,
                        result.Attribute.peoplePickerAttributeDisplayName,
                        valueDisplayedInPermission);
                }
                else
                {   // Always specifically use LDAP attribute of identity claim type
                    displayText = valueDisplayedInPermission = result.LDAPResults[IdentityAttribute.LDAPAttributeName][0].ToString();
                }
            }

            // Check if LDAP value that actually resolved this result should be included in the display text of the permission
            if (displayLdapMatchForIdentityClaimType && result.LDAPResults.Contains(result.Attribute.LDAPAttributeName)
                && !String.Equals(valueDisplayedInPermission, result.LDAPResults[result.Attribute.LDAPAttributeName][0].ToString(), StringComparison.InvariantCultureIgnoreCase))
            {
                displayText += String.Format(" ({0})", result.LDAPResults[result.Attribute.LDAPAttributeName][0].ToString());
            }

            pe.DisplayText = displayText;
            pe.Description = String.Format(
                    PickerEntityOnMouseOver,
                    result.Attribute.LDAPAttributeName,
                    result.LDAPResults[result.Attribute.LDAPAttributeName][0].ToString());
            pe.Claim = claim;
            pe.IsResolved = true;
            pe.EntityGroupName = _PickerEntityGroupName;

            if (result.Attribute.claimEntityType == SPClaimEntityTypes.User)
            {
                // Try to fill some properties in the hashtable of the PickerEntry based on the LDAP objectClass resolved
                // so that the picker entity is populated with as many attributes as possible
                var entityAttribs = from a in _AttributesToQuery
                                    where a.LDAPObjectClass == result.Attribute.LDAPObjectClass && !String.IsNullOrEmpty(a.peopleEditorEntityDataKey)
                                    select new { LDAPAttributeName = a.LDAPAttributeName, peopleEditorEntityDataKey = a.peopleEditorEntityDataKey };

                foreach (var entityAttrib in entityAttribs)
                {
                    if (result.LDAPResults.Contains(entityAttrib.LDAPAttributeName) && result.LDAPResults[entityAttrib.LDAPAttributeName].Count > 0)
                    {
                        pe.EntityData[entityAttrib.peopleEditorEntityDataKey] = result.LDAPResults[entityAttrib.LDAPAttributeName][0].ToString();
                        //LogToULS(String.Format("[{0}] Added metadata \"{1}\" with value \"{2}\" to permission", ProviderInternalName, entityAttrib.peopleEditorEntityDataKey, pe.EntityData[entityAttrib.peopleEditorEntityDataKey]), TraceSeverity.Verbose, EventSeverity.Information);
                    }
                }

                // Populate additional attributes that are not part of the filter but are requested in the result
                foreach (var entityAttrib in MetadataAttributes)
                {
                    if (result.LDAPResults.Contains(entityAttrib.LDAPAttributeName) && result.LDAPResults[entityAttrib.LDAPAttributeName].Count > 0)
                    {
                        pe.EntityData[entityAttrib.peopleEditorEntityDataKey] = result.LDAPResults[entityAttrib.LDAPAttributeName][0].ToString();
                        //LogToULS(String.Format("[{0}] Added metadata \"{1}\" with value \"{2}\" to permission", ProviderInternalName, entityAttrib.peopleEditorEntityDataKey, pe.EntityData[entityAttrib.peopleEditorEntityDataKey]), TraceSeverity.Verbose, EventSeverity.Information);
                    }
                }
            }
            LogToULS(String.Format("[{0}] Created permission: display text: \"{1}\", value: \"{2}\", claim type: \"{3}\".", ProviderInternalName, pe.DisplayText, pe.Claim.Value, pe.Claim.ClaimType), TraceSeverity.Verbose, EventSeverity.Information);
            return pe;
        }

        /// <summary>
        /// Create a PickerEntity of the input for the claim type specified in parameter
        /// </summary>
        /// <param name="input">Value of the permission</param>
        /// <param name="claimTypesToResolve">claim type of the permission</param>
        /// <param name="inputHasKeyword">Did the original input contain a keyword?</param>
        /// <returns></returns>
        protected virtual Collection<PickerEntity> CreatePickerEntityForSpecificClaimTypes(string input, ZimbraAttribute claimTypesToResolve, bool inputHasKeyword)
        {
            return CreatePickerEntityForSpecificClaimTypes(
                input,
                new List<ZimbraAttribute>()
                    {
                        claimTypesToResolve,
                    },
                inputHasKeyword);
        }

        /// <summary>
        /// Create a PickerEntity of the input for each claim type specified in parameter
        /// </summary>
        /// <param name="input">Value of the permission</param>
        /// <param name="claimTypesToResolve">claim types of the permission</param>
        /// <param name="inputHasKeyword">Did the original input contain a keyword?</param>
        /// <returns></returns>
        protected virtual Collection<PickerEntity> CreatePickerEntityForSpecificClaimTypes(string input, IEnumerable<ZimbraAttribute> claimTypesToResolve, bool inputHasKeyword)
        {
            //IEnumerable<AttributeHelper> attributes = _AttributesToQuery.Where(x => !x.ResolveAsIdentityClaim);
            Collection<PickerEntity> entities = new Collection<PickerEntity>();
            foreach (var attribute in claimTypesToResolve)
            {
                PickerEntity pe = CreatePickerEntity();
                SPClaim claim = CreateClaim(attribute.claimType, input, attribute.claimValueType, inputHasKeyword);

                if (String.Equals(claim.ClaimType, AssociatedSPTrustedLoginProvider.IdentityClaimTypeInformation.MappedClaimType, StringComparison.InvariantCultureIgnoreCase))
                {
                    pe.DisplayText = input;
                }
                else
                {
                    pe.DisplayText = String.Format(
                        PickerEntityDisplayText,
                        attribute.peoplePickerAttributeDisplayName,
                        input);
                }

                pe.EntityType = attribute.claimEntityType;
                pe.Description = String.Format(
                    PickerEntityOnMouseOver,
                    attribute.LDAPAttributeName,
                    input);

                pe.Claim = claim;
                pe.IsResolved = true;
                pe.EntityGroupName = _PickerEntityGroupName;

                if (attribute.claimEntityType == SPClaimEntityTypes.User && !String.IsNullOrEmpty(attribute.peopleEditorEntityDataKey))
                {
                    pe.EntityData[attribute.peopleEditorEntityDataKey] = pe.Claim.Value;
                    //LogToULS(String.Format("[{0}] Added metadata \"{1}\" with value \"{2}\" to permission", ProviderInternalName, attribute.peopleEditorEntityDataKey, pe.EntityData[attribute.peopleEditorEntityDataKey]), TraceSeverity.Verbose, EventSeverity.Information);
                }

                entities.Add(pe);
                LogToULS(String.Format("[{0}] Created permission: display text: \"{1}\", value: \"{2}\", claim type: \"{3}\".", ProviderInternalName, pe.DisplayText, pe.Claim.Value, pe.Claim.ClaimType), TraceSeverity.Verbose, EventSeverity.Information);
            }
            return entities;
        }

        protected override void FillSchema(Microsoft.SharePoint.WebControls.SPProviderSchema schema)
        {
        }

        protected override void FillSearch(Uri context, string[] entityTypes, string searchPattern, string hierarchyNodeID, int maxCount, Microsoft.SharePoint.WebControls.SPProviderHierarchyTree searchTree)
        {
            if (!SetSPTrustInCurrentContext(context) || _AttributesToQuery == null)
                return;

            SPProviderHierarchyNode matchNode = null;
            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                try
                {
                    Initialize();

                    IEnumerable<ZimbraAttribute> attributes;
                    if (!String.IsNullOrEmpty(hierarchyNodeID))
                    {
                        // Restrict search to attribute currently selected in the hierarchy
                        attributes = _AttributesToQuery.Where(
                            x => x.peoplePickerAttributeHierarchyNodeId == hierarchyNodeID &&
                            entityTypes.Contains(x.claimEntityType));

                        // if currently selected attribute is identity attribute then add LDAP attributes that should always be queried
                        if (attributes.Contains(IdentityAttribute))
                            attributes = attributes.Union(_AttributesToQuery.Where(x => x.ResolveAsIdentityClaim));
                    }
                    else
                    {
                        attributes = _AttributesToQuery.Where(x => entityTypes.Contains(x.claimEntityType) || x.ResolveAsIdentityClaim);
                    }

                    // Get list of claim types that should be created without lookup, if the input matches the prefix defined
                    var PermissionsToCreateWithoutLookup = attributes.Where(
                        x => !String.IsNullOrEmpty(x.KeywordToValidateInputWithoutLookup) &&
                        searchPattern.StartsWith(x.KeywordToValidateInputWithoutLookup, StringComparison.InvariantCultureIgnoreCase));
                    if (PermissionsToCreateWithoutLookup != null && PermissionsToCreateWithoutLookup.Count() > 0)
                    {
                        foreach (var PermissionToCreate in PermissionsToCreateWithoutLookup)
                        {
                            //var claimTypeInfo = _AttributesToQuery.Where(x => x.claimType == PermissionToCreate.claimType);
                            Collection<PickerEntity> entities = CreatePickerEntityForSpecificClaimTypes(
                                searchPattern.Substring(PermissionToCreate.KeywordToValidateInputWithoutLookup.Length),
                                PermissionToCreate,
                                true);

                            if (searchTree.HasChild(PermissionToCreate.peoplePickerAttributeHierarchyNodeId))
                            {
                                matchNode = searchTree.Children.First(x => String.Equals(x.HierarchyNodeID, PermissionToCreate.peoplePickerAttributeHierarchyNodeId, StringComparison.InvariantCultureIgnoreCase));
                            }
                            else
                            {
                                matchNode = new SPProviderHierarchyNode(_ProviderInternalName, PermissionToCreate.peoplePickerAttributeDisplayName, PermissionToCreate.peoplePickerAttributeHierarchyNodeId, true);
                                searchTree.AddChild(matchNode);
                            }
                            PickerEntity entity = entities.FirstOrDefault();
                            matchNode.AddEntity(entity);
                            LogToULS(String.Format("[{0}] Added permission created without LDAP lookup because input matches a keyword: claim value: \"{1}\", claim type: \"{2}\" to the list of results.", ProviderInternalName, entity.Claim.Value, entity.Claim.ClaimType), TraceSeverity.Medium, EventSeverity.Information);
                        }
                    }
                    else
                    {
                        BuildFilterAndProcessResults(
                            searchPattern,
                            attributes.Where(x =>
                                !String.IsNullOrEmpty(x.LDAPAttributeName) &&
                                !String.IsNullOrEmpty(x.LDAPObjectClass)),
                             false,
                             context,
                             entityTypes);
                        if (ConsolidatedResults != null && ConsolidatedResults.Count > 0)
                        {
                            foreach (var consolidatedResult in ConsolidatedResults)
                            {
                                // Add current PickerEntity to the corresponding attribute in the hierarchy
                                if (searchTree.HasChild(consolidatedResult.Attribute.peoplePickerAttributeHierarchyNodeId))
                                {
                                    matchNode = searchTree.Children.First(x => x.HierarchyNodeID == consolidatedResult.Attribute.peoplePickerAttributeHierarchyNodeId);
                                }
                                else
                                {
                                    matchNode = new SPProviderHierarchyNode(_ProviderInternalName, consolidatedResult.Attribute.peoplePickerAttributeDisplayName, consolidatedResult.Attribute.peoplePickerAttributeHierarchyNodeId, true);
                                    searchTree.AddChild(matchNode);
                                }
                                matchNode.AddEntity(consolidatedResult.PickerEntity);
                                LogToULS(String.Format("[{0}] Added permission created with LDAP lookup: claim value: \"{1}\", claim type: \"{2}\" to the list of results.", ProviderInternalName, consolidatedResult.PickerEntity.Claim.Value, consolidatedResult.PickerEntity.Claim.ClaimType), TraceSeverity.Medium, EventSeverity.Information);
                            }
                        }
                    }

                    if (_AlwaysResolveValue)
                    {
                        Collection<PickerEntity> entities = CreatePickerEntityForSpecificClaimTypes(
                            searchPattern,
                            attributes.Where(x => !x.ResolveAsIdentityClaim),
                            false);
                        if (entities != null)
                        {
                            foreach (var entity in entities)
                            {
                                // Add current PickerEntity to the corresponding attribute in the hierarchy
                                var hirarchyDetails = from a in _AttributesToQuery
                                                      where a.claimType == entity.Claim.ClaimType && !a.ResolveAsIdentityClaim
                                                      select new { hierarchyNodeId = a.peoplePickerAttributeHierarchyNodeId, hierarchyNodeDisplayName = a.peoplePickerAttributeDisplayName };


                                if (searchTree.HasChild(hirarchyDetails.FirstOrDefault().hierarchyNodeId))
                                {
                                    matchNode = searchTree.Children.First(x => String.Equals(x.HierarchyNodeID, hirarchyDetails.FirstOrDefault().hierarchyNodeId, StringComparison.InvariantCultureIgnoreCase));
                                }
                                else
                                {
                                    matchNode = new SPProviderHierarchyNode(_ProviderInternalName, hirarchyDetails.FirstOrDefault().hierarchyNodeDisplayName, hirarchyDetails.FirstOrDefault().hierarchyNodeId, true);
                                    searchTree.AddChild(matchNode);
                                }
                                matchNode.AddEntity(entity);
                                LogToULS(String.Format("[{0}] Added permission created without LDAP lookup because LDAPCP configured to always resolve input: claim value: \"{1}\", claim type: \"{2}\" to the list of results.", ProviderInternalName, entity.Claim.Value, entity.Claim.ClaimType), TraceSeverity.Medium, EventSeverity.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    LogToULS(String.Format("[{0}] Unexpected error in FillSearch: {1}. Callstack: {2}", ProviderInternalName, ex.Message, ex.StackTrace), TraceSeverity.Unexpected, EventSeverity.Error);
                }
            });
        }

        public override string Name
        {
            get { return ProviderInternalName; }
        }

        public override bool SupportsEntityInformation
        {
            get { return false; }
        }

        public override bool SupportsHierarchy
        {
            get { return AssociatedSPTrustedLoginProvider == null ? false : true; }
        }

        public override bool SupportsResolve
        {
            get { return AssociatedSPTrustedLoginProvider == null ? false : true; }
        }

        public override bool SupportsSearch
        {
            get { return AssociatedSPTrustedLoginProvider == null ? false : true; }
        }

        protected virtual DirectoryEntry[] SetLDAPConnections(Uri context, string[] entityTypes)
        {
            if (!this._LDAPUseSharePointDomain)
            {
                LogToULS(String.Format("[{0}] Connect as {1} to {2}. Use ServerBind authentication: {3}", ProviderInternalName, this._LDAPUserName, this._LDAPConnectionString, this._LDAPUseServerBind), TraceSeverity.Medium, EventSeverity.Information);
                if (_LDAPUseServerBind)
                    return new DirectoryEntry[] { 
                        new DirectoryEntry (this._LDAPConnectionString, this._LDAPUserName, this._LDAPPassword, AuthenticationTypes.ServerBind)
                    };
                else
                    return new DirectoryEntry[] { 
                        new DirectoryEntry (this._LDAPConnectionString,this._LDAPUserName, this._LDAPPassword)
                    };
            }
            else
            {
                LogToULS(String.Format("[{0}] Connect to AD this server is member of, with application pool credentials", ProviderInternalName), TraceSeverity.Medium, EventSeverity.Information);
                return new DirectoryEntry[] { 
                    System.DirectoryServices.ActiveDirectory.Domain.GetComputerDomain().GetDirectoryEntry()
                };
            }
        }

        /// <summary>
        /// Query LDAP to find matches
        /// </summary>
        /// <param name="filter">looks like "(&(objectClass=user) ( |(cn=value) (mail=value)))"</param>
        /// <returns>true if 1 or more objects are found</returns>
        protected bool SearchObjectsInLDAP(string filter, Uri context, string[] entityTypes)
        {
            DirectoryEntry[] directories = SetLDAPConnections(context, entityTypes);
            DirectorySearcher ds = new DirectorySearcher();
            ds.Filter = filter;
            ds.PropertiesToLoad.Add(LDAPObjectClassName);
            foreach (var ldapAttribute in _AttributesToQuery.Where(x => !String.IsNullOrEmpty(x.LDAPAttributeName)))
            {
                ds.PropertiesToLoad.Add(ldapAttribute.LDAPAttributeName);
                if (!String.IsNullOrEmpty(ldapAttribute.LDAPAttributeToDisplay)) ds.PropertiesToLoad.Add(ldapAttribute.LDAPAttributeToDisplay);
            }

            // Populate additional attributes that are not part of the filter but are requested in the result
            //foreach (var metadataAttribute in _AttributesDefinitionList.Where(x => !String.IsNullOrEmpty(x.peopleEditorEntityDataKey) && !String.IsNullOrEmpty(x.LDAPAttributeName) && !ds.PropertiesToLoad.Contains(x.LDAPAttributeName)))
            foreach (var metadataAttribute in MetadataAttributes)
            {
                ds.PropertiesToLoad.Add(metadataAttribute.LDAPAttributeName);
            }

            if (directories == null)
            {
                LogToULS(String.Format("[{0}] No LDAP connection found", ProviderInternalName), TraceSeverity.Unexpected, EventSeverity.Error);
                return false;
            }

            // Query LDAP servers
            List<SearchResult> results = new List<SearchResult>();
            foreach (DirectoryEntry directory in directories)
            {
                try
                {
                    ds.SearchRoot = directory;
                    SearchResultCollection directoryResults = ds.FindAll();
                    results.AddRange(directoryResults.OfType<SearchResult>());
                    LogToULS(String.Format("[{0}] Got {1} results from {2}", ProviderInternalName, directoryResults.Count.ToString(), directory.Path), TraceSeverity.Verbose, EventSeverity.Information);
                    directoryResults.Dispose();
                }
                catch (Exception ex)
                {
                    LogToULS(String.Format("[{0}] Unexpected error during connection to LDAP server \"{1}\": {2}. Callstack: {3}", ProviderInternalName, directory.Path, ex.Message, ex.StackTrace), TraceSeverity.Unexpected, EventSeverity.Error);
                }
            }

            // Fill SearchResult[] array
            LDAPSearchResults = new SearchResult[results.Count];
            results.CopyTo(LDAPSearchResults, 0);

            if (null == LDAPSearchResults)
                return false;
            else
                return LDAPSearchResults.Length > 0;
        }

        public static void LogToULS(string message, TraceSeverity traceSeverity, EventSeverity eventSeverity)
        {
            try
            {
                SPDiagnosticsCategory category = new SPDiagnosticsCategory(LDAPCPUlsCategory, traceSeverity, eventSeverity);
                SPDiagnosticsService ds = SPDiagnosticsService.Local;
                ds.WriteTrace(0, category, traceSeverity, message);
            }
            catch
            {
            }
        }

        protected override void FillDefaultLocalizedDisplayName(System.Globalization.CultureInfo culture, out string localizedName)
        {
            if (AssociatedSPTrustedLoginProvider != null)
                localizedName = AssociatedSPTrustedLoginProvider.DisplayName;
            else
                base.FillDefaultLocalizedDisplayName(culture, out localizedName);
        }
        */

    }
}