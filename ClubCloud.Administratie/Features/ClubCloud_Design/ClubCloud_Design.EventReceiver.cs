// <copyright file="ClubCloud_ClubCloudDesign.EventReceiver.cs" company="Hemrika">
// Copyright Hemrika. All rights reserved.
// </copyright>
// <author>CLUBCLOUD\hemrika</author>
// <date>2015-05-07 08:50:30Z</date>
namespace ClubCloud.Administratie
{
    using System;
    using System.Collections.Generic;
    using System.Security.Permissions;
    using System.Text;
    using Microsoft.SharePoint;
    using Microsoft.SharePoint.Security;

    /// <summary>
    /// TODO: Add comment to ClubCloudDesignEventReceiver
    /// </summary>
    [SharePointPermission(SecurityAction.InheritanceDemand, ObjectModel = true)]
    public class ClubCloudDesignEventReceiver : SPFeatureReceiver
    {
        /// <summary>
        /// TODO: Add comment to describe the actions after feature activation
        /// </summary>
        /// <param name="properties">Properties of the feature</param>
        [SharePointPermission(SecurityAction.LinkDemand, ObjectModel = true)]
        public override void FeatureActivated(SPFeatureReceiverProperties properties)
        {
            var site = (SPSite)properties.Feature.Parent;
            site.RootWeb.MasterUrl = site.RootWeb.ServerRelativeUrl + "_catalogs/masterpage/ClubCloud.master";
            site.RootWeb.CustomMasterUrl = site.RootWeb.ServerRelativeUrl + "_catalogs/masterpage/ClubCloud.master";
            site.RootWeb.Update();
        }

        /// <summary>
        /// TODO: Add comment to describe the actions during feature deactivation
        /// </summary>
        /// <param name="properties">Properties of the feature</param>
        [SharePointPermission(SecurityAction.LinkDemand, ObjectModel = true)]
        public override void FeatureDeactivating(SPFeatureReceiverProperties properties)
        {
            var site = (SPSite)properties.Feature.Parent;
            site.RootWeb.MasterUrl = site.RootWeb.ServerRelativeUrl + "_catalogs/masterpage/v4.master";
            site.RootWeb.CustomMasterUrl = site.RootWeb.ServerRelativeUrl + "_catalogs/masterpage/v4.master";
            site.RootWeb.Update();
        }

        /// <summary>
        /// TODO: Add comment to describe the actions after feature installation
        /// </summary>
        /// <param name="properties">Properties of the feature</param>
        [SharePointPermission(SecurityAction.LinkDemand, ObjectModel = true)]
        public override void FeatureInstalled(SPFeatureReceiverProperties properties)
        {
            ////TODO: place receiver code here or remove method
        }

        /// <summary>
        /// TODO: Add comment to describe the actions during feature uninstalling
        /// </summary>
        /// <param name="properties">Properties of the feature</param>
        [SharePointPermission(SecurityAction.LinkDemand, ObjectModel = true)]
        public override void FeatureUninstalling(SPFeatureReceiverProperties properties)
        {
            ////TODO: place receiver code here or remove method
        }

        /// <summary>
        /// TODO: Add comment to describe the actions during feature upgrading
        /// </summary>
        /// <param name="properties">Properties of the feature</param>
        /// <param name="upgradeActionName">The name of the custom upgrade action to execute. The value can be null if the override of this method implements only one upgrade action.</param>
        /// <param name="parameters">Parameter names and values for the custom action</param>
        [SharePointPermission(SecurityAction.LinkDemand, ObjectModel = true)]
        public override void FeatureUpgrading(SPFeatureReceiverProperties properties, string upgradeActionName, System.Collections.Generic.IDictionary<string, string> parameters)
        {
            ////TODO: place receiver code here or remove method
        }
    }
}

