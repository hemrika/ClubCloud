using ClubCloud.Zimbra.Service;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml;
using System.Xml.Linq;
using System.ComponentModel;

namespace ClubCloud.Internet
{
    public partial class MailingUserControl : UserControl, IWebPart
    {
        private static ZimbraConfigurationSection zimbraconfiguration = null;

        internal ZimbraConfigurationSection ZimbraConfiguration
        {
            get
            {
                try
                {
                    zimbraconfiguration = (ZimbraConfigurationSection)ConfigurationManager.GetSection("Zimbra/Configuration");
                }
                catch (Exception ex)
                {
                    Logger.WriteLog(Logger.Category.Unexpected, ex.Source, ex.Message);
                    string messsage = ex.Message;
                }

                if (zimbraconfiguration == null)
                {
                    zimbraconfiguration = new ZimbraConfigurationSection();
                }
                return zimbraconfiguration;
            }
        }

        private ClubCloud.Service.ClubCloudServiceClient _client = null;

        public ClubCloud.Service.ClubCloudServiceClient Client
        {
            get
            {
                if (_client == null)
                {
                    _client = new Service.ClubCloudServiceClient(SPServiceContext.Current);
                }
                return _client;
            }
        }


        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            this.EnsureUpdatePanelFixups();
        }

        /// <summary>
        /// Fixups for update panel
        /// </summary>
        private void EnsureUpdatePanelFixups()
        {
            if (this.Page.Form != null)
            {
                string formOnSubmitAtt = this.Page.Form.Attributes["onsubmit"];
                if (formOnSubmitAtt == "return _spFormOnSubmitWrapper();")
                {
                    this.Page.Form.Attributes["onsubmit"] = "_spFormOnSubmitWrapper();";
                }
            }
            ScriptManager.RegisterStartupScript(this, this.GetType(), "UpdatePanelFixup", "_spOriginalFormAction = document.forms[0].action; _spSuppressFormOnSubmitWrapper=true;", true);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Mailing_DataSource.ViewName = this.ViewName;
            Mailing_DataSource.Assembly = typeof(MailingUserControl).Assembly;            
            Mailing_DataSource.View.WhereParameters = new ParameterCollection();
            Mailing_DataSource.View.Parent = this.Page;
        }

        [Browsable(true)]
        public string ViewName { get; set; }

        protected void Mailingform_CallingDataMethods(object sender, CallingDataMethodsEventArgs e)
        {
            e.DataMethodsObject = Mailing_DataSource.View;
        }

        protected void Mailform_MailSend(object sender, FormViewInsertedEventArgs e)
        {
            if (e.Exception != null)
            {
                e.ExceptionHandled = true;
                e.KeepInInsertMode = true;
            }
            else
            {
                if (Request.QueryString.AllKeys.Contains("IsDlg"))
                {
                    Response.Write("<script type='text/javascript'>window.frameElement.commitPopup()</script>");
                    Response.Flush();
                    Response.End();
                }
                else
                {
                    Response.Redirect("mailing.aspx");
                }
            }
        }

        private static XElement GetTemplateByName(string name)
        {
            XElement templatebyName = null;
            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                try
                {
                    using (SPSite currentSite = new SPSite(SPContext.Current.Site.ID, SPUrlZone.Internet))
                    {
                        using (SPWeb web = currentSite.OpenWeb(SPContext.Current.Web.ID))
                        {
                            SPDocumentLibrary SiteAssets = null;
                            SPFolder Templates = null;
                            SPFile Aanmelden = null;

                            XElement template = null;

                            SPList assets = web.Lists.TryGetList("SiteAssets");

                            if (assets == null)
                                assets = web.Lists.TryGetList("Siteactiva");

                            if (assets != null)
                                SiteAssets = (SPDocumentLibrary)assets;

                            if (SiteAssets != null)
                                Templates = SiteAssets.RootFolder.SubFolders["Templates"];

                            if (Templates != null && Templates.Exists)
                                Aanmelden = Templates.Files["template.xsl"];

                            if (Aanmelden != null && Aanmelden.Exists)
                                template = XElement.Load(Aanmelden.OpenBinaryStream());

                            if (template == null)
                                throw new FileNotFoundException("Template not Found", Aanmelden.Url);

                            templatebyName = template.Elements("{http://www.w3.org/1999/XSL/Transform}template").Where(temp => temp.Attribute("name").Value == name).FirstOrDefault();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Logger.WriteLog(Logger.Category.Unexpected, ex.Source, ex.Message);
                }
            });
            return templatebyName;
        }

        #region IWebpart

        protected string _title = "[Generic Title]";
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        //  Subtitle
        protected string _subTitle = "";
        public string Subtitle
        {
            get { return _subTitle; }
            set { _subTitle = value; }
        }
        //  Caption
        protected string _caption = "[Generic Caption]";
        public string Caption
        {
            get { return _caption; }
            set { _caption = value; }
        }
        //  Description
        private string _description = "[Generic Description]";
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        //  TitleUrl
        private string _titleUrl = "";
        public string TitleUrl
        {
            get { return _titleUrl; }
            set { _titleUrl = value; }
        }
        //  TitleIconImageUrl
        private string _titleIconImageUrl = "~/App_Themes/portal/img/tools.gif";
        public string TitleIconImageUrl
        {
            get { return _titleIconImageUrl; }
            set { _titleIconImageUrl = value; }
        }
        //  CatalogIconImageUrl
        private string _catalogIconImageUrl = "~/App_Themes/portal/img/tools.gif";
        public string CatalogIconImageUrl
        {
            get { return _catalogIconImageUrl; }
            set { _catalogIconImageUrl = value; }
        }

        #endregion

    }
}
