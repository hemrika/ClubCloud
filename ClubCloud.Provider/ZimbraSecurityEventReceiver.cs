using Microsoft.SharePoint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;

namespace ClubCloud.Provider
{
    public class ZimbraSecurityEventReceiver : SPSecurityEventReceiver
    {
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

        public override void GroupUserAdded(SPSecurityEventProperties properties)
        {
            SPEventReceiverType eventtype = properties.EventType;
            //if (properties.UserLoginName.Contains("zimbramembershipprovider") || properties.UserLoginName.Contains("zimbraroleprovider"))
            //{


            using (SPSite site = new SPSite(properties.SiteId))
            {
                SPWeb web = site.OpenWeb(properties.WebId);
                SPList users = web.GetCatalog(SPListTemplateType.UserInformation);
                if (users != null)
                {
                    SPListItem luser = users.GetItemById(properties.GroupUserId);
                    string value = luser[ZimbraFieldId.Name] as string;
                    if (!string.IsNullOrWhiteSpace(value))
                    {
                        try
                        {
                            if (value.Contains("zimbramembershipprovider") || value.Contains("zimbraroleprovider"))
                            {
                                //0#.f|zimbramembershipprovider|12073385
                                string identifier = value.Split('|').Last();
                                MembershipUser user;
                                if (!string.IsNullOrWhiteSpace(identifier))
                                {
                                    user = Provider.GetUser(identifier, true);
                                }
                                else
                                {
                                    user = Provider.GetUser(value, true);
                                }
                                ZimbraMembershipUser zuser = null;
                                if (user != null && user.GetType() == typeof(ZimbraMembershipUser))
                                {
                                    zuser = user as ZimbraMembershipUser;
                                }

                                if (zuser != null)
                                {
                                    luser[ZimbraFieldId.Title] = zuser.displayName;
                                    luser[ZimbraFieldId.SipAddress] = zuser.Email;
                                    luser.Update();
                                }
                            }
                        }
                        catch { }
                    }
                }
                /*
                string identifier = properties.UserLoginName.Split('|').Last();
                MembershipUser user;
                if (!string.IsNullOrWhiteSpace(identifier))
                {
                    user = Provider.GetUser(identifier, true);
                }
                else
                {
                    user = Provider.GetUser(properties.UserLoginName, true);
                }

                ZimbraMembershipUser zuser = null;
                if (user != null && user.GetType() == typeof(ZimbraMembershipUser))
                {
                    zuser = user as ZimbraMembershipUser;
                }

                if (zuser != null)
                {

                }
                */
            }
        
            int id = properties.GroupUserId;
            string name = properties.GroupUserLoginName;
            SPUserToken token = properties.OriginatingUserToken;
            string displayname = properties.UserDisplayName;
            string loginname = properties.UserLoginName;
            //base.GroupUserAdded(properties);
        }

        public override void GroupUserAdding(SPSecurityEventProperties properties)
        {
            base.GroupUserAdding(properties);
        }

        public override void GroupUserDeleting(SPSecurityEventProperties properties)
        {
            base.GroupUserDeleting(properties);
        }

        public override void GroupUserDeleted(SPSecurityEventProperties properties)
        {
            base.GroupUserDeleted(properties);
        }
    }
}
