//-----------------------------------------------------------------------
// <copyright file="HelloWorldServiceClient.cs" company="">
// Copyright © 
// </copyright>
//-----------------------------------------------------------------------

namespace ClubCloud.Service
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Microsoft.SharePoint;
    using ClubCloud.Model;
    using System.Threading.Tasks;
    using System.Web.UI;
    using System.Web.UI.WebControls;

    /// <summary>
    /// This is the class that is accessible to the Client callers (web parts, user controls, timer jobs, etc.).
    /// </summary>
    public class ClubCloudServiceClient : BaseServiceClient
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ClubCloudServiceClient"/> class.
        /// </summary>
        public ClubCloudServiceClient()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClubCloudServiceClient"/> class.
        /// </summary>
        /// <param name="serviceContext">An <see cref="Microsoft.SharePoint.Administration.SPServiceContext" />.</param>
        public ClubCloudServiceClient(SPServiceContext serviceContext)
            : base(serviceContext)
        {
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the name of the actual (.svc file) for this service.
        /// </summary>
        /// <remarks>
        /// Service applications are designed to support a single endpoint .svc file. For more complicated 
        /// service applications with many different types of services, it makes sense to create several .svc files 
        /// and classes. To support multiple end points, use a recognizable string here, and swap it out dynamically 
        /// in the BaseServiceClient's GetEndPoint method after the load balancer has provided the full path to this 
        /// original end point.
        /// </remarks>
        protected override string EndPoint
        {
            get { return "ClubCloud.svc"; }
        }

        #endregion

        #region Mijn

        #region Afhangen

        public List<ClubCloud_Gebruiker> GetGebruikersBySearch(string bondsnummer, string prefixText, int count, bool refresh)
        {
            List<ClubCloud_Gebruiker> response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetGebruikersBySearch(bondsnummer, prefixText, count, refresh);
                },
                false);

            return response;
        }

        #endregion

        #region Settings

        public ClubCloud_Setting SetMijnKNLTB(ClubCloud_Setting settings)
        {
            ClubCloud_Setting response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetMijnKNLTB(settings);
                },
                false);

            return response;
        }

        public ClubCloud_Setting SetClubCloudSettings(ClubCloud_Setting settings)
        {
            ClubCloud_Setting response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetClubCloudSettings(settings);
                },
                false);

            return response;
        }

        public ClubCloud_Setting GetClubCloudSettings(string bondsnummer)
        {
            ClubCloud_Setting response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetClubCloudSettings(bondsnummer);
                },
                false);

            return response;
        }

        /*
        public ClubCloud_Setting SetPrivacy(ClubCloud_Setting settings)
        {
        ClubCloud_Setting response = null;

        this.ExecuteOnChannel<IClubCloudApplicationService>(
        delegate(IClubCloudApplicationService channel)
        {
            response = channel.SetPrivacy(settings);
        },
        false);

        return response;
        }

        public ClubCloud_Setting SetTwitter(ClubCloud_Setting settings)
        {
            ClubCloud_Setting response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetTwitter(settings);
                },
                false);

            return response;
        }

        public ClubCloud_Setting SetFaceBook(ClubCloud_Setting settings)
        {
            ClubCloud_Setting response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetFaceBook(settings);
                },
                false);

            return response;
        }

        public ClubCloud_Setting SetFinancieel(ClubCloud_Setting settings)
        {
            ClubCloud_Setting response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetFinancieel(settings);
                },
                false);

            return response;
        }

        public ClubCloud_Setting SetTracking(ClubCloud_Setting settings)
        {
            ClubCloud_Setting response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetTracking(settings);
                },
                false);

            return response;
        }
        */

        #endregion

        public bool SetClubCloudGebruiker(string bondsnummer, Guid verenigingId, ClubCloud_Gebruiker gebruiker, bool refresh = false)
        {
            bool response = false;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetClubCloudGebruiker(bondsnummer, verenigingId, gebruiker, refresh);
                },
                false);

            return response;
        }

        public ClubCloud_Gebruiker GetGebruikerByNummer(string bondsnummer, Guid verenigingId, string nummer, bool refresh = false)
        {
            ClubCloud_Gebruiker response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetGebruikerByNummer(bondsnummer, verenigingId, nummer, refresh);
                },
                false);

            return response;
        }

        public ClubCloud_Gebruiker GetGebruikerById(string bondsnummer, Guid verenigingId, Guid gebruikerId, bool refresh = false)
        {
            ClubCloud_Gebruiker response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetGebruikerById(bondsnummer, verenigingId, gebruikerId, refresh);
                },
                false);

            return response;
        }

        public List<ClubCloud_Address> GetAddressByGebruikerId(string bondsnummer, Guid verenigingId, Guid gebruikerId, bool refresh = false)
        {
            List<ClubCloud_Address> response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetAddressByGebruikerId(bondsnummer, verenigingId, gebruikerId, refresh);
                },
                false);

            return response;
        }
        
        public List<ClubCloud_Lidmaatschap> GetLidmaatschapByGebruikerId(string bondsnummer, Guid verenigingId, Guid gebruikerId, bool refresh = false)
        {
            List<ClubCloud_Lidmaatschap> response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetLidmaatschapByGebruikerId(bondsnummer, verenigingId, gebruikerId, refresh);
                },
                false);

            return response;

        }

        public ClubCloud_Vereniging GetVerenigingById(string bondsnummer, Guid verenigingId, bool refresh = false)
        {
            ClubCloud_Vereniging response = null;

            try
            {
                this.ExecuteOnChannel<IClubCloudApplicationService>(
                    delegate(IClubCloudApplicationService channel)
                    {
                        response = channel.GetVerenigingById(bondsnummer, verenigingId, refresh);
                    },
                    false);
            }
            catch { }

            return response;
        }

        public ClubCloud_Accommodatie GetAccommodatieById(string bondsnummer, Guid accommodatieId, bool refresh = false)
        {
            ClubCloud_Accommodatie response = null;

            try
            {
                this.ExecuteOnChannel<IClubCloudApplicationService>(
                    delegate(IClubCloudApplicationService channel)
                    {
                        response = channel.GetAccommodatieById(bondsnummer, accommodatieId, refresh);
                    },
                    false);
            }
            catch { }

            return response;
        }
        /*
        public ClubCloud_Accommodatie GetAccommodatieForVereniging(string bondsnummer, Guid verenigingId, bool refresh = false)
        {
            ClubCloud_Accommodatie response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetAccommodatieForVereniging(bondsnummer, verenigingId, refresh);
                },
                false);

            return response;

        }
        */
        /*
        public ClubCloud_Accommodatie GetAccomodatie(string bondsnummer, Guid verenigingId, bool refresh = false)
        {
            ClubCloud_Accommodatie response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    //response = channel.GetAccommodatie(bondsnummer, verenigingId, refresh);
                },
                false);

            return response;

        }
        */
        /*
        public SpelersProfiel GetSpelersProfiel(string bondsnummer, bool refresh = false)
        {
            SpelersProfiel response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetSpelersProfiel(bondsnummer, refresh);
                },
                false);

            return response;

        }
        */

        /*
        public List<ClubCloud_Gebruiker_Vereniging> GetVerenigingen(string bondsnummer, bool refresh = false)
        {
            List<ClubCloud_Gebruiker_Vereniging> response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetVerenigingen(bondsnummer, refresh);
                },
                false);

            return response;

        }
        */

        /*
        public ClubCloud_Vereniging GetVerenigingByNummer(string bondsnummer, string vereniginsnummer, bool refresh = false)
        {
            ClubCloud_Vereniging response = null;

            try
            {
                this.ExecuteOnChannel<IClubCloudApplicationService>(
                    delegate(IClubCloudApplicationService channel)
                    {
                        response = channel.GetVerenigingByNummer(bondsnummer, vereniginsnummer, refresh);
                    },
                    false);

            }
            catch { }

            return response;

        }
        */

        /*
        public List<ClubCloud_Vereniging_BestuursLid> GetBestuurForVereniging(string bondsnummer, Guid verenigingId, bool refresh = false)
        {
            List<ClubCloud_Vereniging_BestuursLid> response = null;

            try
            {
                this.ExecuteOnChannel<IClubCloudApplicationService>(
                    delegate(IClubCloudApplicationService channel)
                    {
                        //response = channel.GetBestuurForVereniging(bondsnummer, verenigingId, refresh);
                    },
                    false);

            }
            catch { }

            return response;

        }
        */

        /*
        public List<ClubCloud_District> GetDistricten(string user)
        {
            List<ClubCloud_District> response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetDistricten(user);
                },
                false);

            return response;

        }
        */

        /*
        public bool CreateClubCloudWebSite(string verenigingsnummer)
        {
            bool response = false;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.CreateClubCloudWebSite(verenigingsnummer);
                },
                false);

            return response;

        }
        */

        #endregion

        #region Afhangen

        public bool DeleteReservering(string bondsnummer, Guid verenigingId, Guid reserveringId, bool push = false)
        {
            bool response = false;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.DeleteReservering(bondsnummer, verenigingId, reserveringId, push);
                },
                false);

            return response;
        }



        public List<ClubCloud_Gebruiker> GetGebruikersByReserveringId(string bondsnummer, Guid verenigingId, Guid reserveringId, bool refresh = false)
        {
            List<ClubCloud_Gebruiker> response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetGebruikersByReserveringId(bondsnummer, verenigingId, reserveringId, refresh);
                },
                false);

            return response;
        }

        public ClubCloud_Reservering GetReserveringByReserveringId(string bondsnummer, Guid verenigingId, Guid reserveringId, bool refresh = false) 
        {
            ClubCloud_Reservering response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetReserveringByReserveringId(bondsnummer, verenigingId, reserveringId, refresh);
                },
                false);

            return response;
        }

        public List<ClubCloud_Reservering> GetReserveringenByBaanId(string bondsnummer, Guid verenigingId, Guid baanId, bool refresh = false)
        {
            List<ClubCloud_Reservering> response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetReserveringenByBaanId(bondsnummer, verenigingId, baanId, refresh);
                },
                false);

            return response;
        }

        public List<ClubCloud_Reservering> GetReserveringenByDate(string bondsnummer, Guid verenigingId, DateTime date, bool refresh)
        {
            List<ClubCloud_Reservering> response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetReserveringenByDate(bondsnummer, verenigingId, date, refresh);
                },
                false);

            return response;

        }

        public List<ClubCloud_Reservering> GetReserveringenByBondsnummer(string bondsnummer, Guid verenigingId, string nummer, bool refresh = false)
        {
            List<ClubCloud_Reservering> response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetReserveringenByBondsnummer(bondsnummer, verenigingId, nummer, refresh);
                },
                false);

            return response;
        }

        public List<ClubCloud_Reservering> GetReserveringenByVerenigingId(string bondsnummer, Guid verenigingId, bool refresh = false)
        {
            List<ClubCloud_Reservering> response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetReserveringenByVerenigingId(bondsnummer, verenigingId, refresh);
                },
                false);

            return response;
        }

        public ClubCloud_Vereniging GetVerenigingByLocation(string bondsnummer, double Latitude, double Longitude, bool refresh = false)
        {
            ClubCloud_Vereniging response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetVerenigingByLocation(bondsnummer, Latitude, Longitude, refresh);
                },
                false);

            return response;
        }

        public ClubCloud_Vereniging GetVerenigingByNummer(string bondsnummer, string verenigingNummer, bool refresh = false)
        {
            ClubCloud_Vereniging response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetVerenigingByNummer(bondsnummer, verenigingNummer, refresh);
                },
                false);

            return response;
        }

        public ClubCloud_Reservering SetReservering(string bondsnummer, Guid verenigingId, Guid baanId, Guid[] gebruikers, DateTime Datum,TimeSpan Tijd, TimeSpan Duur, ReserveringSoort Soort = ReserveringSoort.Afhangen, bool final = false, bool push = false, string Beschrijving = "")
        {
            ClubCloud_Reservering response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetReservering(bondsnummer, verenigingId, baanId, gebruikers, Datum,Tijd,Duur,Soort,final, push, Beschrijving);
                },
                false);

            return response;
        }

        public ClubCloud_Reservering UpdateReservering(string bondsnummer, Guid verenigingId, ClubCloud.Model.ClubCloud_Reservering reservering, bool final = false, bool push = false)
        {
            ClubCloud_Reservering response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.UpdateReservering(bondsnummer, verenigingId, reservering, final, push);
                },
                false);

            return response;
        }

        public ClubCloud_Gebruiker_DataView GetGebruikersByQuery(string bondsnummer, Guid verenigingId, DataSourceSelectArguments selectArgs = null, List<Parameter> parameters = null, bool refresh = false)
        {
            ClubCloud_Gebruiker_DataView response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetGebruikersByQuery(bondsnummer, verenigingId, selectArgs, parameters, refresh);
                },
                false);

            return response;
        }

        public ClubCloud_Afhang GetVerenigingAfhangSettings(string bondsnummer, Guid verenigingId, bool refresh)
        {
            ClubCloud_Afhang response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetVerenigingAfhangSettings(bondsnummer, verenigingId, refresh);
                },
                false);

            return response;
        }

        #endregion

        #region Banen

        public ClubCloud_Baan GetBaanById(string bondsnummer, Guid verenigingId, Guid baanId, bool refresh = false)
        {
            ClubCloud_Baan response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBaanById(bondsnummer, verenigingId, baanId, refresh);
                },
                false);

            return response;
        }

        public List<ClubCloud_Baanschema> GetBaanSchemaByAccommodatieId(string bondsnummer, Guid verenigingId, Guid accommodatieId, bool refresh = false)
        {
            List<ClubCloud_Baanschema> response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBaanSchemaByAccommodatieId(bondsnummer, verenigingId, accommodatieId, refresh);
                },
                false);

            return response;
        }

        public List<ClubCloud_Baanschema> GetBaanSchemaByVerenigingId(string bondsnummer, Guid verenigingId, bool refresh = false)
        {
            List<ClubCloud_Baanschema> response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBaanSchemaByVerenigingId(bondsnummer, verenigingId, refresh);
                },
                false);

            return response;
        }

        public List<ClubCloud_Baanschema> GetBaanSchemaByDate(string bondsnummer, Guid verenigingId, DateTime date, bool refresh = false)
        {
            List<ClubCloud_Baanschema> response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBaanSchemaByDate(bondsnummer, verenigingId, date, refresh);
                },
                false);

            return response;
        }

        public List<ClubCloud_Baan> GetBanenByAccommodatieId(string bondsnummer, Guid verenigingId, Guid accommodatieId, bool refresh = false)
        {
            List<ClubCloud_Baan> response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBanenByAccommodatieId(bondsnummer, verenigingId, accommodatieId, refresh);
                },
                false);

            return response;
        }

        public List<ClubCloud_Baan> GetBanenByVerenigingId(string bondsnummer, Guid verenigingId, bool refresh = false)
        {
            List<ClubCloud_Baan> response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBanenByVerenigingId(bondsnummer, verenigingId, refresh);
                },
                false);

            return response;
        }
        internal List<ClubCloud_Baanblok> GetBaanblokkenByAccommodatieId(string bondsnummer, Guid verenigingId, Guid accommodatieId, bool refresh)
        {
            List<ClubCloud_Baanblok> response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBaanblokkenByAccommodatieId(bondsnummer, verenigingId, accommodatieId, refresh);
                },
                false);

            return response;
        }

        internal ClubCloud_Baansoort GetBaansoortById(string bondsnummer, Guid verenigingId, Guid accommodatieId, Guid baansoortId, bool refresh)
        {
            ClubCloud_Baansoort response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBaansoortById(bondsnummer, verenigingId, accommodatieId, baansoortId, refresh);
                },
                false);

            return response;
        }

        internal ClubCloud_Baantype GetBaantypeById(string bondsnummer, Guid verenigingId, Guid accommodatieId, Guid BaantypeId, bool refresh)
        {
            ClubCloud_Baantype response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetBaantypeById(bondsnummer, verenigingId, accommodatieId, BaantypeId, refresh);
                },
                false);

            return response;

        }

        #endregion

        #region SignalR

        internal string ScaleOutConnection(string catalog)
        {
            string response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.ScaleOutConnection(catalog);
                },
                false);

            return response;
        }

        #endregion

        #region Foto

        public ClubCloud_Foto GetFotoByNummer(string bondsnummer, Guid verenigingId, string nummer, bool refresh = false)
        {
            ClubCloud_Foto response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetFotoByNummer(bondsnummer, verenigingId, nummer, refresh);
                },
                false);

            return response;
        }

        public ClubCloud_Foto GetFotoById(string bondsnummer, Guid verenigingId, Guid gebruikerId, bool refresh = false)
        {
            ClubCloud_Foto response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetFotoById(bondsnummer, verenigingId, gebruikerId, refresh);
                },
                false);

            return response;
        }

        public ClubCloud_Foto UpdateFoto(string bondsnummer, Guid verenigingId, ClubCloud_Foto foto)
        {
            ClubCloud_Foto response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.UpdateFoto(bondsnummer, verenigingId, foto);
                },
                false);

            return response;
        }

        #endregion

        #region Sponsor

        public List<ClubCloud_Sponsor> GetSponsorenByVerenigingId(string bondsnummer, Guid verenigingId, bool refresh)
        {
            List<ClubCloud_Sponsor> response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetSponsorenByVerenigingId(bondsnummer, verenigingId, refresh);
                },
                false);

            return response;
        }

        public ClubCloud_Sponsor GetSponsorById(string bondsnummer, Guid verenigingId, Guid sponsorId, bool refresh)
        {
            ClubCloud_Sponsor response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetSponsorById(bondsnummer, verenigingId, sponsorId, refresh);
                },
                false);

            return response;
        }

        public ClubCloud_Sponsor_Afbeelding GetSponsorImageById(string bondsnummer, Guid verenigingId, Guid afbeeldingId, bool refresh)
        {
            ClubCloud_Sponsor_Afbeelding response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetSponsorImageById(bondsnummer, verenigingId, afbeeldingId, refresh);
                },
                false);

            return response;
        }

        #endregion

        #region Administratie

        # region Meta

        public void TriggerMetaData(string bondsnummer, bool refresh)
        {
            this.ExecuteOnChannel<IClubCloudApplicationService>(
            delegate(IClubCloudApplicationService channel)
            {
                channel.TriggerMetaData(bondsnummer, refresh);
            }, false);

            return;
        }

        public void NationaliteitenUpdate(string bondsnummer, bool refresh)
        {
            this.ExecuteOnChannel<IClubCloudApplicationService>(
            delegate(IClubCloudApplicationService channel)
            {
                channel.NationaliteitenUpdate(bondsnummer, refresh);
            },false);

            return;
        }

        public void DistrictenUpdate(string bondsnummer, bool refresh)
        {
            this.ExecuteOnChannel<IClubCloudApplicationService>(
            delegate(IClubCloudApplicationService channel)
            {
                channel.DistrictenUpdate(bondsnummer, refresh);
            }, false);

            return;
        }

        public void RechtsvormenUpdate(string bondsnummer, bool refresh)
        {
            this.ExecuteOnChannel<IClubCloudApplicationService>(
            delegate(IClubCloudApplicationService channel)
            {
                channel.RechtsvormenUpdate(bondsnummer, refresh);
            }, false);

            return;
        }

        public void FunctiesUpdate(string bondsnummer, bool refresh)
        {
            this.ExecuteOnChannel<IClubCloudApplicationService>(
            delegate(IClubCloudApplicationService channel)
            {
                channel.FunctiesUpdate(bondsnummer, refresh);
            }, false);

            return;
        }

        public void BestuursOrganenUpdate(string bondsnummer, bool refresh)
        {
            this.ExecuteOnChannel<IClubCloudApplicationService>(
            delegate(IClubCloudApplicationService channel)
            {
                channel.BestuursOrganenUpdate(bondsnummer, refresh);
            }, false);

            return;
        }

        public void LidmaatschapSoortenUpdate(string bondsnummer, bool refresh)
        {
            this.ExecuteOnChannel<IClubCloudApplicationService>(
            delegate(IClubCloudApplicationService channel)
            {
                channel.LidmaatschapSoortenUpdate(bondsnummer, refresh);
            }, false);

            return;
        }

        public void RegiosUpdate(string bondsnummer, bool refresh)
        {
            this.ExecuteOnChannel<IClubCloudApplicationService>(
            delegate(IClubCloudApplicationService channel)
            {
                channel.RegiosUpdate(bondsnummer, refresh);
            }, false);

            return;
        }

        public void ToplagenUpdate(string bondsnummer, bool refresh)
        {
            this.ExecuteOnChannel<IClubCloudApplicationService>(
            delegate(IClubCloudApplicationService channel)
            {
                channel.ToplagenUpdate(bondsnummer, refresh);
            }, false);

            return;
        }

        public void BaansoortenUpdate(string bondsnummer, bool refresh)
        {
            this.ExecuteOnChannel<IClubCloudApplicationService>(
            delegate(IClubCloudApplicationService channel)
            {
                channel.BaansoortenUpdate(bondsnummer, refresh);
            }, false);

            return;
        }

        public void BaantypesUpdate(string bondsnummer, bool refresh)
        {
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    channel.BaantypesUpdate(bondsnummer, refresh);
                }, false);

            return;
        }

        public void BanenSpeciaalUpdate(string bondsnummer, bool refresh)
        {
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    channel.BanenSpeciaalUpdate(bondsnummer, refresh);
                }, false);

            return;
        }

        public void BaanBlokkenUpdate(string bondsnummer, bool refresh)
        {
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    channel.BaanBlokkenUpdate(bondsnummer, refresh);
                }, false);

            return;
        }

        public void BanenUpdate(string bondsnummer, bool refresh)
        {
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    channel.BanenUpdate(bondsnummer, refresh);
                }, false);

            return;
        }

        public bool VerenigingenUpdate(string bondsnummer, int pageNum, bool refresh)
        {
            bool response = false;
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.VerenigingenUpdate(bondsnummer, pageNum, refresh);
                },
                false);

            return response;
        }

        #endregion

        public ClubCloud_Gebruiker CreateGebruiker(ClubCloud_Gebruiker gebruiker)
        {
            ClubCloud_Gebruiker response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.CreateGebruiker(gebruiker);
                },
                false);

            return response;

        }


        public void LidmaatschappenUpdate(string bondsnummer, Guid verenigingId, bool refresh)
        {
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    channel.LidmaatschappenUpdate(bondsnummer, verenigingId, refresh);
                },
                false);

            return;
        }

        public void VerenigingZimbra(string bondsnummer, ClubCloud_Vereniging vereniging)
        {
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    channel.VerenigingZimbra(bondsnummer, vereniging);
                },
                true);

            return;

        }

        public void GebruikerZimbra(string bondsnummer, ClubCloud_Gebruiker gebruiker)
        {
            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    channel.GebruikerZimbra(bondsnummer, gebruiker);
                },
                true);

            return;

        }

        public List<ClubCloud_Functionaris> GetFunctionarissen()
        {
            List<ClubCloud_Functionaris> response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetFunctionarissen();
                },
                false);

            return response;
        }

        public List<ClubCloud_Vereniging> GetVerenigingen()
        {
            List<ClubCloud_Vereniging> response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetVerenigingen();
                },
                false);

            return response;
        }

        public List<ClubCloud_Accommodatie> GetAccomodaties()
        {
            List<ClubCloud_Accommodatie> response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetAccommodaties();
                },
                false);

            return response;
        }

        #endregion

        #region Competitie

        /*
        public List<Competitie> GetCompetitiesAfgelopenJaar(string bondsnummer, bool refresh = false)
        {
            List<Competitie> response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetCompetitiesAfgelopenJaar(bondsnummer, refresh);
                },
                false);

            return response;

        }

        public List<Guid> GetCompetitiesForInschrijving(string bondsnummer, Guid verenigingId, Guid districtId, bool refresh = false)
        {
            List<Guid> response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetCompetitiesForInschrijving(bondsnummer, verenigingId, districtId, refresh);
                },
                false);

            return response;

        }

        public List<ClubCloud_Vereniging_Competitie> GetCompetitiesForVereniging(string bondsnummer, Guid verenigingId, bool refresh = false)
        {
            List<ClubCloud_Vereniging_Competitie> response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetCompetitiesForVereniging(bondsnummer,verenigingId, refresh);
                },
                false);

            return response;

        }

        public List<Competitie> GetCompetitiesMijnKnltb(string bondsnummer, bool refresh = false)
        {
            List<Competitie> response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetCompetitiesMijnKnltb(bondsnummer, refresh);
                },
                false);

            return response;

        }

        public List<Klassengroep> GetKlassengroepen(string bondsnummer, Guid competitieId, bool refresh = false)
        {
            List<Klassengroep> response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetKlassengroepen(bondsnummer,competitieId, refresh);
                },
                false);

            return response;

        }

        public List<Klassengroep> GetKlassengroepenForInschrijvingGeopend(string bondsnummer, Guid verenigingId, Guid competitieId, bool refresh = false)
        {
            List<Klassengroep> response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetKlassengroepenForInschrijvingGeopend(bondsnummer, verenigingId, competitieId, refresh);
                },
                false);

            return response;

        }

        public List<Klassengroep> GetKlassengroepenForInschrijvingGeopendEnGesloten(string bondsnummer, Guid verenigingId, Guid competitieId, bool refresh = false)
        {
            List<Klassengroep> response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetKlassengroepenForInschrijvingGeopendEnGesloten(bondsnummer, verenigingId, competitieId, refresh);
                },
                false);

            return response;

        }

        public List<Partijresultaat> GetPartijresultaten(string bondsnummer, Guid wedstrijdgegevenId, bool refresh = false)
        {
            List<Partijresultaat> response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetPartijresultaten(bondsnummer, wedstrijdgegevenId, refresh);
                },
                false);

            return response;

        }

        public List<Ploeg> GetPloegen(string bondsnummer, Guid competitieId, bool refresh = false)
        {
            List<Ploeg> response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetPloegen(bondsnummer, competitieId, refresh);
                },
                false);

            return response;

        }

        public List<Stand> GetStandenByAfdeling(string bondsnummer, Guid afdelingId, Guid competitieId, bool refresh = false)
        {
            List<Stand> response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetStandenByAfdeling(bondsnummer,afdelingId, competitieId, refresh);
                },
                false);

            return response;

        }

        public List<Stand> GetStandenByPloeg(string bondsnummer, Guid ploegId, Guid competitieId, bool refresh = false)
        {
            List<Stand> response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetStandenByPloeg(bondsnummer, ploegId, competitieId, refresh);
                },
                false);

            return response;

        }

        public List<Stand> GetStandenByVereniging(string bondsnummer, Guid verenigingId, Guid competitieId, bool refresh = false)
        {
            List<Stand> response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetStandenByVereniging(bondsnummer, verenigingId, competitieId, refresh);
                },
                false);

            return response;

        }

        public List<UitslagAfdeling> GetUitslagenAfdeling(string bondsnummer, Guid afdelingId, Guid competitieId, Guid piramideId, bool refresh = false)
        {
            List<UitslagAfdeling> response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetUitslagenAfdeling(bondsnummer, afdelingId,competitieId, piramideId, refresh);
                },
                false);

            return response;

        }

        public List<Wedstrijdgegevens> GetWedstrijdgegevensForAfdeling(string bondsnummer, Guid competitieId, Guid afdelingId, bool refresh = false)
        {
            List<Wedstrijdgegevens> response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetWedstrijdgegevensForAfdeling(bondsnummer, competitieId, afdelingId, refresh);
                },
                false);

            return response;

        }

        public List<Wedstrijdgegevens> GetWedstrijdgegevensForVereniging(string bondsnummer, Guid competitieId, Guid verenigingId, bool refresh = false)
        {
            List<Wedstrijdgegevens> response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetWedstrijdgegevensForVereniging(bondsnummer, competitieId, verenigingId, refresh);
                },
                false);

            return response;

        }

        public List<Wedstrijdgegevens> GetWedstrijdgegevensForWedstrijdgegeven(string bondsnummer, Guid competitieId, Guid wedstrijdgegevenId, bool refresh = false)
        {
            List<Wedstrijdgegevens> response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetWedstrijdgegevensForWedstrijdgegeven(bondsnummer, competitieId, wedstrijdgegevenId, refresh);
                },
                false);

            return response;

        }
        */
        #endregion

        #region Packages
        public  List<ApplicationInfo> GetApplications()
        {
            List<ApplicationInfo> response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetApplications();
                },
                false);

            return response;
        }


        public ApplicationInfo GetApplicationInfoByName(string applicationName)
        {
            ApplicationInfo response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetApplicationInfoByName(applicationName);
                },
                false);

            return response;
        }

        internal ApplicationInfo SetApplicationInfo(ApplicationInfo applicationInfo)
        {
            ApplicationInfo response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetApplicationInfo(applicationInfo);
                },
                false);

            return response;

        }

        internal ApplicationVersion SetApplicationVersion(int applicationInfoId, ApplicationVersion applicationVersion)
        {
            ApplicationVersion response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetApplicationVersion(applicationInfoId, applicationVersion);
                },
                false);

            return response;

        }

        internal ApplicationProcessorArchitecture SetApplicationProcessorArchitecture(int applicationVersionId, ApplicationProcessorArchitecture applicationProcessorArchitecture)
        {
            ApplicationProcessorArchitecture response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetApplicationProcessorArchitecture(applicationVersionId, applicationProcessorArchitecture);
                },
                false);

            return response;
        }

        internal List<ApplicationInfo> GetApplicationInfos()
        {
            List<ApplicationInfo> response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetApplicationInfos();
                },
                false);

            return response;
        }

        internal ApplicationVersion GetApplicationVersion(int applicationInfoId, string version)
        {
            ApplicationVersion response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetApplicationVersion(applicationInfoId, version);
                },
                false);

            return response;
        }

        internal List<ApplicationProcessorArchitecture> GetApplicationProcessorArchitecture(int applicationVersionId, string version)
        {
            List<ApplicationProcessorArchitecture> response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetApplicationProcessorArchitecture(applicationVersionId, version);
                },
                false);

            return response;
        }

        #endregion
    }
}