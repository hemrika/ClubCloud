// <copyright file="NavigationEntry.EventReceiver.cs" company="Hemrika">
// Copyright Hemrika. All rights reserved.
// </copyright>
// <author>CLUBCLOUD\hemrika</author>
// <date>2015-08-25 16:33:44Z</date>
namespace ClubCloud.WebSite.Navigation
{
    using System;
    using System.Collections.Generic;
    using System.Security.Permissions;
    using System.Text;
    using Microsoft.SharePoint;
    using Microsoft.SharePoint.Security;

    /// <summary>
    /// TODO: Add comment for NavigationEntryEventReceivers
    /// </summary> 
    [SharePointPermission(SecurityAction.LinkDemand, ObjectModel = true)]
    [SharePointPermission(SecurityAction.InheritanceDemand, ObjectModel = true)]
    public class NavigationEntryEventReceivers : SPItemEventReceiver
    {
        /// <summary>
        /// TODO: Add comment for event ItemAdding in NavigationEntryEventReceivers
        /// </summary>
        /// <param name="properties">Contains event properties</param>
        public override void ItemAdding(SPItemEventProperties properties)
        {
            /*
            DisableEventFiring();
            SPListItem oItem = properties.ListItem;
            oItem["Body"] = "Body text maintained by the system.";
            oItem.Update();
            EnableEventFiring();
            */
        }

        /// <summary>
        /// TODO: Add comment for event ItemAdded in NavigationEntryEventReceivers
        /// </summary>
        /// <param name="properties">Contains event properties</param>
        public override void ItemAdded(SPItemEventProperties properties)
        {
            /*
            DisableEventFiring();
            SPListItem oItem = properties.ListItem;
            oItem["Body"] = "Body text maintained by the system.";
            oItem.Update();
            EnableEventFiring();
            */
        }
        /// <summary>
        /// TODO: Add comment for event ItemUpdating in NavigationEntryEventReceivers
        /// </summary>
        /// <param name="properties">Contains event properties</param>
        public override void ItemUpdating(SPItemEventProperties properties)
        {
            /*
            DisableEventFiring();
            SPListItem oItem = properties.ListItem;
            oItem["Body"] = "Body text maintained by the system.";
            oItem.Update();
            EnableEventFiring();
            */
        }
        /// <summary>
        /// TODO: Add comment for event ItemUpdated in NavigationEntryEventReceivers
        /// </summary>
        /// <param name="properties">Contains event properties</param>
        public override void ItemUpdated(SPItemEventProperties properties)
        {
            /*
            DisableEventFiring();
            SPListItem oItem = properties.ListItem;
            oItem["Body"] = "Body text maintained by the system.";
            oItem.Update();
            EnableEventFiring();
            */
        }
        /// <summary>
        /// TODO: Add comment for event ItemDeleting in NavigationEntryEventReceivers
        /// </summary>
        /// <param name="properties">Contains event properties</param>
        public override void ItemDeleting(SPItemEventProperties properties)
        {
            /*
            properties.Cancel = true;
            properties.ErrorMessage = "Deleting is not supported.";
            */
        }
        /// <summary>
        /// TODO: Add comment for event ItemDeleted in NavigationEntryEventReceivers
        /// </summary>
        /// <param name="properties">Contains event properties</param>
        public override void ItemDeleted(SPItemEventProperties properties)
        {
            /*
            properties.Cancel = true;
            properties.ErrorMessage = "Deleting is not supported.";
            */
        }
    }
}
