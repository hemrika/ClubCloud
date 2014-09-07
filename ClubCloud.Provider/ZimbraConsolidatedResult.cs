using Microsoft.SharePoint.WebControls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Claims
{
    public class ZimbraConsolidatedResult
    {
        public ZimbraAttribute Attribute;
        public PickerEntity PickerEntity;
        public ResultPropertyCollection LDAPResults;
        public int nbMatch = 0;
        //public string DEBUG;
    }



    /// <summary>
    /// Compare 2 results to not add duplicates
    /// they are identical if they have the same claim type and same value
    /// </summary>
    public class ZimbraConsolidatedResultCollection : Collection<ZimbraConsolidatedResult>
    {
        public bool Contains(SearchResult Result, ZimbraAttribute Attribute, bool IgnoreCaseToDetectDuplicatesValues)
        {
            foreach (var item in base.Items)
            {
                if (item.Attribute.claimType != Attribute.claimType)
                    continue;

                if (!item.LDAPResults.Contains(Attribute.LDAPAttributeName))
                    continue;

                if (String.Compare(item.LDAPResults[Attribute.LDAPAttributeName][0].ToString(), Result.Properties[Attribute.LDAPAttributeName][0].ToString(), IgnoreCaseToDetectDuplicatesValues) == 0)
                {
                    item.nbMatch++;
                    return true;
                }
            }
            return false;
        }
    }
}
