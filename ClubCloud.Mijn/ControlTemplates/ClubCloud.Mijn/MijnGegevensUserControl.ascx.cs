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
        protected new void Page_Load(object sender, EventArgs e)
        {
            base.Page_Load(sender,e);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.EnsureChildControls();
        }

        protected override void CreateChildControls()
        {
            base.CreateChildControls();
        }

        protected override void OnDataBinding(EventArgs e)
        {
            base.OnDataBinding(e);
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
        }

        internal override void SetPageData()
        {
            if (Settings != null)//&& Settings.mijnknltb_allow)
            {
                ClubCloud_Gebruiker gebruiker = null;

                try
                {
                    gebruiker = Client.GetGebruikerByNummer(userId, Settings.VerenigingId.Value, userId, false);
                }
                catch { }

                if (gebruiker != null)
                {
                    try
                    {
                        gebruiker.ClubCloud_Vereniging = Client.GetVerenigingById(userId, gebruiker.VerenigingId.Value);

                        //gebruiker.ClubCloud_Lidmaatschap = Client.GetLidaamschapByGebruikerId(userId, gebruiker.VerenigingId.Value);
                        gebruiker.ClubCloud_Address = Client.GetAddressByGebruikerId(userId, gebruiker.VerenigingId.Value, gebruiker.Id, false);
                    }
                    catch { }

                    try
                    {
                        fvw_persoon.DataSource = new List<ClubCloud_Gebruiker> { gebruiker };
                        fvw_persoon.DataBind();
                    }
                    catch (Exception ex)
                    {
                        lbl_result.Text += ex.Message + Environment.NewLine;
                    }

                    try
                    {
                        fvw_contact.DataSource = new List<ClubCloud_Gebruiker> { gebruiker };
                        fvw_contact.DataBind();
                    }
                    catch (Exception ex)
                    {
                        lbl_result.Text += ex.Message + Environment.NewLine;
                    }

                    try
                    {
                        ClubCloud_Address first = gebruiker.ClubCloud_Address.First();
                        if (string.IsNullOrWhiteSpace(first.Naam)) first.Naam = "Bezoekadres";
                        fvw_adres.DataSource = new List<ClubCloud_Address> { first };
                        fvw_adres.DataBind();
                    }
                    catch (Exception ex)
                    {
                        lbl_result.Text += ex.Message + Environment.NewLine;
                    }

                    //TODO second fvw_post
                    /*
                    try
                    {
                        ClubCloud_Address last = gebruiker.ClubCloud_Address.Last();
                        if (string.IsNullOrWhiteSpace(last.Naam)) last.Naam = "Postadres";
                        fvw_adres.DataSource = new List<ClubCloud_Address> { last };
                        fvw_adres.DataBind();
                    }
                    catch (Exception ex)
                    {
                        lbl_result.Text += ex.Message + Environment.NewLine;
                    }
                    */

                    try
                    {

                        ClubCloud_Foto foto = Client.GetFotoById(userId, gebruiker.VerenigingId.Value, gebruiker.Id, false);

                        fvw_afbeelding.DataSource = new List<ClubCloud_Foto> { foto }; ;
                        fvw_afbeelding.DataBind();

                        if (fvw_afbeelding.CurrentMode == FormViewMode.ReadOnly)
                        {
                            Image profielfoto = (Image)fvw_afbeelding.FindControl("profielfoto");
                            if (profielfoto != null)
                            {
                                string base64String = Convert.ToBase64String(foto.ContentData, 0, foto.ContentData.Length);
                                profielfoto.ImageUrl = "data:image/png;base64," + base64String;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        lbl_result.Text += ex.Message + Environment.NewLine;
                    }


                    Label knltbid = (Label)fvw_persoon.FindControl("knltbid");
                    knltbid.Text = Settings.Id.ToString();

                }
            }
            else
            {
                pnl_authorize.Visible = true;
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
                    ClubCloud_Gebruiker gebruiker = Client.GetGebruikerByNummer(userId, Settings.VerenigingId.Value, userId, false);

                    gebruiker.TelefoonOverdag = e.NewValues["TelefoonOverdag"].ToString();
                    gebruiker.TelefoonAvond = e.NewValues["TelefoonAvond"].ToString();
                    gebruiker.Mobiel = e.NewValues["Mobiel"].ToString();
                    CheckBox TelefoonGeheim = (CheckBox)fvw_contact.FindControl("TelefoonGeheim");
                    gebruiker.TelefoonGeheim = TelefoonGeheim.Checked;
                    gebruiker.EmailKNLTB = e.NewValues["EmailKNLTB"].ToString();
                    gebruiker.EmailWebSite = e.NewValues["EmailWebSite"].ToString();
                    gebruiker.EmailOverig = e.NewValues["EmailOverig"].ToString();
                    CheckBox EmailGeheim = (CheckBox)fvw_contact.FindControl("EmailGeheim");
                    gebruiker.EmailGeheim = EmailGeheim.Checked;
                    Client.SetClubCloudGebruiker(userId, Settings.VerenigingId.Value, gebruiker, false);
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
                    ClubCloud_Gebruiker gebruiker = Client.GetGebruikerByNummer(userId, Settings.VerenigingId.Value, userId, false);
                    gebruiker.ClubCloud_Address = Client.GetAddressByGebruikerId(userId, gebruiker.VerenigingId.Value, gebruiker.Id, false);

                    gebruiker.ClubCloud_Address.First().Naam = "Bezoekadres";
                    gebruiker.ClubCloud_Address.First().Gemeente = e.NewValues["Gemeente"].ToString();
                    gebruiker.ClubCloud_Address.First().Nummer = e.NewValues["Nummer"].ToString();
                    gebruiker.ClubCloud_Address.First().Postbus = e.NewValues["Postbus"].ToString();
                    gebruiker.ClubCloud_Address.First().Postcode = e.NewValues["Postcode"].ToString();
                    gebruiker.ClubCloud_Address.First().Provincie = e.NewValues["Provincie"].ToString();
                    gebruiker.ClubCloud_Address.First().Stad = e.NewValues["Stad"].ToString();
                    gebruiker.ClubCloud_Address.First().Straat = e.NewValues["Straat"].ToString();
                    DropDownList Land = (DropDownList)fvw_adres.FindControl("Land");
                    gebruiker.ClubCloud_Address.First().Land = Land.SelectedItem.Text;
                    CheckBox AddressGeheim = (CheckBox)fvw_adres.FindControl("AddressGeheim");
                    gebruiker.AddressGeheim = AddressGeheim.Checked;
                    Client.SetClubCloudGebruiker(userId, Settings.VerenigingId.Value, gebruiker, false);
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
                //Geslacht.Items.FindByText(((ClubCloud_Gebruiker)fvw_persoon.DataItem).Geslacht.ToString()).Selected = true;
            }
        }

        protected void fvw_persoon_ItemUpdating(object sender, FormViewUpdateEventArgs e)
        {
            if (IsPostBack)
            {
                if (Settings != null)
                {
                    ClubCloud_Gebruiker gebruiker = Client.GetGebruikerByNummer(userId, Settings.VerenigingId.Value, userId, false);

                    gebruiker.Achternaam = e.NewValues["Achternaam"].ToString();
                    gebruiker.Geboortedatum = DateTime.Parse(e.NewValues["Geboortedatum"].ToString());
                    gebruiker.Geboorteplaats = e.NewValues["Geboorteplaats"].ToString();
                    DropDownList Geslacht = (DropDownList)fvw_persoon.FindControl("Geslacht");
                    gebruiker.Geslacht = (GeslachtSoort)Enum.Parse(typeof(GeslachtSoort), Geslacht.SelectedValue);
                    DropDownList NationaliteitId = (DropDownList)fvw_persoon.FindControl("NationaliteitId");
                    gebruiker.NationaliteitId = Guid.Parse(NationaliteitId.SelectedValue);
                    gebruiker.Roepnaam = e.NewValues["Roepnaam"].ToString();
                    gebruiker.Achtervoegsel = e.NewValues["Achtervoegsel"].ToString();
                    gebruiker.Tussenvoegsel = e.NewValues["Tussenvoegsel"].ToString();
                    gebruiker.Voorletters = e.NewValues["Voorletters"].ToString();
                    gebruiker.Voornamen = e.NewValues["Voornamen"].ToString();
                    gebruiker.Voornaam = e.NewValues["Voornaam"].ToString();
                    Client.SetClubCloudGebruiker(userId, Settings.VerenigingId.Value, gebruiker, false);
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

                }
            }
        }

        protected void fvw_afbeelding_ModeChanged(object sender, EventArgs e)
        {
            SetPageData();
        }

        #endregion

        protected void tmr_loader_profiel_Tick(object sender, EventArgs e)
        {
            tmr_loader_profiel.Enabled = false;

            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                    SetPageData();
            }
            else
            {
                this.pnl_profiel.Visible = false;
                this.pnl_secure.Visible = true;
            }

            udp_profiel_progress.Visible = false;
        }

    }
}
