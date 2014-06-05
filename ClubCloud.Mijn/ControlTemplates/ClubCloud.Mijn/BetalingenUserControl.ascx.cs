using ClubCloud.Service.Model;
using Microsoft.SharePoint;
using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace ClubCloud.Mijn.ControlTemplates
{
    public partial class BetalingenUserControl : ClubCloudUserControl
    {
        private string userId = string.Empty;
        private ClubCloud_Setting settings;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                if (!IsPostBack)
                {

                    userId = SPContext.Current.Web.CurrentUser.UserId.NameId;
                    settings = Client.GetClubCloudSettings(userId);

                    if (settings != null)
                    {
                        betalingen_overboeking.Checked = settings.financieel.HasFlag(Financieel.Machtiging);
                        betalingen_factuur.Checked = settings.financieel.HasFlag(Financieel.Factuur);
                        betalingen_ideal.Checked = settings.financieel.HasFlag(Financieel.iDEAL);
                        betalingen_paypal.Checked = settings.financieel.HasFlag(Financieel.PayPal);
                    }
                }
            }
            else
            {
                this.pnl_betalingen.Visible = false;
                this.pnl_secure.Visible = true;
            }

        }

        protected void btn_betaling_Click(object sender, EventArgs e)
        {
            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                financieel_error.ShowSummary = false;
                settings = new ClubCloud_Setting();

                settings.Id = int.Parse(SPContext.Current.Web.CurrentUser.UserId.NameId);
                settings.financieel = Financieel.None;

                if (betalingen_overboeking.Checked)
                {
                    settings.financieel |= Financieel.Machtiging;
                }

                if (betalingen_factuur.Checked)
                {
                    settings.financieel |= Financieel.Factuur;
                }

                if (betalingen_ideal.Checked)
                {
                    settings.financieel |= Financieel.iDEAL;
                }

                if (betalingen_paypal.Checked)
                {
                    settings.financieel |= Financieel.PayPal;
                }

                if (settings.financieel != Financieel.None)
                {
                    settings = Client.SetFinancieel(settings);
                }
                else
                {
                    financieel_error.ShowSummary = true;
                }
            }
        }
    }
}
