﻿//-----------------------------------------------------------------------
// <copyright file="IHelloWorldWCFService.cs" company="">
// Copyright © 
// </copyright>
//-----------------------------------------------------------------------

namespace ClubCloud.Service
{
    using ClubCloud.KNLTB.ServIt.CompetitieService;
    using ClubCloud.KNLTB.ServIt.LedenAdministratieService;
    using ClubCloud.Service.Model;
    using System;
    using System.Collections.Generic;
    using System.ServiceModel;
    using System.ServiceModel.Description;

    /// <summary>
    /// The Service Contract.
    /// </summary>
    [ServiceContract(Namespace = "http://clubcloud.nl/", Name = "ClubCloudService")]
    [System.Runtime.InteropServices.Guid("23c6e4c4-d8d7-4bef-8d11-420c88bbefc2")]
    internal interface IClubCloudApplicationService
    {
        #region Methods    

        #region MetaData

        /*
        [OperationContract]
        string GetPostcode(string postcode, int huisnummer);
        */

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

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
        ClubCloud_Vereniging GetVerenigingByNummer(string bondsnummer, string vereniginsnummer, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Accomodatie))]
        ClubCloud_Accomodatie GetAccommodatieForVereniging(string bondsnummer, Guid verenigingId, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Accomodatie))]
        ClubCloud_Accomodatie GetAccommodatie(string bondsnummer, Guid accommodatieId, bool refresh = false);

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

        [OperationContract]
        System.Collections.Generic.List<Guid> GetCompetitiesForInschrijving(string bondsnummer, Guid verenigingId, Guid districtId, bool refresh = false);
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
    }
}
