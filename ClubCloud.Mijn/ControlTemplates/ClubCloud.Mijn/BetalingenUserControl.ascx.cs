using ClubCloud.Model;
using Microsoft.SharePoint;
using System;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace ClubCloud.Mijn.ControlTemplates
{
    public partial class BetalingenUserControl : ClubCloudUserControl
    {
        //private string userId = string.Empty;
        //private ClubCloud_Setting settings;

        protected new void Page_Load(object sender, EventArgs e)
        {
            base.Page_Load(sender, e);
            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                if (!IsPostBack)
                {
                    SetPageData();
                }
            }
            else
            {
                this.pnl_betalingen.Visible = false;
                this.pnl_secure.Visible = true;
            }

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        internal override void SetPageData()
        {
            if (Settings != null)
            {
                betalingen_overboeking.Checked = Settings.financieel.HasFlag(Financieel.Machtiging);
                betalingen_factuur.Checked = Settings.financieel.HasFlag(Financieel.Factuur);
                betalingen_ideal.Checked = Settings.financieel.HasFlag(Financieel.iDEAL);
                betalingen_paypal.Checked = Settings.financieel.HasFlag(Financieel.PayPal);
            }

        }

        protected void btn_betaling_Click(object sender, EventArgs e)
        {
            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                vds_betalingen.ShowSummary = false;
                //Settings = new ClubCloud_Setting();

                //Settings.Id = int.Parse(SPContext.Current.Web.CurrentUser.UserId.NameId);
                Settings.financieel = Financieel.None;

                if (betalingen_overboeking.Checked)
                {
                    Settings.financieel |= Financieel.Machtiging;
                }

                if (betalingen_factuur.Checked)
                {
                    Settings.financieel |= Financieel.Factuur;
                }

                if (betalingen_ideal.Checked)
                {
                    Settings.financieel |= Financieel.iDEAL;
                }

                if (betalingen_paypal.Checked)
                {
                    Settings.financieel |= Financieel.PayPal;
                }

                Settings = Client.SetClubCloudSettings(Settings);
                vds_betalingen.ShowSummary = true;
            }
        }
    }
}
