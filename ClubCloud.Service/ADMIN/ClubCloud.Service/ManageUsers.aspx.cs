//-----------------------------------------------------------------------
// <copyright file="DatabaseSettings.aspx.cs" company="">
// Copyright © 
// </copyright>
//-----------------------------------------------------------------------
namespace ClubCloud.Service.Administration
{
    using System;
    using System.Globalization;
    using System.Web;
    using System.Web.UI.WebControls;
    using Microsoft.SharePoint;
    using Microsoft.SharePoint.Administration;
    using Microsoft.SharePoint.ApplicationPages;
    using Microsoft.SharePoint.Utilities;
    using Microsoft.SharePoint.WebControls;
    using ClubCloud.Service;
    using System.Web.UI;
    using System.Collections.Generic;

    /// <summary>
    /// The Database Settings Page
    /// </summary>
    public partial class ManageUsersPage : BaseAdminPage
    {
        #region Fields

        #endregion

        #region Properties

        /// <summary>
        /// Gets the required query string parameters.
        /// </summary>
        protected override string[] RequiredPageParameters
        {
            get
            {
                return new string[] { "id" };
            }
        }

        #endregion

        #region Page Events

        /// <summary>
        /// Page_Load event.
        /// </summary>
        /// <param name="sender">The Sender.</param>
        /// <param name="e">The EventArgs.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.ServiceApplication == null)
            {
                SPUtility.TransferToErrorPage(HttpContext.GetGlobalResourceObject("ClubCloud.Service.ServiceAdminResources", "ErrorNoServiceApplication", CultureInfo.CurrentCulture).ToString());
            }
            if (!Page.IsPostBack)
            {
                List<ClubCloud.Model.ClubCloud_Functionaris> functionarissen = ServiceClient.GetFunctionarissen();
                gvw_users.DataSource = functionarissen;
                gvw_users.DataBind();
            }
        }

        /// <summary>
        /// Page_Error event.
        /// </summary>
        /// <param name="sender">The Sender.</param>
        /// <param name="e">The EventArgs.</param>
        protected void Page_Error(object sender, EventArgs e)
        {
            Exception ex = Server.GetLastError();
            if (ex != null)
            {
            }
        }

        #endregion

        #region Control Events

        /// <summary>
        /// Click event.
        /// </summary>
        /// <param name="sender">The Sender.</param>
        /// <param name="e">The EventArgs.</param>
        protected void ButtonOk_Click(object sender, EventArgs e)
        {
            // Validate
            this.Validate();

            if (!this.IsValid)
            {
                return;
            }

            // We are valid
            // Register the database
            using (SPLongOperation operation = new SPLongOperation(this))
            {
                operation.LeadingHTML = HttpContext.GetGlobalResourceObject("ClubCloud.Service.ServiceAdminResources", "UsersSettingsCreateOperationLeadingHtml", CultureInfo.CurrentCulture).ToString();
                operation.TrailingHTML = HttpContext.GetGlobalResourceObject("ClubCloud.Service.ServiceAdminResources", "UsersSettingsCreateOperationTrailingHtml", CultureInfo.CurrentCulture).ToString();
                operation.Begin();

                operation.End(string.Format(CultureInfo.InvariantCulture, "/_admin/ClubCloud.Service/ManageApplication.aspx?id={0}", SPHttpUtility.UrlKeyValueEncode(this.ServiceApplication.Id)));
            }
        }

        /// <summary>
        /// Click event.
        /// </summary>
        /// <param name="sender">The Sender.</param>
        /// <param name="e">The EventArgs.</param>
        protected void ButtonNew_Click(object sender, EventArgs e)
        {
            Response.Redirect(string.Format(CultureInfo.InvariantCulture, "CreateUser.aspx?id={0}", SPHttpUtility.UrlKeyValueEncode(this.ServiceApplication.Id)));
        }

        #endregion

        #region Methods

        #endregion
    }
}
