using Microsoft.SharePoint;
using Microsoft.SharePoint.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;

namespace ClubCloud.Provider
{
    public class ZimbraGroupEventReceiver : SPSecurityEventReceiver
    {
        internal static void CreateReceiverDefinitions(SPWeb web)
        {
            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                using (new SPMonitoredScope("Create GroupEventReceivers Zimbra"))
                {

                    SPEventReceiverDefinition GroupAdded = web.EventReceivers.Add();
                    GroupAdded.Name = "Zimbra Group Added";
                    GroupAdded.Type = SPEventReceiverType.GroupAdded;
                    GroupAdded.Assembly = Assembly.GetExecutingAssembly().FullName;
                    GroupAdded.Class = "ClubCloud.Provider.ZimbraGroupEventReceiver";
                    GroupAdded.Update();

                    SPEventReceiverDefinition GroupAdding = web.EventReceivers.Add();
                    GroupAdding.Name = "Zimbra Group Adding";
                    GroupAdding.Type = SPEventReceiverType.GroupAdding;
                    GroupAdding.Assembly = Assembly.GetExecutingAssembly().FullName;
                    GroupAdding.Class = "ClubCloud.Provider.ZimbraGroupEventReceiver";
                    GroupAdding.Update();

                    SPEventReceiverDefinition GroupDeleted = web.EventReceivers.Add();
                    GroupDeleted.Name = "Zimbra Group Deleted";
                    GroupDeleted.Type = SPEventReceiverType.GroupDeleted;
                    GroupDeleted.Assembly = Assembly.GetExecutingAssembly().FullName;
                    GroupDeleted.Class = "ClubCloud.Provider.ZimbraGroupEventReceiver";
                    GroupDeleted.Update();

                    SPEventReceiverDefinition GroupDeleting = web.EventReceivers.Add();
                    GroupDeleting.Name = "Zimbra Group Deleting";
                    GroupDeleting.Type = SPEventReceiverType.GroupDeleting;
                    GroupDeleting.Assembly = Assembly.GetExecutingAssembly().FullName;
                    GroupDeleting.Class = "ClubCloud.Provider.ZimbraGroupEventReceiver";
                    GroupDeleting.Update();

                    SPEventReceiverDefinition GroupUpdated = web.EventReceivers.Add();
                    GroupUpdated.Name = "Zimbra Group Updated";
                    GroupUpdated.Type = SPEventReceiverType.GroupUpdated;
                    GroupUpdated.Assembly = Assembly.GetExecutingAssembly().FullName;
                    GroupUpdated.Class = "ClubCloud.Provider.ZimbraGroupEventReceiver";
                    GroupUpdated.Update();

                    SPEventReceiverDefinition GroupUpdating = web.EventReceivers.Add();
                    GroupUpdating.Name = "Zimbra Group Updating";
                    GroupUpdating.Type = SPEventReceiverType.GroupUpdating;
                    GroupUpdating.Assembly = Assembly.GetExecutingAssembly().FullName;
                    GroupUpdating.Class = "ClubCloud.Provider.ZimbraGroupEventReceiver";
                    GroupUpdating.Update();

                    SPEventReceiverDefinition GroupUserAdded = web.EventReceivers.Add();
                    GroupUserAdded.Name = "Zimbra Group User Added";
                    GroupUserAdded.Type = SPEventReceiverType.GroupUserAdded;
                    GroupUserAdded.Assembly = Assembly.GetExecutingAssembly().FullName;
                    GroupUserAdded.Class = "ClubCloud.Provider.ZimbraGroupEventReceiver";
                    GroupUserAdded.Update();

                    SPEventReceiverDefinition GroupUserAdding = web.EventReceivers.Add();
                    GroupUserAdding.Name = "Zimbra Group User Adding";
                    GroupUserAdding.Type = SPEventReceiverType.GroupUserAdding;
                    GroupUserAdding.Assembly = Assembly.GetExecutingAssembly().FullName;
                    GroupUserAdding.Class = "ClubCloud.Provider.ZimbraGroupEventReceiver";
                    GroupUserAdding.Update();

                    SPEventReceiverDefinition GroupUserDeleted = web.EventReceivers.Add();
                    GroupUserDeleted.Name = "Zimbra Group User Deleted";
                    GroupUserDeleted.Type = SPEventReceiverType.GroupUserDeleted;
                    GroupUserDeleted.Assembly = Assembly.GetExecutingAssembly().FullName;
                    GroupUserDeleted.Class = "ClubCloud.Provider.ZimbraGroupEventReceiver";
                    GroupUserDeleted.Update();

                    SPEventReceiverDefinition GroupUserDeleting = web.EventReceivers.Add();
                    GroupUserDeleting.Name = "Zimbra Group User Deleting";
                    GroupUserDeleting.Type = SPEventReceiverType.GroupUserDeleting;
                    GroupUserDeleting.Assembly = Assembly.GetExecutingAssembly().FullName;
                    GroupUserDeleting.Class = "ClubCloud.Provider.ZimbraGroupEventReceiver";
                    GroupUserDeleting.Update();

                    web.Update();
                }
            });
        }

        internal static void RemoveReceiverDefinitions(SPWeb web)
        {
            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                using (new SPMonitoredScope("Remove GroupEventReceivers Zimbra"))
                {

                    foreach (SPEventReceiverDefinition definition in web.EventReceivers)
                    {
                        if (definition.Class == "ClubCloud.Provider.ZimbraGroupEventReceiver")
                        {
                            definition.Delete();
                        }
                    }
                    web.Update();
                }
            });
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="properties"></param>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="properties"></param>
        public override void GroupUserAdding(SPSecurityEventProperties properties)
        {
            base.GroupUserAdding(properties);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="properties"></param>
        public override void GroupUserDeleting(SPSecurityEventProperties properties)
        {
            base.GroupUserDeleting(properties);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="properties"></param>
        public override void GroupUserDeleted(SPSecurityEventProperties properties)
        {
            base.GroupUserDeleted(properties);
        }

        public override void GroupAdded(SPSecurityEventProperties properties)
        {
            base.GroupAdded(properties);
        }

        public override void GroupAdding(SPSecurityEventProperties properties)
        {
            base.GroupAdding(properties);
        }

        public override void GroupDeleted(SPSecurityEventProperties properties)
        {
            base.GroupDeleted(properties);
        }

        public override void GroupDeleting(SPSecurityEventProperties properties)
        {
            base.GroupDeleting(properties);
        }

        public override void GroupUpdated(SPSecurityEventProperties properties)
        {
            base.GroupUpdated(properties);
        }

        public override void GroupUpdating(SPSecurityEventProperties properties)
        {
            base.GroupUpdating(properties);
        }
    }
}
