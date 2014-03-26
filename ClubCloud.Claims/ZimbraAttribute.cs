using Microsoft.SharePoint.Administration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Claims
{
    /// <summary>
    /// Defines an attribute persisted in config database
    /// </summary>
    public class ZimbraAttribute : SPAutoSerializingObject
    {
        /// <summary>
        /// Name of the attribute in LDAP
        /// </summary>
        [Persisted]
        public string LDAPAttributeName;

        /// <summary>
        /// Class of the attribute in LDAP, typically user or group
        /// </summary>
        [Persisted]
        public string LDAPObjectClass;

        /// <summary>
        /// Define the claim type associated with the attribute that must map the claim type defined in the SP trust
        /// For example "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress"
        /// </summary>
        [Persisted]
        public string claimType;

        /// <summary>
        /// What represents the attribute (a user, a role, a security group, etc...)
        /// </summary>
        [Persisted]
        public string claimEntityType;

        /// <summary>
        /// When creating a PickerEntry, it's possible to populate entry with additional attributes stored in EntityData hash table
        /// </summary>
        [Persisted]
        public string peopleEditorEntityDataKey;

        /// <summary>
        /// Set to true if the attribute should always be queried in LDAP even if it is not defined in the SP trust (typically displayName and cn attributes)
        /// </summary>
        [Persisted]
        public bool ResolveAsIdentityClaim = false;

        /// <summary>
        /// This attribute is not intended to be used or modified in your code
        /// </summary>
        [Persisted]
        public string peoplePickerAttributeDisplayName;

        /// <summary>
        /// This attribute is not intended to be used or modified in your code
        /// </summary>
        [Persisted]
        public string peoplePickerAttributeHierarchyNodeId;

        /// <summary>
        /// Every claim value type is a string by default
        /// </summary>
        [Persisted]
        public string claimValueType = System.Security.Claims.ClaimValueTypes.String;

        /// <summary>
        /// This prefix is added to the value of the permission created. This is useful to add a domain name before a group name (for example "domain\group" instead of "group")
        /// </summary>
        [Persisted]
        public string PrefixToAddToValueReturned;

        /// <summary>
        /// If set to true: permission created without LDAP lookup (possible if KeywordToValidateInputWithoutLookup is set and user typed this keyword in the input) should not contain the prefix (set in PrefixToAddToValueReturned) in the value
        /// </summary>
        [Persisted]
        public bool DoNotAddPrefixIfInputHasKeyword;

        /// <summary>
        /// Set this to tell LDAPCP to validate user input (and create the permission) without LDAP lookup if it contains this keyword at the beginning
        /// </summary>
        [Persisted]
        public string KeywordToValidateInputWithoutLookup;

        /// <summary>
        /// Set this property to customize display text of the permission with a specific LDAP attribute (different than LDAPAttributeName, that is the actual value of the permission)
        /// </summary>
        [Persisted]
        public string LDAPAttributeToDisplay;

        public ZimbraAttribute()
        {
        }
    }

}
