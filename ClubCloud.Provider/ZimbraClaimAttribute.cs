using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Provider
{
    class ZimbraClaimAttribute
    {
        /// <summary>
        /// What represents the attribute (a user, a role, a security group, etc.)
        /// </summary>
        public string ClaimEntityType { get; set; }

        public string PeoplePickerAttributeHierarchyNodeId { get; set; }

        public string PeoplePickerAttributeDisplayName { get; set; }
    }
}
