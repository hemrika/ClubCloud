using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Claims
{
    /// <summary>
    /// Check if 2 attributes are identical (sams class and same name) to not add duplicates to the attributes list
    /// http://msdn.microsoft.com/en-us/library/bb338049
    /// </summary>
    class ZimbraPropertiesComparer : IEqualityComparer<ZimbraAttribute>
    {
        // LDAP Attributes are equal if they have same LDAPAttributeName and same LDAPObjectClass
        public bool Equals(ZimbraAttribute x, ZimbraAttribute y)
        {
            // Check whether the compared objects reference the same data.
            if (Object.ReferenceEquals(x, y)) return true;

            //Check whether any of the compared objects is null.
            if (Object.ReferenceEquals(x, null) || Object.ReferenceEquals(y, null))
                return false;

            // Check if they have same LDAPAttributeName and same LDAPObjectClass
            //return ((String.Compare(x.LDAPAttributeName, y.LDAPAttributeName, true) == 0) && (String.Compare(x.LDAPObjectClass, y.LDAPObjectClass, true) == 0));
            return ((String.Equals(x.LDAPAttributeName, y.LDAPAttributeName, StringComparison.OrdinalIgnoreCase)) && (String.Equals(x.LDAPObjectClass, y.LDAPObjectClass, StringComparison.OrdinalIgnoreCase)));
        }

        // If Equals() returns true for a pair of objects 
        // then GetHashCode() must return the same value for these objects.
        public int GetHashCode(ZimbraAttribute attribute)
        {
            //Check whether the object is null
            if (Object.ReferenceEquals(attribute, null)) return 0;

            // Add an extra space so that string can never be null and GetHashCode will never fail
            return (attribute.LDAPAttributeName + " " + attribute.LDAPObjectClass).GetHashCode();
        }
    }
}
