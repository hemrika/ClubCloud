using Microsoft.SharePoint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;

namespace ClubCloud.Provider
{
    public class ZimbraRoleEventReceiver : SPSecurityEventReceiver
    {
        internal static void CreateReceiverDefinitions(SPWeb web)
        {
            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                SPEventReceiverDefinition RoleAssignmentAdded = web.EventReceivers.Add();
                RoleAssignmentAdded.Name = "Zimbra RoleAssignment Added";
                RoleAssignmentAdded.Type = SPEventReceiverType.RoleAssignmentAdded;
                RoleAssignmentAdded.Assembly = Assembly.GetExecutingAssembly().FullName;
                RoleAssignmentAdded.Class = "ClubCloud.Provider.ZimbraRoleEventReceiver";
                RoleAssignmentAdded.Update();

                SPEventReceiverDefinition RoleAssignmentAdding = web.EventReceivers.Add();
                RoleAssignmentAdding.Name = "Zimbra RoleAssignment Adding";
                RoleAssignmentAdding.Type = SPEventReceiverType.RoleAssignmentAdding;
                RoleAssignmentAdding.Assembly = Assembly.GetExecutingAssembly().FullName;
                RoleAssignmentAdding.Class = "ClubCloud.Provider.ZimbraRoleEventReceiver";
                RoleAssignmentAdding.Update();

                SPEventReceiverDefinition RoleAssignmentDeleted = web.EventReceivers.Add();
                RoleAssignmentDeleted.Name = "Zimbra RoleAssignment Deleted";
                RoleAssignmentDeleted.Type = SPEventReceiverType.RoleAssignmentDeleted;
                RoleAssignmentDeleted.Assembly = Assembly.GetExecutingAssembly().FullName;
                RoleAssignmentDeleted.Class = "ClubCloud.Provider.ZimbraRoleEventReceiver";
                RoleAssignmentDeleted.Update();

                SPEventReceiverDefinition RoleAssignmentDeleting = web.EventReceivers.Add();
                RoleAssignmentDeleting.Name = "Zimbra RoleAssignment Deleting";
                RoleAssignmentDeleting.Type = SPEventReceiverType.RoleAssignmentDeleting;
                RoleAssignmentDeleting.Assembly = Assembly.GetExecutingAssembly().FullName;
                RoleAssignmentDeleting.Class = "ClubCloud.Provider.ZimbraRoleEventReceiver";
                RoleAssignmentDeleting.Update();

                SPEventReceiverDefinition RoleDefinitionAdded = web.EventReceivers.Add();
                RoleDefinitionAdded.Name = "Zimbra RoleDefinition Added";
                RoleDefinitionAdded.Type = SPEventReceiverType.RoleDefinitionAdded;
                RoleDefinitionAdded.Assembly = Assembly.GetExecutingAssembly().FullName;
                RoleDefinitionAdded.Class = "ClubCloud.Provider.ZimbraRoleEventReceiver";
                RoleDefinitionAdded.Update();

                SPEventReceiverDefinition RoleDefinitionAdding = web.EventReceivers.Add();
                RoleDefinitionAdding.Name = "Zimbra RoleDefinition Adding";
                RoleDefinitionAdding.Type = SPEventReceiverType.RoleDefinitionAdding;
                RoleDefinitionAdding.Assembly = Assembly.GetExecutingAssembly().FullName;
                RoleDefinitionAdding.Class = "ClubCloud.Provider.ZimbraRoleEventReceiver";
                RoleDefinitionAdding.Update();

                SPEventReceiverDefinition RoleDefinitionDeleted = web.EventReceivers.Add();
                RoleDefinitionDeleted.Name = "Zimbra RoleDefinition Deleted";
                RoleDefinitionDeleted.Type = SPEventReceiverType.RoleDefinitionDeleted;
                RoleDefinitionDeleted.Assembly = Assembly.GetExecutingAssembly().FullName;
                RoleDefinitionDeleted.Class = "ClubCloud.Provider.ZimbraRoleEventReceiver";
                RoleDefinitionDeleted.Update();

                SPEventReceiverDefinition RoleDefinitionDeleting = web.EventReceivers.Add();
                RoleDefinitionDeleting.Name = "Zimbra RoleDefinition Deleting";
                RoleDefinitionDeleting.Type = SPEventReceiverType.RoleDefinitionDeleting;
                RoleDefinitionDeleting.Assembly = Assembly.GetExecutingAssembly().FullName;
                RoleDefinitionDeleting.Class = "ClubCloud.Provider.ZimbraRoleEventReceiver";
                RoleDefinitionDeleting.Update();

                SPEventReceiverDefinition RoleDefinitionUpdated = web.EventReceivers.Add();
                RoleDefinitionUpdated.Name = "Zimbra RoleDefinition Updated";
                RoleDefinitionUpdated.Type = SPEventReceiverType.RoleDefinitionUpdated;
                RoleDefinitionUpdated.Assembly = Assembly.GetExecutingAssembly().FullName;
                RoleDefinitionUpdated.Class = "ClubCloud.Provider.ZimbraRoleEventReceiver";
                RoleDefinitionUpdated.Update();

                SPEventReceiverDefinition RoleDefinitionUpdating = web.EventReceivers.Add();
                RoleDefinitionUpdating.Name = "Zimbra RoleDefinition Updating";
                RoleDefinitionUpdating.Type = SPEventReceiverType.RoleDefinitionUpdating;
                RoleDefinitionUpdating.Assembly = Assembly.GetExecutingAssembly().FullName;
                RoleDefinitionUpdating.Class = "ClubCloud.Provider.ZimbraRoleEventReceiver";
                RoleDefinitionUpdating.Update();

                web.Update();
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

        public override void RoleAssignmentAdded(SPSecurityEventProperties properties)
        {
            base.RoleAssignmentAdded(properties);
        }

        public override void RoleAssignmentAdding(SPSecurityEventProperties properties)
        {
            base.RoleAssignmentAdding(properties);
        }

        public override void RoleAssignmentDeleted(SPSecurityEventProperties properties)
        {
            base.RoleAssignmentDeleted(properties);
        }

        public override void RoleAssignmentDeleting(SPSecurityEventProperties properties)
        {
            base.RoleAssignmentDeleting(properties);
        }

        public override void RoleDefinitionAdded(SPSecurityEventProperties properties)
        {
            base.RoleDefinitionAdded(properties);
        }

        public override void RoleDefinitionAdding(SPSecurityEventProperties properties)
        {
            base.RoleDefinitionAdding(properties);
        }

        public override void RoleDefinitionDeleted(SPSecurityEventProperties properties)
        {
            base.RoleDefinitionDeleted(properties);
        }

        public override void RoleDefinitionDeleting(SPSecurityEventProperties properties)
        {
            base.RoleDefinitionDeleting(properties);
        }

        public override void RoleDefinitionUpdated(SPSecurityEventProperties properties)
        {
            base.RoleDefinitionUpdated(properties);
        }

        public override void RoleDefinitionUpdating(SPSecurityEventProperties properties)
        {
            base.RoleDefinitionUpdating(properties);
        }
    }
}
