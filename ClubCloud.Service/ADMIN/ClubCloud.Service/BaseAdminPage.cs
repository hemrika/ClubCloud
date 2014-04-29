﻿//-----------------------------------------------------------------------
// <copyright file="BaseAdminPage.cs" company="">
// Copyright © 
// </copyright>
//-----------------------------------------------------------------------
namespace ClubCloud.Service.Administration
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Web;
    using Microsoft.SharePoint.ApplicationPages;
    using Microsoft.SharePoint.Utilities;
    using ClubCloud.Service;

    /// <summary>
    /// Base class for administrative pages to inherit from.
    /// </summary>
    public class BaseAdminPage : GlobalAdminPageBase
    {
        #region Fields

        /// <summary>
        /// The current service application to manage.
        /// </summary>
        private ClubCloudServiceApplication serviceApplication;

        #endregion

        #region Properties

        /// <summary>
        /// Gets the current service application to manage from the query string.
        /// </summary>
        internal ClubCloudServiceApplication ServiceApplication
        {
            get
            {
                if (this.serviceApplication == null)
                {
                    string serviceApplicationId = this.Request.QueryString["id"];

                    if (string.IsNullOrEmpty(serviceApplicationId))
                    {
                        SPUtility.TransferToErrorPage(HttpContext.GetGlobalResourceObject("ClubCloud.Service.ServiceAdminResources", "ErrorNoServiceApplicationId", CultureInfo.CurrentCulture).ToString());
                    }

                    if (!GlobalAdminPageBase.IsValidGuid(serviceApplicationId))
                    {
                        SPUtility.TransferToErrorPage(HttpContext.GetGlobalResourceObject("ClubCloud.Service.ServiceAdminResources", "ErrorInvalidServiceApplicationId", CultureInfo.CurrentCulture).ToString());
                    }

                    var service = ClubCloudService.GetOrCreateService();
                    this.serviceApplication = service.Applications[new Guid(serviceApplicationId)] as ClubCloudServiceApplication;
                }

                return this.serviceApplication;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Generates a link to an administrative page.
        /// </summary>
        /// <param name="pageName">The name of the page.</param>
        /// <returns>A link to an administrative page.</returns>
        protected string GenerateLink(string pageName)
        {
            string template = "{0}?id={1}";

            return string.Format(CultureInfo.InvariantCulture, template, pageName, this.serviceApplication.Id);
        }

        /// <summary>
        /// Generates a link to a modal administrative page.
        /// </summary>
        /// <param name="pageName">The name of the page.</param>
        /// <returns>A link to an administrative page.</returns>
        protected string GeneratePopupLink(string pageName)
        {
            string template = "SP.UI.ModalDialog.showModalDialog({{url:'{0}?id={1}'}});return false;";

            return string.Format(CultureInfo.InvariantCulture, template, pageName, this.serviceApplication.Id);
        }

        #endregion
    }
}