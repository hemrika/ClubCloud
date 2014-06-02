using Microsoft.SharePoint;
using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace ClubCloud.Mijn.ControlTemplates
{
    public partial class BetalingenUserControl : ClubCloudUserControl
    {
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

        protected void Page_Load(object sender, EventArgs e)
        {
            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
            }
            else
            {
                this.pnl_betalingen.Visible = false;
                this.pnl_secure.Visible = true;
            }

        }

        protected void btn_betaling_Click(object sender, EventArgs e)
        {

        }
    }
}
