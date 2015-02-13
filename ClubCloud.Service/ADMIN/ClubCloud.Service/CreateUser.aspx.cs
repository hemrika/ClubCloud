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
    public partial class CreateUserPage : BaseAdminPage
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

            if (!this.IsPostBack)
            {
                List<ClubCloud.Model.ClubCloud_Vereniging> verenigingen = ServiceClient.GetVerenigingen();
                verenigingen.Insert(0,new Model.ClubCloud_Vereniging { Id = Guid.Empty, Naam = "< Selecteer Vereniging >" });
                ddl_vereniging.DataTextField = "Naam";
                ddl_vereniging.DataValueField = "Id";
                ddl_vereniging.DataSource = verenigingen;
                ddl_vereniging.DataBind();
                ddl_vereniging.SelectedValue = Guid.Empty.ToString();
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

                //TODO Save
                string nummer = tbx_bondsnummer.Text.Trim();
                string naam = tbx_naam.Text.Trim();
                string email = tbx_email.Text.Trim();
                string vereniging = ddl_vereniging.SelectedItem.Value;
                ClubCloud.Model.ClubCloud_Gebruiker gebruiker = new Model.ClubCloud_Gebruiker { Bondsnummer = nummer, Volledigenaam = naam, EmailKNLTB = email, VerenigingId = Guid.Parse(vereniging) };

                operation.End(string.Format(CultureInfo.InvariantCulture, "/_admin/ClubCloud.Service/ManageUsers.aspx?id={0}", SPHttpUtility.UrlKeyValueEncode(this.ServiceApplication.Id)));
            }
        }

        /// <summary>
        /// Click event.
        /// </summary>
        /// <param name="sender">The Sender.</param>
        /// <param name="e">The EventArgs.</param>
        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect(string.Format(CultureInfo.InvariantCulture, "ManageUsers.aspx?id={0}", SPHttpUtility.UrlKeyValueEncode(this.ServiceApplication.Id)));
        }

        #endregion

        #region Methods

        #endregion
    }
}
