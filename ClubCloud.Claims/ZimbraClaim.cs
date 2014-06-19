//using Microsoft.IdentityModel.Claims;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration.Claims;
using Microsoft.SharePoint.WebControls;
using System;
using System.Collections;
using System.Collections.Generic;
//using System.IdentityModel.Claims;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Provider
{
    public class ZimbraClaim //: ClaimsIdentity
    {
        public string Name;
        public string ClaimType;
        public string ClaimTypeValue;
        public string EntityType;
        public string EntityDataKey;
        public Guid FieldId;
    }

    internal class ZimbraClaims : List<ZimbraClaim>
    {
    }

    internal class ZimbraClaimsMapped
    {
        private static ZimbraClaims _Claims = null;

        public static ZimbraClaims Claims
        {
            get
            {
                if (ZimbraClaimsMapped._Claims == null)
                {
                    MapClaims();
                }
                return ZimbraClaimsMapped._Claims;
            }
            internal set 
            { 
                ZimbraClaimsMapped._Claims = value; 
            }
        }

        internal static void MapClaims()
        {
            if (_Claims == null)
            {
                _Claims = new ZimbraClaims();
            }

            ZimbraClaimsMapped._Claims.Add(new ZimbraClaim { Name = "DistributionList", ClaimType = SPClaimTypes.DistributionListClaimType, ClaimTypeValue = "http://www.w3.org/2001/XMLSchema#string", EntityType = SPClaimEntityTypes.DistributionList });
            ZimbraClaimsMapped._Claims.Add(new ZimbraClaim { Name = "Email", FieldId = ZimbraFieldId.EMail, ClaimType = ClaimTypes.Email, ClaimTypeValue = "http://www.w3.org/2001/XMLSchema#string", EntityType = SPClaimEntityTypes.User, EntityDataKey = PeopleEditorEntityDataKeys.Email });
            ZimbraClaimsMapped._Claims.Add(new ZimbraClaim { Name = "MailForwardingAddress", ClaimType = ClaimTypes.Email, ClaimTypeValue = "http://www.w3.org/2001/XMLSchema#string", EntityType = SPClaimEntityTypes.User, EntityDataKey = PeopleEditorEntityDataKeys.Email });
            ZimbraClaimsMapped._Claims.Add(new ZimbraClaim { Name = "MailAlias", ClaimType = ClaimTypes.Email, ClaimTypeValue = "http://www.w3.org/2001/XMLSchema#string", EntityType = SPClaimEntityTypes.User, EntityDataKey = PeopleEditorEntityDataKeys.Email });
            ZimbraClaimsMapped._Claims.Add(new ZimbraClaim { Name = "SecurityGroup", ClaimType = "http://schemas.microsoft.com/ws/2008/06/identity/claims/groupsid", ClaimTypeValue = "http://www.w3.org/2001/XMLSchema#string", EntityType = SPClaimEntityTypes.SecurityGroup });
            ZimbraClaimsMapped._Claims.Add(new ZimbraClaim { Name = "User", ClaimType = SPClaimTypes.UserLogonName, ClaimTypeValue = "http://www.w3.org/2001/XMLSchema#string", EntityType = SPClaimEntityTypes.User, EntityDataKey = PeopleEditorEntityDataKeys.UserId });
            ZimbraClaimsMapped._Claims.Add(new ZimbraClaim { Name = "givenName", FieldId = ZimbraFieldId.FirstName, ClaimType = ClaimTypes.GivenName, ClaimTypeValue = "http://www.w3.org/2001/XMLSchema#string", EntityType = SPClaimEntityTypes.User });
            ZimbraClaimsMapped._Claims.Add(new ZimbraClaim { Name = "displayName", FieldId = ZimbraFieldId.Title, ClaimType = ClaimTypes.Name, ClaimTypeValue = "http://www.w3.org/2001/XMLSchema#string", EntityType = SPClaimEntityTypes.User, EntityDataKey = PeopleEditorEntityDataKeys.DisplayName });
            ZimbraClaimsMapped._Claims.Add(new ZimbraClaim { Name = "cn", ClaimType = ClaimTypes.Name, ClaimTypeValue = "http://www.w3.org/2001/XMLSchema#string", EntityType = SPClaimEntityTypes.User });
            ZimbraClaimsMapped._Claims.Add(new ZimbraClaim { Name = "sn", ClaimType = ClaimTypes.Surname, ClaimTypeValue = "http://www.w3.org/2001/XMLSchema#string", EntityType = SPClaimEntityTypes.User });
            //_Claims.Add(new ZimbraClaim { Name = "initials", FieldId = ZimbraFieldId.MiddleName, ClaimType = ClaimTypes.Name, ClaimTypeValue = "http://www.w3.org/2001/XMLSchema#string", EntityType = SPClaimEntityTypes.User, EntityDataKey = PeopleEditorEntityDataKeys.DisplayName });
            ZimbraClaimsMapped._Claims.Add(new ZimbraClaim { Name = "telephoneNumber", FieldId = ZimbraFieldId.WorkPhone, ClaimType = ClaimTypes.OtherPhone, ClaimTypeValue = "http://www.w3.org/2001/XMLSchema#string", EntityType = SPClaimEntityTypes.User, EntityDataKey = PeopleEditorEntityDataKeys.WorkPhone });
            ZimbraClaimsMapped._Claims.Add(new ZimbraClaim { Name = "mobile", FieldId = ZimbraFieldId.MobilePhone, ClaimType = ClaimTypes.MobilePhone, ClaimTypeValue = "http://www.w3.org/2001/XMLSchema#string", EntityType = SPClaimEntityTypes.User, EntityDataKey = PeopleEditorEntityDataKeys.MobilePhone });
            ZimbraClaimsMapped._Claims.Add(new ZimbraClaim { Name = "homePhone", ClaimType = ClaimTypes.HomePhone, ClaimTypeValue = "http://www.w3.org/2001/XMLSchema#string", EntityType = SPClaimEntityTypes.User });
            ZimbraClaimsMapped._Claims.Add(new ZimbraClaim { Name = "street", FieldId = ZimbraFieldId.HomeAddressStreet, ClaimType = ClaimTypes.StreetAddress, ClaimTypeValue = "http://www.w3.org/2001/XMLSchema#string", EntityType = SPClaimEntityTypes.User });
            ZimbraClaimsMapped._Claims.Add(new ZimbraClaim { Name = "postalCode", FieldId = ZimbraFieldId.HomeAddressPostalCode, ClaimType = ClaimTypes.PostalCode, ClaimTypeValue = "http://www.w3.org/2001/XMLSchema#string", EntityType = SPClaimEntityTypes.User });
            ZimbraClaimsMapped._Claims.Add(new ZimbraClaim { Name = "l", FieldId = ZimbraFieldId.HomeAddressCity, ClaimType = ClaimTypes.StateOrProvince, ClaimTypeValue = "http://www.w3.org/2001/XMLSchema#string", EntityType = SPClaimEntityTypes.User });
            ZimbraClaimsMapped._Claims.Add(new ZimbraClaim { Name = "co", FieldId = ZimbraFieldId.HomeAddressCountry, ClaimType = ClaimTypes.Country, ClaimTypeValue = "http://www.w3.org/2001/XMLSchema#string", EntityType = SPClaimEntityTypes.User });
            ZimbraClaimsMapped._Claims.Add(new ZimbraClaim { Name = "st", FieldId = ZimbraFieldId.HomeAddressStateOrProvince, ClaimType = ClaimTypes.StateOrProvince, ClaimTypeValue = "http://www.w3.org/2001/XMLSchema#string", EntityType = SPClaimEntityTypes.User });
            ZimbraClaimsMapped._Claims.Add(new ZimbraClaim { Name = "title", FieldId = ZimbraFieldId.JobTitle, EntityType = SPClaimEntityTypes.User, EntityDataKey = PeopleEditorEntityDataKeys.JobTitle });
            ZimbraClaimsMapped._Claims.Add(new ZimbraClaim { Name = "company", FieldId = ZimbraFieldId.Company, EntityType = SPClaimEntityTypes.User, EntityDataKey = PeopleEditorEntityDataKeys.Department });
        }
    }
}
