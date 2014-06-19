﻿using ClubCloud.Service.Model;
using Microsoft.SharePoint;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace ClubCloud.Mijn.ControlTemplates
{
    public partial class MijnVerenigingUserControl : ClubCloudUserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                SetPageData();
            }
            else
            {
                this.pnl_verenigingen.Visible = false;
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
                List<ClubCloud_Gebruiker_Vereniging> verenigingen = Client.GetVerenigingen(userId,false);
                lst_verenigingen.DataSource = verenigingen;
                lst_verenigingen.DataBind();

                if (verenigingen.Count == 1)
                {
                    try
                    {
                        ClubCloud_Vereniging vereniging = Client.GetVerenigingById(userId, verenigingen[0].VerenigingId, false);
                        fvw_vereniging.DataSource = new List<ClubCloud_Vereniging> { vereniging };
                        fvw_vereniging.DataBind();
                    }
                    catch { }

                    try
                    {
                        ClubCloud_Vereniging_Accomodatie accomodatie = Client.GetAccommodatieForVereniging(userId, verenigingen[0].VerenigingId, false);
                        fvw_accomodatie.DataSource = new List<ClubCloud_Vereniging_Accomodatie> { accomodatie };
                        fvw_accomodatie.DataBind();
                    }
                    catch { }

                    try
                    {
                        List<ClubCloud_Vereniging_BestuursLid> leden = Client.GetBestuurForVereniging(userId, verenigingen[0].VerenigingId, false);

                        if (leden != null && leden.Count > 0)
                        {
                            //Verenigingsbestuur
                            List<ClubCloud_Vereniging_BestuursLid> Verenigingsbestuur = leden.Where(l => l.Orgaan.Equals("Verenigingsbestuur", StringComparison.OrdinalIgnoreCase) == true).OrderBy(b => b.VolledigeNaam).ToList();

                            //Ledenadministratie
                            List<ClubCloud_Vereniging_BestuursLid> Ledenadministratie = leden.Where(l => l.Functie.Contains("Ledenadministratie") == true).OrderBy(b => b.VolledigeNaam).ToList();

                            //VCL
                            List<ClubCloud_Vereniging_BestuursLid> VCL = leden.Where(l => l.Functie.Contains("VCL") == true).OrderBy(b => b.VolledigeNaam).ToList();

                            //Wedstrijdleider
                            List<ClubCloud_Vereniging_BestuursLid> Wedstrijdleider = leden.Where(l => l.Functie.Contains("Wedstrijdleider") == true).OrderBy(b => b.VolledigeNaam).ToList();

                            //Verenigingstennisleraar
                            List<ClubCloud_Vereniging_BestuursLid> Verenigingstennisleraar = leden.Where(l => l.Orgaan.Equals("Verenigingstennisleraar", StringComparison.OrdinalIgnoreCase) == true).OrderBy(b => b.VolledigeNaam).ToList();

                            //Verenigingsscheidsrechter
                            List<ClubCloud_Vereniging_BestuursLid> Verenigingsscheidsrechter = leden.Where(l => l.Orgaan.Equals("Verenigingsscheidsrechter", StringComparison.OrdinalIgnoreCase) == true).OrderBy(b => b.VolledigeNaam).ToList();
                        }

                        foreach (ClubCloud_Vereniging_BestuursLid lid in leden.Where(l => l.Functie.Equals("Functionaris Uitslagengedelegeerde", StringComparison.OrdinalIgnoreCase) == false))
                        {
                            string VolledigeNaam = lid.VolledigeNaam;
                        }
                    }
                    catch { }
                }
            }

        }

        protected void lst_verenigingen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Settings != null)
            {
                Guid Id = Guid.Parse(lst_verenigingen.SelectedDataKey.Value.ToString());
                ClubCloud_Vereniging vereniging = Client.GetVerenigingById(userId,Id,false);
                fvw_vereniging.DataSource = new List<ClubCloud_Vereniging> { vereniging };
                fvw_vereniging.DataBind();
            }

        }
    }
}