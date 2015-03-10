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
    using System.Linq;
    using System.IO;
    using System.IO.Compression;
    using ClubCloud.Model;
    using ClubCloud.Store.Package;

    /// <summary>
    /// The Database Settings Page
    /// </summary>
    public partial class ManagePackage : BaseAdminPage
    {
        #region Fields

        #endregion

        #region Properties

        /*
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
        */
        #endregion

        #region Page Events

        /// <summary>
        /// Page_Load event.
        /// </summary>
        /// <param name="sender">The Sender.</param>
        /// <param name="e">The EventArgs.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            if (this.ServiceApplication == null)
            {
                SPUtility.TransferToErrorPage(HttpContext.GetGlobalResourceObject("ClubCloud.Service.ServiceAdminResources", "ErrorNoServiceApplication", CultureInfo.CurrentCulture).ToString());
            }
            if (!Page.IsPostBack)
            {
                //List<ClubCloud.Model.ApplicationInfo> applications = ServiceClient.GetApplications();
                //gvw_packages.DataSource = applications;
                //gvw_packages.DataBind();
            }
            */
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

                var name = fup_package.PostedFile.FileName.Split('\\').Last();

                string[] parts = name.Split('_');
                string applicationName = parts[0];
                string verion = parts[1];
                string cpu = parts[2];
                
                ClubCloud.Model.ApplicationInfo applicationInfo = ServiceClient.GetApplicationInfoByName(applicationName);
                
                if(applicationInfo == null)
                {
                    applicationInfo = new Model.ApplicationInfo { ApplicationName = applicationName, MajorVersion = verion, CreationDate = DateTime.Now, OperationDate = DateTime.Now, Status = ApplicationStatus.Published };
                }
                else
                {
                    applicationInfo.MajorVersion = verion;
                    applicationInfo.OperationDate = DateTime.Now;
                }

                Stream uploadstream = fup_package.PostedFile.InputStream;
                fup_package.PostedFile.InputStream.Seek(0, SeekOrigin.Begin);
                byte[] fileData = new byte[fup_package.PostedFile.ContentLength];
                uploadstream.Read(fileData, 0, fup_package.PostedFile.ContentLength);

                byte[] package = null;
                byte[] certificate = null;
                byte[] symbols = null;

                ApplicationVersion applicationVersion = new ApplicationVersion();
                ApplicationProcessorArchitecture applicationProcessorArchitecture = new ApplicationProcessorArchitecture();

                using (ZipArchive archive = new ZipArchive(uploadstream, ZipArchiveMode.Read))
                {
                    foreach (ZipArchiveEntry entry in archive.Entries)
                    {
                        byte[] buffer = null;
                        using (BinaryReader reader = new BinaryReader(entry.Open()))
                        {
                            buffer = reader.ReadBytes((int)entry.Length);
                        }

                        if (entry.FullName.EndsWith("appx"))
                        {
                            package = buffer;
                            PackageAnalyzeResult result = PackageAnalyzer.GetPackageInfo(entry.Open());
                            applicationVersion = result.ApplicationVersion;
                            applicationProcessorArchitecture = result.ApplicationProcessorArchitecture;
                        }

                        if (entry.FullName.EndsWith("cer"))
                        {
                            certificate = buffer;
                        }

                        if (entry.FullName.EndsWith("appxsym"))
                        {
                            symbols = buffer;

                        }
                    }
                }
                applicationProcessorArchitecture.Certificate = certificate;
                applicationProcessorArchitecture.Package = package;
                applicationProcessorArchitecture.Symbols = symbols;

                //applicationVersion.ApplicationProcessorArchitectures.Add(applicationProcessorArchitecture);
                //applicationInfo.ApplicationVersions.Add(applicationVersion);

                applicationInfo = ServiceClient.SetApplicationInfo(applicationInfo);
                applicationVersion.ApplicationInfoId = applicationInfo.Id;
                applicationVersion = ServiceClient.SetApplicationVersion(applicationInfo.Id, applicationVersion);
                applicationProcessorArchitecture.ApplicationVersionId = applicationVersion.Id;
                applicationProcessorArchitecture = ServiceClient.SetApplicationProcessorArchitecture(applicationVersion.Id, applicationProcessorArchitecture);

                operation.End("/_admin/ClubCloud.Service/ManagePackage.aspx");//string.Format(CultureInfo.InvariantCulture, "/_admin/ClubCloud.Service/ManageApplication.aspx?id={0}", SPHttpUtility.UrlKeyValueEncode(this.ServiceApplication.Id)));
            }
        }

        /// <summary>
        /// Click event.
        /// </summary>
        /// <param name="sender">The Sender.</param>
        /// <param name="e">The EventArgs.</param>
        protected void ButtonNew_Click(object sender, EventArgs e)
        {
            Response.Redirect(string.Format(CultureInfo.InvariantCulture, "ManagePackage.aspx?id={0}", SPHttpUtility.UrlKeyValueEncode(this.ServiceApplication.Id)));
        }

        #endregion

        #region Methods

        #endregion
    }
}
