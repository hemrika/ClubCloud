using Microsoft.SharePoint.Administration;
using Microsoft.SharePoint.Administration.Claims;
using Microsoft.SharePoint.WebControls;
using System;
using System.Collections.Generic;
using nsmsclaims = System.Security.Claims;

namespace ClubCloud.Claims
{
    public class Constants
    {
        public const string LDAPCPPersistedObjectID = "5D306A02-A262-48AC-8C44-BDB927620227";
    }

    //[GuidAttribute(Constants.LDAPCPPersistedObjectID)]
    public class ZimbraConfig : SPPersistedObject
    {
        public const string LdapcpPersistecObjectName = "LdapcpConfig";

        //[Persisted]
        //public IDictionary<string, LDAPCPAttributesList> AttributesList;

        [Persisted]
        public List<ZimbraAttribute> AttributesList;

        [Persisted]
        public bool UseSharePointDomain = true;

        [Persisted]
        public string LDAPConnectionString;

        [Persisted]
        public string LDAPUserName;

        [Persisted]
        public string LDAPPassword;

        [Persisted]
        public bool LDAPUseServerBind;

        [Persisted]
        public bool AlwaysResolveUserInput;

        [Persisted]
        public bool AddWildcardInFrontOfQuery;

        [Persisted]
        public bool DisplayLdapMatchForIdentityClaimType;

        [Persisted]
        public string PickerEntityGroupName;

        [Persisted]
        public bool FilterEnabledUsersOnly;

        [Persisted]
        public bool FilterSecurityGroupsOnly;

        public ZimbraConfig(SPPersistedObject parent)
            : base(LdapcpPersistecObjectName, parent)
        {
        }

        public ZimbraConfig()
        {
        }

        protected override bool HasAdditionalUpdateAccess()
        {
            return false;
        }

        public static ZimbraConfig GetFromConfigDB
        {
            get
            {
                SPPersistedObject parent = SPFarm.Local;
                try
                {
                    return parent.GetChild<ZimbraConfig>(LdapcpPersistecObjectName);
                }
                catch (Exception ex)
                {
                    ex.ToString();
                    //ZimbraClaimProvider.LogToULS(String.Format("Error while retrieving SPPersistedObject {0}: {1}", LdapcpPersistecObjectName, ex.Message), TraceSeverity.Unexpected, EventSeverity.Error);
                }
                return null;
            }
        }

        public static ZimbraConfig ResetClaimsList()
        {
            ZimbraConfig persistedObject = GetFromConfigDB;
            if (persistedObject != null)
            {
                persistedObject.AttributesList.Clear();
                persistedObject.AttributesList = GetDefaultAttributesList();
                persistedObject.Update();

                //ZimbraClaimProvider.LogToULS(String.Format("Claims list of PersistedObject {0} was successfully reset to default relationship table", ZimbraConfig.LdapcpPersistecObjectName), TraceSeverity.High, EventSeverity.Information);
            }
            return null;
        }

        /// <summary>
        /// Create the persisted object that contains default configuration of LDAPCP.
        /// It should be created only in central administration with application pool credentials
        /// because this is the only place where we are sure user has the permission to write in the config database
        /// </summary>
        public static ZimbraConfig CreatePersistedObject()
        {
            ZimbraConfig PersistedObject = new ZimbraConfig(SPFarm.Local);
            PersistedObject.Id = new Guid(Constants.LDAPCPPersistedObjectID);
            PersistedObject = GetDefaultSettings(PersistedObject);
            try
            {
                PersistedObject.Update();
            }
            catch (NullReferenceException nullex)
            {
                // This exception occurs if an older version of the persisted object lives in the config database with a schema that doesn't match current one
                string stsadmcmd = String.Format("SELECT * FROM Objects WHERE Id LIKE '{0}'", Constants.LDAPCPPersistedObjectID);
                string error = String.Format("Unable to create PersistedObject {0}. This usually occurs because a persisted object with the same Id is used by another assembly (could be a previous version). Object is impossible to update or delete from Object Model unless you add the missing assembly to the GAC. You can see this object by running this query: \"{1}\"", PersistedObject.Name, stsadmcmd);

                //ZimbraClaimProvider.LogToULS(error,TraceSeverity.Unexpected,EventSeverity.Error);

                // Tyy to delete it... but OM doesn't manage to get the object
                SPPersistedObject staleObject = SPFarm.Local.GetObject(new Guid(Constants.LDAPCPPersistedObjectID));
                if (staleObject != null)
                {
                    staleObject.Delete();
                    PersistedObject.Update();
                }
                else
                {
                    throw new Exception(error, nullex);
                }
            }

            //ZimbraClaimProvider.LogToULS(String.Format("Created PersistedObject {0} with Id {1}", PersistedObject.Name, PersistedObject.Id),TraceSeverity.Medium,EventSeverity.Information);

            return PersistedObject;
        }

