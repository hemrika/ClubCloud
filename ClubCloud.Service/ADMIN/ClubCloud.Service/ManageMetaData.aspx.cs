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
    using ClubCloud.Model;
    using System.Collections.Generic;

    /// <summary>
    /// The Database Settings Page
    /// </summary>
    public partial class ManageMetaDataPage : BaseAdminPage
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
        protected void ButtonTrigger_Click(object sender, EventArgs e)
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

                try
                {

                    ServiceClient.TriggerMetaData("12073385", true);
                }
                catch { };

                operation.End(string.Format(CultureInfo.InvariantCulture, "/_admin/ClubCloud.Service/ManageMetaData.aspx?id={0}", SPHttpUtility.UrlKeyValueEncode(this.ServiceApplication.Id)));
            }
        }

        /// <summary>
        /// Click event.
        /// </summary>
        /// <param name="sender">The Sender.</param>
        /// <param name="e">The EventArgs.</param>
        protected void ButtonMetaData_Click(object sender, EventArgs e)
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

                try
                {
                    ServiceClient.NationaliteitenUpdate("12073385", true);
                }
                catch { }

                try
                {
                    ServiceClient.LandenUpdate("12073385", true);
                }
                catch { }

                try
                {
                    ServiceClient.BouwaardenUpdate("12073385", true);
                }
                catch { }
                 
                try
                {
                    ServiceClient.LidmaatschapSoortenUpdate("12073385", true);
                }
                catch { }

                try
                {
                    ServiceClient.ToplagenUpdate("12073385", true);
                }
                catch { }

                try
                {
                    ServiceClient.BaantypesUpdate("12073385", true);
                }
                catch { }

                try
                {
                    ServiceClient.BaansoortenUpdate("12073385", true);
                }
                catch { }

                try
                {
                    ServiceClient.RechtsvormenUpdate("12073385", true);
                }
                catch { }
                
                try
                {
                    ServiceClient.FunctiesUpdate("12073385", true);
                }
                catch { }

                try
                {
                    ServiceClient.RegiosUpdate("12073385", true);
                }
                catch { }

                try
                {
                    ServiceClient.DistrictenUpdate("12073385", true);
                }
                catch { }

                operation.End(string.Format(CultureInfo.InvariantCulture, "/_admin/ClubCloud.Service/ManageMetaData.aspx?id={0}", SPHttpUtility.UrlKeyValueEncode(this.ServiceApplication.Id)));
            }
        }

        /// <summary>
        /// Click event.
        /// </summary>
        /// <param name="sender">The Sender.</param>
        /// <param name="e">The EventArgs.</param>
        protected void ButtonVerenigingen_Click(object sender, EventArgs e)
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


                int pageNum = 1;
                bool moreRecords = true;

                while (moreRecords)
                {
                    try
                    {
                        moreRecords = ServiceClient.AccommodatiesUpdate("12073385", pageNum, true);
                        pageNum++;
                    }
                    catch (Exception)
                    {
                        moreRecords = true;
                    }
                }

                try
                {
                    
                }
                catch { }

                pageNum = 1;
                moreRecords = true;
                while (moreRecords)
                {
                    try
                    {

                        moreRecords = ServiceClient.VerenigingenUpdate("12073385", pageNum, true);
                        pageNum++;
                    }
                    catch (Exception)
                    {
                        moreRecords = true;
                    }
                }

                try
                {
                    ServiceClient.BestuursOrganenUpdate("12073385", false);
                }
                catch { }

                operation.End(string.Format(CultureInfo.InvariantCulture, "/_admin/ClubCloud.Service/ManageMetaData.aspx?id={0}", SPHttpUtility.UrlKeyValueEncode(this.ServiceApplication.Id)));
            }
        }

        protected void ButtonGebruikers_Click(object sender, EventArgs e)
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

                string nummer = tbx_verenigingsnummer.Text;
                if (!string.IsNullOrWhiteSpace(nummer))
                {
                    int pageNum = 1;
                    bool moreRecords = true;
                    while (moreRecords)
                    {
                        try
                        {

                            moreRecords = ServiceClient.GebruikersUpdate("12073385", nummer, pageNum, false);
                            pageNum++;
                        }
                        catch (Exception)
                        {
                            moreRecords = true;
                        }
                    }

                    try
                    {
                        ClubCloud_Vereniging vereniging = ServiceClient.GetVerenigingByNummer("12073385", nummer, false);
                        ServiceClient.LidmaatschappenUpdate("12073385", vereniging.Id, true);
                    }
                    catch { }
                }

                operation.End(string.Format(CultureInfo.InvariantCulture, "/_admin/ClubCloud.Service/ManageMetaData.aspx?id={0}", SPHttpUtility.UrlKeyValueEncode(this.ServiceApplication.Id)));
            }
        }

        /// <summary>
        /// Click event.
        /// </summary>
        /// <param name="sender">The Sender.</param>
        /// <param name="e">The EventArgs.</param>
        protected void ButtonBanen_Click(object sender, EventArgs e)
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

                try
                {
                    ServiceClient.BaanBlokkenUpdate("12073385", true);
                }
                catch { }

                try
                {
                    ServiceClient.BanenSpeciaalUpdate("12073385", true);
                }
                catch { }

                try
                {
                    ServiceClient.BanenUpdate("12073385", true);
                }
                catch { }

                operation.End(string.Format(CultureInfo.InvariantCulture, "/_admin/ClubCloud.Service/ManageMetaData.aspx?id={0}", SPHttpUtility.UrlKeyValueEncode(this.ServiceApplication.Id)));
            }
        }

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

        #endregion

        #region Methods

        #endregion
    }
}
