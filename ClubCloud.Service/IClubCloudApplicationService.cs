//-----------------------------------------------------------------------
// <copyright file="IHelloWorldWCFService.cs" company="">
// Copyright © 
// </copyright>
//-----------------------------------------------------------------------

namespace ClubCloud.Service
{
    using ClubCloud.Service.Model;
    using System;
    using System.Collections.Generic;
    using System.ServiceModel;
    using System.ServiceModel.Description;
    using System.Web.UI;
    using System.Web.UI.WebControls;

    /// <summary>
    /// The Service Contract.
    /// </summary>
    [ServiceContract(Namespace = "http://clubcloud.nl/", Name = "ClubCloudService")]
    [System.Runtime.InteropServices.Guid("23c6e4c4-d8d7-4bef-8d11-420c88bbefc2")]
    internal interface IClubCloudApplicationService
    {
        #region Methods    

        #region MetaData

        [OperationContract]
        void CheckDatabaseExists();

        #endregion

        #region Gebruiker

        /*
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Gebruiker))]
        ClubCloud_Gebruiker GetClubCloudUser(string user, bool refresh = false);
        */

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Setting))]
        ClubCloud_Setting SetPrivacy(ClubCloud_Setting settings);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Setting))]
        ClubCloud_Setting SetMijnKNLTB(ClubCloud_Setting settings);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Setting))]
        ClubCloud_Setting SetTwitter(ClubCloud_Setting settings);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Setting))]
        ClubCloud_Setting SetFaceBook(ClubCloud_Setting settings);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Setting))]
        ClubCloud_Setting SetFinancieel(ClubCloud_Setting settings);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Setting))]
        ClubCloud_Setting SetTracking(ClubCloud_Setting settings);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Setting))]
        ClubCloud_Setting GetClubCloudSettings(string bondsnummer);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Gebruiker))]
        ClubCloud_Gebruiker GetClubCloudGebruiker(string bondsnummer, bool refresh = false);

        /*
        [OperationContract]
        [ServiceKnownType(typeof(SpelersProfiel))]
        SpelersProfiel GetSpelersProfiel(string bondsnummer, bool refresh = false);
        */

        /*
        [OperationContract]
        [ServiceKnownType(typeof(SpelerTracking))]
        ClubCloud_Tracking GetTracking(string bondsnummer, bool refresh = false);
        */

        #endregion

        #region Club

        /*
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
        List<ClubCloud_Vereniging> GetVerenigingen(string bondsnummer, bool refresh = false);
        */
        
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
        ClubCloud_Vereniging GetVerenigingById(string bondsnummer, Guid verenigingId, bool refresh = false);
        

        /*
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
        ClubCloud_Vereniging GetVerenigingByNummer(string bondsnummer, string vereniginsnummer, bool refresh = false);
        */

        /*
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Accomodatie))]
        ClubCloud_Accomodatie GetAccommodatieForVereniging(string bondsnummer, Guid verenigingId, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Accomodatie))]
        ClubCloud_Accomodatie GetAccommodatie(string bondsnummer, Guid accommodatieId, bool refresh = false);
        */

        /*
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging_BestuursLid))]
        List<ClubCloud_Vereniging_BestuursLid> GetBestuurForVereniging(string bondsnummer, Guid verenigingId, bool refresh = false);
        */
        /*
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_District))]
        List<ClubCloud_District> GetDistricten(string bondsnummer, bool refresh = false);
        */
        #endregion

        #region Competitie
        /*
        [OperationContract]
        System.Collections.Generic.List<Guid> GetCompetitiesForInschrijving(string bondsnummer, Guid verenigingId, Guid districtId, bool refresh = false);
        */
        /*
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging_Competitie))]
        System.Collections.Generic.List<ClubCloud.Service.Model.ClubCloud_Vereniging_Competitie> GetCompetitiesForVereniging(string bondsnummer, Guid verenigingId, bool refresh = false);
        [OperationContract]
        [ServiceKnownType(typeof(Klassengroep))]
        System.Collections.Generic.List<ClubCloud.KNLTB.ServIt.CompetitieService.Klassengroep> GetKlassengroepen(string bondsnummer, Guid competitieId, bool refresh = false);
        [OperationContract]
        [ServiceKnownType(typeof(Klassengroep))]
        System.Collections.Generic.List<ClubCloud.KNLTB.ServIt.CompetitieService.Klassengroep> GetKlassengroepenForInschrijvingGeopend(string bondsnummer, Guid verenigingId, Guid competitieId, bool refresh = false);
        [OperationContract]
        [ServiceKnownType(typeof(Klassengroep))]
        System.Collections.Generic.List<ClubCloud.KNLTB.ServIt.CompetitieService.Klassengroep> GetKlassengroepenForInschrijvingGeopendEnGesloten(string bondsnummer, Guid verenigingId, Guid competitieId, bool refresh = false);
        [OperationContract]
        [ServiceKnownType(typeof(Partijresultaat))]
        System.Collections.Generic.List<ClubCloud.KNLTB.ServIt.CompetitieService.Partijresultaat> GetPartijresultaten(string bondsnummer, Guid wedstrijdgegevenId, bool refresh = false);
        [OperationContract]
        [ServiceKnownType(typeof(Ploeg))]
        System.Collections.Generic.List<ClubCloud.KNLTB.ServIt.CompetitieService.Ploeg> GetPloegen(string bondsnummer, Guid competitieId, bool refresh = false);
        [OperationContract]
        [ServiceKnownType(typeof(Competitie))]
        System.Collections.Generic.List<ClubCloud.KNLTB.ServIt.CompetitieService.Competitie> GetCompetitiesAfgelopenJaar(string bondsnummer, bool refresh = false);
        [OperationContract]
        [ServiceKnownType(typeof(Competitie))]
        System.Collections.Generic.List<ClubCloud.KNLTB.ServIt.CompetitieService.Competitie> GetCompetitiesMijnKnltb(string bondsnummer, bool refresh = false);
        [OperationContract]
        [ServiceKnownType(typeof(Stand))]
        System.Collections.Generic.List<ClubCloud.KNLTB.ServIt.CompetitieService.Stand> GetStandenByAfdeling(string bondsnummer, Guid afdelingId, Guid competitieId, bool refresh = false);
        [OperationContract]
        [ServiceKnownType(typeof(Stand))]
        System.Collections.Generic.List<ClubCloud.KNLTB.ServIt.CompetitieService.Stand> GetStandenByPloeg(string bondsnummer, Guid ploegId, Guid competitieId, bool refresh = false);
        [OperationContract]
        [ServiceKnownType(typeof(Stand))]
        System.Collections.Generic.List<ClubCloud.KNLTB.ServIt.CompetitieService.Stand> GetStandenByVereniging(string bondsnummer, Guid verenigingId, Guid competitieId, bool refresh = false);
        [OperationContract]
        [ServiceKnownType(typeof(UitslagAfdeling))]
        System.Collections.Generic.List<ClubCloud.KNLTB.ServIt.CompetitieService.UitslagAfdeling> GetUitslagenAfdeling(string bondsnummer, Guid afdelingId, Guid competitieId, Guid piramideId, bool refresh = false);
        [OperationContract]
        [ServiceKnownType(typeof(Wedstrijdgegevens))]
        System.Collections.Generic.List<ClubCloud.KNLTB.ServIt.CompetitieService.Wedstrijdgegevens> GetWedstrijdgegevensForAfdeling(string bondsnummer, Guid competitieId, Guid afdelingId, bool refresh = false);
        [OperationContract]
        [ServiceKnownType(typeof(Wedstrijdgegevens))]
        System.Collections.Generic.List<ClubCloud.KNLTB.ServIt.CompetitieService.Wedstrijdgegevens> GetWedstrijdgegevensForVereniging(string bondsnummer, Guid competitieId, Guid verenigingId, bool refresh = false);
        [OperationContract]
        [ServiceKnownType(typeof(Wedstrijdgegevens))]
        System.Collections.Generic.List<ClubCloud.KNLTB.ServIt.CompetitieService.Wedstrijdgegevens> GetWedstrijdgegevensForWedstrijdgegeven(string bondsnummer, Guid competitieId, Guid wedstrijdgegevenId, bool refresh = false);
        */
        #endregion


        [OperationContract]
        bool CreateClubCloudWebSite(string verenigingsummer);
        #endregion

        [OperationContract]
        bool SetClubCloudGebruiker(string bondsnummer, ClubCloud_Gebruiker gebruiker, bool refresh);

        #region Afhangen

        [OperationContract]
        bool DeleteReservering(string bondsnummer, Guid verenigingId, Guid reserveringId, bool push = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baanschema))]
        System.Collections.Generic.List<ClubCloud.Service.Model.ClubCloud_Baanschema> GetBaanSchemaByAccommodatieId(string bondsnummer, Guid verenigingId, Guid accommodatieId, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baanschema))]
        System.Collections.Generic.List<ClubCloud.Service.Model.ClubCloud_Baanschema> GetBaanSchemaByVerenigingId(string bondsnummer, Guid verenigingId, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baan))]
        System.Collections.Generic.List<ClubCloud.Service.Model.ClubCloud_Baan> GetBanenByAccommodatieId(string bondsnummer, Guid verenigingId, Guid accommodatieId, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baan))]
        System.Collections.Generic.List<ClubCloud.Service.Model.ClubCloud_Baan> GetBanenByVerenigingId(string bondsnummer, Guid verenigingId, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Gebruiker))]
        System.Collections.Generic.List<ClubCloud.Service.Model.ClubCloud_Gebruiker> GetGebruikersByReserveringId(string bondsnummer, Guid verenigingId, Guid reserveringId, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Reservering))]
        ClubCloud.Service.Model.ClubCloud_Reservering GetReserveringByReserveringId(string bondsnummer, Guid verenigingId, Guid reserveringId, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Reservering))]
        System.Collections.Generic.List<ClubCloud.Service.Model.ClubCloud_Reservering> GetReserveringenByBaanId(string bondsnummer, Guid verenigingId, Guid baanId, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Reservering))]
        System.Collections.Generic.List<ClubCloud.Service.Model.ClubCloud_Reservering> GetReserveringenByBondsnummer(string bondsnummer, Guid verenigingId, string nummer, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Reservering))]
        System.Collections.Generic.List<ClubCloud.Service.Model.ClubCloud_Reservering> GetReserveringenByVerenigingId(string bondsnummer, Guid verenigingId, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
        ClubCloud.Service.Model.ClubCloud_Vereniging GetVerenigingByLocation(string bondsnummer, double Latitude, double Longitude, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
        ClubCloud.Service.Model.ClubCloud_Vereniging GetVerenigingByNummer(string bondsnummer, string verenigingNummer, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Reservering))]
        ClubCloud.Service.Model.ClubCloud_Reservering SetReservering(string bondsnummer, Guid verenigingId, Guid baanId, Guid[] gebruikers, DateTime tijd, bool final = false, bool push = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Reservering))]
        ClubCloud.Service.Model.ClubCloud_Reservering UpdateReservering(string bondsnummer, Guid verenigingId, ClubCloud.Service.Model.ClubCloud_Reservering reservering, bool final = false, bool push = false);

        #endregion

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Gebruiker))]
        ClubCloud_Gebruiker GetGebruikerByNummer(string bondsnummer, Guid verenigingId, string nummer, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Foto))]
        ClubCloud_Foto GetFotoByNummer(string bondsnummer, Guid verenigingId, string nummer, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Gebruiker))]
        ClubCloud_Gebruiker GetGebruikerById(string bondsnummer, Guid verenigingId, Guid gebruikerId, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Foto))]
        ClubCloud_Foto GetFotoById(string bondsnummer, Guid verenigingId, Guid gebruikerId, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Address))]
        List<ClubCloud_Address> GetAddressByGebruikerId(string bondsnummer, Guid verenigingId, Guid gebruikerId, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baan))]
        ClubCloud_Baan GetBaanById(string bondsnummer, Guid verenigingId, Guid baanId, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Gebruiker_DataView))]
        [ServiceKnownType(typeof(DataSourceSelectArguments))]
        [ServiceKnownType(typeof(Parameter))]
        ClubCloud_Gebruiker_DataView GetGebruikersByQuery(string bondsnummer, Guid verenigingId, DataSourceSelectArguments selectArgs = null, List<Parameter> parameters = null, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Afhang))]
        ClubCloud_Afhang GetVerenigingSettings(string bondsnummer, Guid verenigingId, bool refresh);
    }
}
