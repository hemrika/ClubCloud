//-----------------------------------------------------------------------
// <copyright file="IHelloWorldRESTService.cs" company="">
// Copyright © 
// </copyright>
//-----------------------------------------------------------------------
namespace ClubCloud.Service
{

    using ClubCloud.Model;
    using Microsoft.SharePoint;
    using System;
    using System.Collections.Generic;
    using System.ServiceModel;
    using System.ServiceModel.Web;
    using System.Threading.Tasks;
    
    /// <summary>
    ///
    /// </summary>
    [ServiceContract(Namespace = "http://clubcloud.nl/", Name = "ClubCloudAfhangen")]

    public interface IClubCloudAfhangenService
    {
        #region Afhangen

        #region Baan

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baan))]
        [ServiceKnownType(typeof(BeheerBaseModel))]
        ClubCloud.Model.ClubCloud_Baan GetBaanById(string bondsnummer, Guid verenigingId, Guid baanId, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baanschema))]
        [ServiceKnownType(typeof(BeheerBaseModel))]
        System.Collections.Generic.List<ClubCloud.Model.ClubCloud_Baanschema> GetBaanSchemaByAccommodatieId(string bondsnummer, Guid verenigingId, Guid accommodatieId, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baanschema))]
        [ServiceKnownType(typeof(BeheerBaseModel))]
        System.Collections.Generic.List<ClubCloud.Model.ClubCloud_Baanschema> GetBaanSchemaByVerenigingId(string bondsnummer, Guid verenigingId, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baanschema))]
        [ServiceKnownType(typeof(BeheerBaseModel))]
        System.Collections.Generic.List<ClubCloud.Model.ClubCloud_Baanschema> GetBaanSchemaByDate(string bondsnummer, System.Guid verenigingId, DateTime date, bool refresh);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baan))]
        [ServiceKnownType(typeof(BeheerBaseModel))]
        System.Collections.Generic.List<ClubCloud.Model.ClubCloud_Baan> GetBanenByAccommodatieId(string bondsnummer, Guid verenigingId, Guid accommodatieId, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baan))]
        [ServiceKnownType(typeof(BeheerBaseModel))]
        System.Collections.Generic.List<ClubCloud.Model.ClubCloud_Baan> GetBanenByVerenigingId(string bondsnummer, Guid verenigingId, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baanblok))]
        [ServiceKnownType(typeof(BeheerBaseModel))]
        System.Collections.Generic.List<ClubCloud.Model.ClubCloud_Baanblok> GetBaanblokkenByAccommodatieId(string bondsnummer, Guid verenigingId, Guid accommodatieId, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baansoort))]
        [ServiceKnownType(typeof(BeheerBaseModel))]
        ClubCloud.Model.ClubCloud_Baansoort GetBaansoortById(string bondsnummer, Guid verenigingId, Guid accommodatieId, Guid baansoortId, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baantype))]
        [ServiceKnownType(typeof(BeheerBaseModel))]
        ClubCloud.Model.ClubCloud_Baantype GetBaantypeById(string bondsnummer, Guid verenigingId, Guid accommodatieId, Guid BaantypeId, bool refresh = false);

        #endregion

        #region Reservering

        [OperationContract]
        bool DeleteReservering(string bondsnummer, Guid verenigingId, Guid reserveringId, bool push = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Gebruiker))]
        [ServiceKnownType(typeof(BeheerBaseModel))]
        System.Collections.Generic.List<ClubCloud.Model.ClubCloud_Gebruiker> GetGebruikersByReserveringId(string bondsnummer, Guid verenigingId, Guid reserveringId, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Reservering))]
        [ServiceKnownType(typeof(BeheerBaseModel))]
        ClubCloud.Model.ClubCloud_Reservering GetReserveringByReserveringId(string bondsnummer, Guid verenigingId, Guid reserveringId, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Reservering))]
        [ServiceKnownType(typeof(BeheerBaseModel))]
        System.Collections.Generic.List<ClubCloud.Model.ClubCloud_Reservering> GetReserveringenByBaanId(string bondsnummer, Guid verenigingId, Guid baanId, bool refresh = false);

                [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Reservering))]
        [ServiceKnownType(typeof(BeheerBaseModel))]
        System.Collections.Generic.List<ClubCloud.Model.ClubCloud_Reservering> GetReserveringenByDate(string bondsnummer, Guid verenigingId, DateTime date, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Reservering))]
        [ServiceKnownType(typeof(BeheerBaseModel))]
        System.Collections.Generic.List<ClubCloud.Model.ClubCloud_Reservering> GetReserveringenByBondsnummer(string bondsnummer, Guid verenigingId, string nummer, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Reservering))]
        [ServiceKnownType(typeof(BeheerBaseModel))]
        System.Collections.Generic.List<ClubCloud.Model.ClubCloud_Reservering> GetReserveringenByVerenigingId(string bondsnummer, Guid verenigingId, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Reservering))]
        [ServiceKnownType(typeof(BeheerBaseModel))]
        ClubCloud.Model.ClubCloud_Reservering SetReservering(string bondsnummer, Guid verenigingId, Guid baanId, Guid[] gebruikers, DateTime Datum, TimeSpan Tijd, TimeSpan Duur, ReserveringSoort Soort = ReserveringSoort.Afhangen, bool final = false, bool push = false, string Beschrijving = "");

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Reservering))]
        [ServiceKnownType(typeof(BeheerBaseModel))]
        ClubCloud.Model.ClubCloud_Reservering UpdateReservering(string bondsnummer, Guid verenigingId, ClubCloud.Model.ClubCloud_Reservering reservering, bool final = false, bool push = false);

        #endregion

        #region Gebruiker

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Gebruiker))]
        [ServiceKnownType(typeof(BeheerBaseModel))]
        ClubCloud.Model.ClubCloud_Gebruiker GetGebruikerByNummer(string bondsnummer, Guid verenigingId, string nummer, bool refresh = false);
 
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Foto))]
        [ServiceKnownType(typeof(BeheerBaseModel))]
        ClubCloud.Model.ClubCloud_Foto GetFotoByNummer(string bondsnummer, Guid verenigingId, string nummer, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Foto))]
        [ServiceKnownType(typeof(BeheerBaseModel))]
        ClubCloud.Model.ClubCloud_Foto GetFotoById(string bondsnummer, Guid verenigingId, Guid gebruikerId, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Gebruiker))]
        [ServiceKnownType(typeof(BeheerBaseModel))]
        ClubCloud.Model.ClubCloud_Gebruiker GetGebruikerById(string bondsnummer, Guid verenigingId, Guid gebruikerId, bool refresh = false);
        
        #endregion

        #region Vereniging

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
        [ServiceKnownType(typeof(BeheerBaseModel))]
        ClubCloud.Model.ClubCloud_Vereniging GetVerenigingByLocation(string bondsnummer, double Latitude, double Longitude, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
        [ServiceKnownType(typeof(BeheerBaseModel))]
        ClubCloud.Model.ClubCloud_Vereniging GetVerenigingByNummer(string bondsnummer, string verenigingNummer, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
        [ServiceKnownType(typeof(BeheerBaseModel))]
        ClubCloud.Model.ClubCloud_Vereniging GetVerenigingById(string bondsnummer, Guid verenigingId, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Afhang))]
        [ServiceKnownType(typeof(BeheerBaseModel))]
        ClubCloud.Model.ClubCloud_Afhang GetVerenigingAfhangSettings(string bondsnummer, Guid verenigingId, bool refresh = false);
        
        #endregion

        #region Sponsor

        #region Get
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Sponsor))]
        [ServiceKnownType(typeof(BeheerBaseModel))]
        System.Collections.Generic.List<ClubCloud.Model.ClubCloud_Sponsor> GetSponsorenByVerenigingId(string bondsnummer, Guid verenigingId, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Sponsor))]
        [ServiceKnownType(typeof(BeheerBaseModel))]
        ClubCloud.Model.ClubCloud_Sponsor GetSponsorById(string bondsnummer, Guid verenigingId, Guid sponsorId, bool refresh = false);

        
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Sponsor_Afbeelding))]
        [ServiceKnownType(typeof(BeheerBaseModel))]
        ClubCloud.Model.ClubCloud_Sponsor_Afbeelding GetSponsorImageById(string bondsnummer, Guid verenigingId, Guid afbeeldingId, bool refresh = false);
        #endregion

        #endregion

        #endregion

        /*
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.WrappedRequest, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string[] GetGebruikerAutoComplete(string prefixText, int count, string contextKey);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.WrappedRequest, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string[] GetVereniningen(string prefixText, int count, string contextKey);
        */

    }
}
