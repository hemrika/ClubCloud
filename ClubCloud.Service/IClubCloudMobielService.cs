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
    using System.Net.Security;
    using System.ServiceModel;
    using System.ServiceModel.Web;
    using System.Threading.Tasks;
    using System.Web.Configuration;
    
    /// <summary>
    ///
    /// </summary>
    [ServiceContract(Namespace = "http://clubcloud.nl/", Name = "ClubCloudMobiel")]
    public interface IClubCloudMobielService
    {
        #region Afhangen

        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "LoginMode", ResponseFormat = WebMessageFormat.Json)]
        AuthenticationMode LoginMode();

        [OperationContract]
        [ServiceKnownType(typeof(LoginResult))]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "Login/{username}/{password}", ResponseFormat= WebMessageFormat.Json)]
        LoginResult Login(string username, string password);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Setting))]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetClubCloudSettings")]//, ResponseFormat = WebMessageFormat.Json)]
        ClubCloud_Setting GetClubCloudSettings();


        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "DeleteReservering/{verenigingId}/{reserveringId}", ResponseFormat = WebMessageFormat.Json)]
        bool DeleteReservering(string verenigingId, string reserveringId);

        /*
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baanschema))]
        System.Collections.Generic.List<ClubCloud.Model.ClubCloud_Baanschema> GetBaanSchemaByAccommodatieId(string bondsnummer, Guid verenigingId, Guid accommodatieId, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baanschema))]
        System.Collections.Generic.List<ClubCloud.Model.ClubCloud_Baanschema> GetBaanSchemaByVerenigingId(string bondsnummer, Guid verenigingId, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baan))]
        System.Collections.Generic.List<ClubCloud.Model.ClubCloud_Baan> GetBanenByAccommodatieId(string bondsnummer, Guid verenigingId, Guid accommodatieId, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Baan))]
        System.Collections.Generic.List<ClubCloud.Model.ClubCloud_Baan> GetBanenByVerenigingId(string bondsnummer, Guid verenigingId, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Gebruiker))]
        System.Collections.Generic.List<ClubCloud.Model.ClubCloud_Gebruiker> GetGebruikersByReserveringId(string bondsnummer, Guid verenigingId, Guid reserveringId, bool refresh = false);
        */
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Gebruiker))]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetGebruikerByNummer/{bondsnummer}/{verenigingId}/{nummer}")]//, ResponseFormat = WebMessageFormat.Json)]
        ClubCloud.Model.ClubCloud_Gebruiker GetGebruikerByNummer(string bondsnummer, string verenigingId, string nummer);
        /*
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Foto))]
        ClubCloud.Model.ClubCloud_Foto GetFotoByNummer(string bondsnummer, Guid verenigingId, string nummer, bool refresh = false);
        */
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Foto))]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetFotoById/{bondsnummer}/{verenigingId}/{gebruikerId}")]//, ResponseFormat = WebMessageFormat.Json)]
        ClubCloud.Model.ClubCloud_Foto GetFotoById(string bondsnummer, string verenigingId, string gebruikerId);
        
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Gebruiker))]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetGebruikerById/{bondsnummer}/{verenigingId}/{gebruikerId}")]//, ResponseFormat = WebMessageFormat.Json)]
        ClubCloud.Model.ClubCloud_Gebruiker GetGebruikerById(string bondsnummer, string verenigingId, string gebruikerId);
        /*
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
        System.Collections.Generic.List<ClubCloud.Model.ClubCloud_Reservering> GetReserveringenByVerenigingId(string bondsnummer, Guid verenigingId, bool refresh = false);
        */
        /*
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "DeleteReservering/{verenigingId}/{reserveringId}")]
        ClubCloud.Model.ClubCloud_Vereniging GetVerenigingByLocation(string bondsnummer, double Latitude, double Longitude, bool refresh = false);
        */
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetVerenigingByNummer/{bondsnummer}/{verenigingNummer}")]//, ResponseFormat = WebMessageFormat.Json)]
        ClubCloud.Model.ClubCloud_Vereniging GetVerenigingByNummer(string bondsnummer, string verenigingNummer);
        
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetVerenigingById/{bondsnummer}/{verenigingId}")]
        ClubCloud.Model.ClubCloud_Vereniging GetVerenigingById(string bondsnummer, string verenigingId);
        
        
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetVerenigingSettings/{bondsnummer}/{verenigingId}")]//, ResponseFormat = WebMessageFormat.Json)]
        ClubCloud.Model.ClubCloud_Afhang GetVerenigingAfhangSettings(string bondsnummer, string verenigingId);

        /*
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Reservering))]
        ClubCloud.Model.ClubCloud_Reservering SetReservering(string bondsnummer, Guid verenigingId, Guid baanId, Guid[] gebruikers, DateTime Datum, TimeSpan Tijd, TimeSpan Duur, ReserveringSoort Soort = ReserveringSoort.Afhangen, bool final = false, bool push = false, string Beschrijving = "");

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Reservering))]
        ClubCloud.Model.ClubCloud_Reservering UpdateReservering(string bondsnummer, Guid verenigingId, ClubCloud.Model.ClubCloud_Reservering reservering, bool final = false, bool push = false);
        */
        #endregion

    }
}
