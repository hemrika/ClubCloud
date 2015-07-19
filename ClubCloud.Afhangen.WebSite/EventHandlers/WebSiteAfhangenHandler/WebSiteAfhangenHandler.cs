// <copyright file="WebSiteAboutHandler.cs" company="Hemrika">
// Copyright Hemrika. All rights reserved.
// </copyright>
// <author>MARKETING\Administrator</author>
// <date>2012-01-17 12:50:01Z</date>
namespace ClubCloud.Afhangen.WebSite
{
    using System;
    using System.Collections.Generic;
    using System.Security.Permissions;
    using System.Text;
    using Microsoft.SharePoint;
    using Microsoft.SharePoint.Security;
    using Microsoft.SharePoint.Administration;
    using Microsoft.SharePoint.Utilities;

    /// <summary>
    /// TODO: Add comment for WebSiteAboutHandler
    /// </summary> 
    public class WebSiteAboutHandler : SPWebEventReceiver
    {
        /// <summary>
        /// TODO: Add comment for event WebProvisioned in WebSiteAfhangenHandler 
        /// </summary>
        /// <param name="properties">Contains list event properties</param>
        [SharePointPermission(SecurityAction.LinkDemand, ObjectModel = true)]
        public override void WebProvisioned(SPWebEventProperties properties)
        {
            try
            {
                if (properties.Web.WebTemplate.ToLower() == "clubcloudafhangen")
                {
                    properties.Web.AllowUnsafeUpdates = true;
                    properties.Web.AnonymousState = SPWeb.WebAnonymousState.Enabled;
                    SPFolder rootFolder = properties.Web.RootFolder;
                    rootFolder.WelcomePage = "index.html";
                    rootFolder.Update();
                    properties.Web.Update();
                    properties.Web.AllowUnsafeUpdates = false;
                }
            }
            catch (Exception ex)
            {
                SPDiagnosticsService.Local.WriteTrace(0, new SPDiagnosticsCategory(ex.Source, TraceSeverity.High, EventSeverity.Error), TraceSeverity.High, ex.Message, ex.Data);
                //ex.ToString();
            }

            SPUtility.ValidateFormDigest();
        }

    }
}

