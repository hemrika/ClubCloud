using ClubCloud.Service.Model;
using Microsoft.SharePoint;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace ClubCloud.Mijn.ControlTemplates
{
    public partial class MijnGegevensUserControl : ClubCloudUserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page_Load(sender,e);
            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                if (!IsPostBack)
                {
                    SetPageData();
                }
            }
            else
            {
                this.pnl_profiel.Visible = false;
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
                ClubCloud_Gebruiker gebruiker = Client.GetClubCloudGebruiker(userId, false);
                fvw_adres.DataSource = new List<ClubCloud_Gebruiker> { gebruiker }; ;
                fvw_adres.DataBind();

                /*
                if(fvw_adres.CurrentMode == FormViewMode.Edit)
                {
                    //List<ClubCloud_Nationaliteit> nationaliteiten = Client.GetNationaliteiten(userId, false);
                }
                */

                fvw_afbeelding.DataSource = new List<ClubCloud_Gebruiker> { gebruiker }; ;
                fvw_afbeelding.DataBind();

                fvw_contact.DataSource = new List<ClubCloud_Gebruiker> { gebruiker }; ;
                fvw_contact.DataBind();

                fvw_persoon.DataSource = new List<ClubCloud_Gebruiker> { gebruiker }; ;
                fvw_persoon.DataBind();

                Label knltbid = (Label)fvw_persoon.FindControl("knltbid");
                knltbid.Text = Settings.Id.ToString();
            }

        }

        #region Contact

        protected void fvw_contact_ItemCommand(object sender, FormViewCommandEventArgs e)
        {

        }

        protected void fvw_contact_ItemUpdated(object sender, FormViewUpdatedEventArgs e)
        {
            SetPageData();
        }

        protected void fvw_contact_ModeChanging(object sender, FormViewModeEventArgs e)
        {
            fvw_contact.ChangeMode(e.NewMode);
            SetPageData();
        }

        protected void fvw_contact_ItemUpdating(object sender, FormViewUpdateEventArgs e)
        {
            if (IsPostBack)
            {
                if (Settings != null)
                {
                    ClubCloud_Gebruiker gebruiker = Client.GetClubCloudGebruiker(userId, false);

                    gebruiker.TelefoonOverdag = e.NewValues["TelefoonOverdag"].ToString();
                    gebruiker.TelefoonAvond = e.NewValues["TelefoonAvond"].ToString();
                    gebruiker.Mobiel = e.NewValues["Mobiel"].ToString();
                    gebruiker.Email = e.NewValues["Email"].ToString();
                    Client.SetClubCloudGebruiker(userId, gebruiker, false);
                }
            }
        }

        protected void fvw_contact_ModeChanged(object sender, EventArgs e)
        {
            SetPageData();
        }

        #endregion

        #region Adres

        protected void fvw_adres_ItemCommand(object sender, FormViewCommandEventArgs e)
        {

        }

        protected void fvw_adres_ItemUpdated(object sender, FormViewUpdatedEventArgs e)
        {
            SetPageData();
        }

        protected void fvw_adres_ModeChanging(object sender, FormViewModeEventArgs e)
        {
            fvw_adres.ChangeMode(e.NewMode);
            SetPageData();
        }


        protected void fvw_adres_ItemUpdating(object sender, FormViewUpdateEventArgs e)
        {
            if (IsPostBack)
            {
                if (Settings != null)
                {
                    ClubCloud_Gebruiker gebruiker = Client.GetClubCloudGebruiker(userId, false);

                    gebruiker.Straat = e.NewValues["Straat"].ToString();
                    gebruiker.Gemeente = e.NewValues["Gemeente"].ToString();
                    gebruiker.Huisnummer = e.NewValues["Huisnummer"].ToString();
                    gebruiker.Plaats = e.NewValues["Plaats"].ToString();
                    gebruiker.Postcode = e.NewValues["Postcode"].ToString();
                    Client.SetClubCloudGebruiker(userId, gebruiker, false);
                }
            }
        }

        protected void fvw_adres_ModeChanged(object sender, EventArgs e)
        {
            SetPageData();
        }


        #endregion

        #region Persoon

        protected void fvw_persoon_ItemCommand(object sender, FormViewCommandEventArgs e)
        {

        }

        protected void fvw_persoon_ItemUpdated(object sender, FormViewUpdatedEventArgs e)
        {
            SetPageData();
        }

        protected void fvw_persoon_ModeChanging(object sender, FormViewModeEventArgs e)
        {
            fvw_persoon.ChangeMode(e.NewMode);
            SetPageData();

            if (e.NewMode == FormViewMode.Edit)
            {
                DropDownList Geslacht = (DropDownList)fvw_persoon.FindControl("Geslacht");
                Geslacht.Items.FindByText(((ClubCloud_Gebruiker)fvw_persoon.DataItem).Geslacht.ToString()).Selected = true;
            }
        }

        protected void fvw_persoon_ItemUpdating(object sender, FormViewUpdateEventArgs e)
        {
            if (IsPostBack)
            {
                if (Settings != null)
                {
                    ClubCloud_Gebruiker gebruiker = Client.GetClubCloudGebruiker(userId, false);

                    gebruiker.Achternaam = e.NewValues["Achternaam"].ToString();
                    gebruiker.Geboortedatum = DateTime.Parse(e.NewValues["Geboortedatum"].ToString());
                    gebruiker.Geboorteplaats = e.NewValues["Geboorteplaats"].ToString();
                    DropDownList Geslacht = (DropDownList)fvw_persoon.FindControl("Geslacht");
                    gebruiker.Geslacht = (KNLTB.ServIt.LedenAdministratieService.Geslacht)Enum.Parse(typeof(KNLTB.ServIt.LedenAdministratieService.Geslacht), Geslacht.SelectedValue);
                    DropDownList NationaliteitId = (DropDownList)fvw_persoon.FindControl("NationaliteitId");
                    gebruiker.NationaliteitId = Guid.Parse(NationaliteitId.SelectedValue);
                    gebruiker.Roepnaam = e.NewValues["Roepnaam"].ToString();
                    gebruiker.Toevoeging = e.NewValues["Toevoeging"].ToString();
                    gebruiker.Tussenvoegsel = e.NewValues["Tussenvoegsel"].ToString();
                    gebruiker.Voorletters = e.NewValues["Voorletters"].ToString();
                    gebruiker.Voornamen = e.NewValues["Voornamen"].ToString();
                    Client.SetClubCloudGebruiker(userId, gebruiker, false);
                }
            }
        }

        protected void fvw_persoon_ModeChanged(object sender, EventArgs e)
        {
            SetPageData();
        }

        #endregion

        #region Afbeelding

        protected void fvw_afbeelding_ItemCommand(object sender, FormViewCommandEventArgs e)
        {

        }

        protected void fvw_afbeelding_ItemUpdated(object sender, FormViewUpdatedEventArgs e)
        {
            SetPageData();
        }

        protected void fvw_afbeelding_ModeChanging(object sender, FormViewModeEventArgs e)
        {
            fvw_afbeelding.ChangeMode(e.NewMode);
            SetPageData();
        }

        protected void fvw_afbeelding_ItemUpdating(object sender, FormViewUpdateEventArgs e)
        {
            if (IsPostBack)
            {
                if (Settings != null)
                {
                    ClubCloud_Gebruiker gebruiker = Client.GetClubCloudGebruiker(userId, false);

                    gebruiker.TelefoonOverdag = e.NewValues["TelefoonOverdag"].ToString();
                    gebruiker.TelefoonAvond = e.NewValues["TelefoonAvond"].ToString();
                    gebruiker.Mobiel = e.NewValues["Mobiel"].ToString();
                    gebruiker.Email = e.NewValues["Email"].ToString();
                    Client.SetClubCloudGebruiker(userId, gebruiker, false);
                }
            }
        }

        protected void fvw_afbeelding_ModeChanged(object sender, EventArgs e)
        {
            SetPageData();
        }

        #endregion

    }
}
