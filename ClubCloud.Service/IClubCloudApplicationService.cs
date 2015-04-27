//-----------------------------------------------------------------------
// <copyright file="IHelloWorldWCFService.cs" company="">
// Copyright © 
// </copyright>
//-----------------------------------------------------------------------

namespace ClubCloud.Service
{
    using ClubCloud.Model;
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
    internal partial interface IClubCloudApplicationService
    {
        #region Methods    

        #region MetaData
        /*
        [OperationContract]
        void CheckDatabaseExists();
        */
        #endregion

        #region Mijn

        #region Set

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Setting))]
        ClubCloud_Setting SetClubCloudSettings(ClubCloud_Setting settings);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Setting))]
        ClubCloud_Setting SetMijnKNLTB(ClubCloud_Setting settings);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Gebruiker))]
        bool SetClubCloudGebruiker(string bondsnummer, Guid verenigingId, ClubCloud_Gebruiker gebruiker, bool refresh = false);


        #endregion

        #region Get

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Setting))]
        ClubCloud_Setting GetClubCloudSettings(string bondsnummer);

        #endregion





        #endregion


        #region Gebruiker

        /*
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Setting))]
        ClubCloud_Setting SetPrivacy(ClubCloud_Setting settings);
        */


        /*
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
        */


        /*
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Gebruiker))]
        ClubCloud_Gebruiker GetClubCloudGebruiker(string bondsnummer, bool refresh = false);
        */

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
        /*
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
        ClubCloud_Vereniging GetVerenigingById(string bondsnummer, Guid verenigingId, bool refresh = false);
        */
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
        System.Collections.Generic.List<ClubCloud.Model.ClubCloud_Vereniging_Competitie> GetCompetitiesForVereniging(string bondsnummer, Guid verenigingId, bool refresh = false);
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

        /*
        [OperationContract]
        bool CreateClubCloudWebSite(string verenigingsummer);
        */
        #endregion

        #region Afhangen

        /*
        [OperationContract]
        bool DeleteReservering(string bondsnummer, Guid verenigingId, Guid reserveringId, bool push = false);
        */

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Gebruiker))]
        System.Collections.Generic.List<ClubCloud.Model.ClubCloud_Gebruiker> GetGebruikersForReserveringById(string bondsnummer, Guid verenigingId, Guid reserveringId, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Reservering))]
        ClubCloud.Model.ClubCloud_Reservering GetReserveringByReserveringId(string bondsnummer, Guid verenigingId, Guid reserveringId, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Reservering))]
        System.Collections.Generic.List<ClubCloud.Model.ClubCloud_Reservering> GetReserveringenByBaanId(string bondsnummer, Guid verenigingId, Guid baanId, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Reservering))]
        System.Collections.Generic.List<ClubCloud.Model.ClubCloud_Reservering> GetReserveringenByBondsnummer(string bondsnummer, Guid verenigingId, string nummer, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Reservering))]
        System.Collections.Generic.List<ClubCloud_Reservering> GetReserveringenByDate(string bondsnummer, Guid verenigingId, DateTime date, bool refresh);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Reservering))]
        System.Collections.Generic.List<ClubCloud.Model.ClubCloud_Reservering> GetReserveringenByVerenigingId(string bondsnummer, Guid verenigingId, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
        ClubCloud.Model.ClubCloud_Vereniging GetVerenigingByLocation(string bondsnummer, double Latitude, double Longitude, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
        ClubCloud.Model.ClubCloud_Vereniging GetVerenigingByNummer(string bondsnummer, string verenigingNummer, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Reservering))]
        [ServiceKnownType(typeof(ReserveringSoort))]
        ClubCloud.Model.ClubCloud_Reservering AddReservering(string bondsnummer, Guid verenigingId, Guid baanId, Guid[] gebruikers, DateTime Datum, TimeSpan Tijd, TimeSpan Duur, ClubCloud.Model.ReserveringSoort Soort = ReserveringSoort.Afhangen, bool final = false, bool push = false, string Beschrijving = "");

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Reservering))]
        ClubCloud.Model.ClubCloud_Reservering UpdateReservering(string bondsnummer, Guid verenigingId, ClubCloud.Model.ClubCloud_Reservering reservering, bool final = false, bool push = false);

        #endregion

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Gebruiker))]
        ClubCloud_Gebruiker GetGebruikerByNummer(string bondsnummer, Guid verenigingId, string nummer, bool refresh = false);
        /*
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Gebruiker))]
        ClubCloud_Gebruiker GetGebruikerById(string bondsnummer, Guid verenigingId, Guid gebruikerId, bool refresh = false);
        */

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Address))]
        List<ClubCloud_Address> GetAddressByGebruikerId(string bondsnummer, Guid verenigingId, Guid gebruikerId, bool refresh = false);

        /*
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Gebruiker_DataView))]
        [ServiceKnownType(typeof(DataSourceSelectArguments))]
        [ServiceKnownType(typeof(Parameter))]
        ClubCloud_Gebruiker_DataView GetGebruikersByQuery(string bondsnummer, Guid verenigingId, DataSourceSelectArguments selectArgs = null, List<Parameter> parameters = null, bool refresh = false);
        */

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Afhang))]
        ClubCloud_Afhang GetVerenigingAfhangSettings(string bondsnummer, Guid verenigingId, bool refresh);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Afhang))]
        ClubCloud_Afhang SetVerenigingAfhangSettings(string bondsnummer, Guid verenigingId, ClubCloud_Afhang afhang, bool refresh);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Lidmaatschap))]
        List<ClubCloud_Lidmaatschap> GetLidmaatschapByGebruikerId(string bondsnummer, Guid verenigingId, Guid gebruikerId, bool refresh = false);

        /*
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Gebruiker))]
        List<ClubCloud_Gebruiker> GetGebruikersBySearch(string bondsnummer, string prefixText, int count, bool refresh = false);
        */

        /*
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Accommodatie))]
        ClubCloud_Accommodatie GetAccommodatieById(string bondsnummer, Guid accommodatieId, bool refresh);
        */

        #region Banen

        /*
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baanschema))]
        System.Collections.Generic.List<ClubCloud.Model.ClubCloud_Baanschema> GetBaanSchemaByAccommodatieId(string bondsnummer, Guid verenigingId, Guid accommodatieId, bool refresh = false);
        */
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baanschema))]
        System.Collections.Generic.List<ClubCloud.Model.ClubCloud_Baanschema> GetBaanSchemaByVerenigingId(string bondsnummer, Guid verenigingId, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baanschema))]
        System.Collections.Generic.List<ClubCloud_Baanschema> GetBaanSchemaByDate(string bondsnummer, Guid verenigingId, DateTime date, bool refresh = false);
        /*
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baan))]
        System.Collections.Generic.List<ClubCloud.Model.ClubCloud_Baan> GetBanenByAccommodatieId(string bondsnummer, Guid verenigingId, Guid accommodatieId, bool refresh = false);
        */
        /*
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baan))]
        System.Collections.Generic.List<ClubCloud.Model.ClubCloud_Baan> GetBanenByVerenigingId(string bondsnummer, Guid verenigingId, bool refresh = false);
        */
        /*
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baan))]
        ClubCloud_Baan GetBaanById(string bondsnummer, Guid verenigingId, Guid baanId, bool refresh = false);
        */

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baanblok))]
        List<ClubCloud_Baanblok> GetBaanblokkenByAccommodatieId(string bondsnummer, Guid verenigingId, Guid accommodatieId, bool refresh);

        /*
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baansoort))]
        ClubCloud_Baansoort GetBaansoortById(string bondsnummer, Guid verenigingId, Guid accommodatieId, Guid baansoortId, bool refresh);
        */
        /*
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baantype))]
        ClubCloud_Baantype GetBaantypeById(string bondsnummer, Guid verenigingId, Guid accommodatieId, Guid BaantypeId, bool refresh);
        */
        #endregion

        #region SignalR

        [OperationContract]
        string ScaleOutConnection(string catalog);

        #endregion

        #region Foto

        #region Get

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Foto))]
        ClubCloud_Foto GetFotoForGebruikerById(string bondsnummer, Guid Id, bool refresh = false, ClubCloud_Setting settings = null);

        /*
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Foto))]
        ClubCloud_Foto GetFotoByNummer(string bondsnummer, Guid verenigingId, string nummer, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Foto))]
        ClubCloud_Foto GetFotoById(string bondsnummer, Guid verenigingId, Guid gebruikerId, bool refresh = false);
        */
        #endregion

        #region Set
        /*
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Foto))]
        ClubCloud_Foto UpdateFoto(string bondsnummer, Guid verenigingId, ClubCloud_Foto foto);
        */
        #endregion

        #endregion

        #region Sponsor

        #region Get
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Sponsor))]
        List<ClubCloud_Sponsor> GetSponsorenByVerenigingId(string bondsnummer, Guid verenigingId, bool refresh);

        /*
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Sponsor))]
        ClubCloud_Sponsor GetSponsorById(string bondsnummer, Guid verenigingId, Guid sponsorId, bool refresh);
        */

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Sponsor_Afbeelding))]
        ClubCloud_Sponsor_Afbeelding GetSponsorImageById(string bondsnummer, Guid verenigingId, Guid afbeeldingId, bool refresh);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Sponsor))]
        List<ClubCloud_Sponsor> GetSponsorImageUsageById(string bondsnummer, Guid verenigingId, Guid imageId, bool refresh);

        #endregion

        #region Set
        /*
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Sponsor))]
        ClubCloud_Sponsor SetSponsor(ClubCloud_Sponsor sponsor);
        */
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Sponsor_Afbeelding))]
        ClubCloud_Sponsor_Afbeelding SetSponsorImage(ClubCloud_Sponsor_Afbeelding afbeelding);

        #endregion

        #region Delete
        /*
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Sponsor))]
        bool DeleteSponsor(ClubCloud_Sponsor sponsor);
        */
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Sponsor_Afbeelding))]
        bool DeleteSponsorImage(ClubCloud_Sponsor_Afbeelding afbeelding);

        #endregion

        #endregion

        #region Administrator

        [OperationContract]
        void TriggerMetaData(string bondsnummer, bool refresh);

        [OperationContract]
        void BestuursOrganenUpdate(string bondsnummer, bool refresh);

        [OperationContract]
        void LidmaatschapSoortenUpdate(string bondsnummer, bool refresh);

        [OperationContract]
        void ToplagenUpdate(string bondsnummer, bool refresh);

        [OperationContract]
        void BaansoortenUpdate(string bondsnummer, bool refresh);

        [OperationContract]
        void BaantypesUpdate(string bondsnummer, bool refresh);

        [OperationContract]
        bool VerenigingenUpdate(string bondsnummer, int pageNum = 1, bool refresh = false);

        [OperationContract]
        bool GebruikersUpdate(string bondsnummer, string verenigingNummer, int pageNum = 1, bool refresh = false);

        [OperationContract]
        void NationaliteitenUpdate(string bondsnummer, bool refresh);

        [OperationContract]
        void DistrictenUpdate(string bondsnummer, bool refresh);

        [OperationContract]
        void RechtsvormenUpdate(string bondsnummer, bool refresh);

        [OperationContract]
        void FunctiesUpdate(string bondsnummer, bool refresh);

        [OperationContract]
        void RegiosUpdate(string bondsnummer, bool refresh);

        [OperationContract]
        void BanenSpeciaalUpdate(string bondsnummer, bool refresh);

        [OperationContract]
        void BaanBlokkenUpdate(string bondsnummer, bool refresh);

        [OperationContract]
        void BanenUpdate(string bondsnummer, bool refresh);

        [OperationContract]
        void VerenigingZimbra(string bondsnummer, ClubCloud_Vereniging vereniging);

        [OperationContract]
        void GebruikerZimbra(string bondsnummer, ClubCloud_Gebruiker gebruiker);
        /*
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Functionaris))]
        List<ClubCloud_Functionaris> GetFunctionarissen();
        */
        /*
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
        List<ClubCloud_Vereniging> GetVerenigingen();
        */
        /*
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Accommodatie))]
        List<ClubCloud_Accommodatie> GetAccommodaties();
        */

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Gebruiker))]
        ClubCloud_Gebruiker CreateGebruiker(ClubCloud_Gebruiker gebruiker);

        [OperationContract]
        void LidmaatschappenUpdate(string bondsnummer, Guid verenigingId, bool refresh = false);

        #endregion

        #region Packages
        [OperationContract]
        List<ApplicationInfo> GetApplications();        

        [OperationContract]
        ApplicationInfo GetApplicationInfoByName(string applicationName);

        [OperationContract]
        ApplicationInfo SetApplicationInfo(ApplicationInfo applicationInfo);

        [OperationContract]
        ApplicationVersion SetApplicationVersion(int applicationInfoId, ApplicationVersion applicationVersion);

        [OperationContract]
        ApplicationProcessorArchitecture SetApplicationProcessorArchitecture(int applicationVersionId, ApplicationProcessorArchitecture applicationProcessorArchitecture);

        [OperationContract]
        List<ApplicationInfo> GetApplicationInfos();

        [OperationContract]
        ApplicationVersion GetApplicationVersion(int applicationInfoId, string version);

        [OperationContract]
        List<ApplicationProcessorArchitecture> GetApplicationProcessorArchitecture(int applicationVersionId, string version);

        #endregion        
    }
}
