﻿using ClubCloud.Service.Model;
using Microsoft.SharePoint;
using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace ClubCloud.Mijn.ControlTemplates
{
    public partial class MijnResultatenUserControl : ClubCloudUserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page_Load(sender, e);
            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                SetPageData();
            }
            else
            {
                this.pnl_resultaten.Visible = false;
                this.pnl_secure.Visible = true;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        internal override void SetPageData()
        {
            if (Settings != null && Settings.mijnknltb_allow)
            {
                //Client.GetDistricten
            }
            else
            {
                pnl_authorize.Visible = true;
            }
        }
    }
}