        public static ZimbraConfig GetDefaultSettings(ZimbraConfig PersistedObject)
        {
            PersistedObject.AttributesList = GetDefaultAttributesList();
            PersistedObject.PickerEntityGroupName = "Results";
            PersistedObject.AlwaysResolveUserInput = false;
            PersistedObject.UseSharePointDomain = true;
            PersistedObject.AlwaysResolveUserInput = false;
            PersistedObject.AddWildcardInFrontOfQuery = false;
            PersistedObject.FilterEnabledUsersOnly = false;
            PersistedObject.FilterSecurityGroupsOnly = false;
            return PersistedObject;
        }

        public static List<ZimbraAttribute> GetDefaultAttributesList()
        {
            return new List<ZimbraAttribute>
            {
                new ZimbraAttribute{LDAPAttributeName="mail", LDAPObjectClass="user", claimType=nsmsclaims.ClaimTypes.Email, claimEntityType = SPClaimEntityTypes.User, peopleEditorEntityDataKey=PeopleEditorEntityDataKeys.Email},
                new ZimbraAttribute{LDAPAttributeName="sAMAccountName", LDAPObjectClass="user", claimType=nsmsclaims.ClaimTypes.WindowsAccountName, claimEntityType = SPClaimEntityTypes.User},
                new ZimbraAttribute{LDAPAttributeName="userPrincipalName", LDAPObjectClass="user", claimType=nsmsclaims.ClaimTypes.Upn, claimEntityType = SPClaimEntityTypes.User},
                new ZimbraAttribute{LDAPAttributeName="givenName", LDAPObjectClass="user", claimType=nsmsclaims.ClaimTypes.GivenName, claimEntityType = SPClaimEntityTypes.User},
                new ZimbraAttribute{LDAPAttributeName="physicalDeliveryOfficeName", LDAPObjectClass="user", claimType=nsmsclaims.ClaimTypes.Locality, claimEntityType = SPClaimEntityTypes.FormsRole, peopleEditorEntityDataKey=PeopleEditorEntityDataKeys.Location},
                new ZimbraAttribute{LDAPAttributeName="sAMAccountName", LDAPObjectClass="group", claimType=nsmsclaims.ClaimTypes.Role, claimEntityType = SPClaimEntityTypes.FormsRole},
                new ZimbraAttribute{LDAPAttributeName="displayName", LDAPObjectClass="user", ResolveAsIdentityClaim=true, peopleEditorEntityDataKey=PeopleEditorEntityDataKeys.DisplayName},
                new ZimbraAttribute{LDAPAttributeName="cn", LDAPObjectClass="user", ResolveAsIdentityClaim=true},
                new ZimbraAttribute{LDAPAttributeName="sn", LDAPObjectClass="user", ResolveAsIdentityClaim=true},
                new ZimbraAttribute{LDAPAttributeName="title", LDAPObjectClass="user", peopleEditorEntityDataKey=PeopleEditorEntityDataKeys.JobTitle},
                new ZimbraAttribute{LDAPAttributeName="msRTCSIP-PrimaryUserAddress", LDAPObjectClass="user", peopleEditorEntityDataKey=PeopleEditorEntityDataKeys.SIPAddress},
                new ZimbraAttribute{LDAPAttributeName="telephoneNumber", LDAPObjectClass="user", peopleEditorEntityDataKey=PeopleEditorEntityDataKeys.WorkPhone},
            };
        }
    }

}
