﻿using ClubCloud.Model;
using Microsoft.SharePoint;
using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace ClubCloud.Mijn.ControlTemplates
{
    public partial class VeranderwachtwoordUserControl : ClubCloudUserControl
    {
        protected new void Page_Load(object sender, EventArgs e)
        {
            base.Page_Load(sender, e);
            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                if (!IsPostBack)
                {
                }
            }
            else
            {
                this.pnl_password.Visible = false;
                this.pnl_secure.Visible = true;
            }

        }
    }
}
