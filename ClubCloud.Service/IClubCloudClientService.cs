//-----------------------------------------------------------------------
// <copyright file="IHelloWorldRESTService.cs" company="">
// Copyright © 
// </copyright>
//-----------------------------------------------------------------------
namespace ClubCloud.Service
{

    using ClubCloud.Service.Model;
    using Microsoft.SharePoint;
    using System;
    using System.ServiceModel;
    using System.ServiceModel.Web;
    using System.Threading.Tasks;
    
    /// <summary>
    ///
    /// </summary>
    [ServiceContract(Namespace = "http://clubcloud.nl/", Name = "ClubCloudService")]

    public interface IClubCloudClientService
    {
        /// <summary>
        /// Gets the current User
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        //[WebInvoke(UriTemplate = "/GetCurrentUser", RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        //[WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string GetCurrentUser();

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
        ClubCloud_Setting GetClubCloudSettings(string bondsnummer);

        /*
        /// <summary>
        /// Gets the current User
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Gebruiker))]
        //[WebInvoke(UriTemplate = "/GetCurrentUserGegevens", RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        //[WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ClubCloud_Gebruiker GetClubCloudGebruiker(bool refresh = false);
        */

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Gebruiker))]
        //[WebInvoke(UriTemplate = "/GetCurrentUserGegevens", RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        //[WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ClubCloud_Gebruiker GetGebruikerByNummer(string bondsnummer, Guid verenigingId, string nummer, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Gebruiker))]
        //[WebInvoke(UriTemplate = "/GetCurrentUserGegevens", RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        //[WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ClubCloud_Gebruiker GetGebruikerById(string bondsnummer, Guid verenigingId, Guid gebruikerId, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Foto))]
        //[WebInvoke(UriTemplate = "/GetCurrentUserGegevens", RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        //[WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ClubCloud_Foto GetFotoByNummer(string bondsnummer, Guid verenigingId, string nummer, bool refresh = false);

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Foto))]
        //[WebInvoke(UriTemplate = "/GetCurrentUserGegevens", RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        //[WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ClubCloud_Foto GetFotoById(string bondsnummer, Guid verenigingId, Guid gebruikerId, bool refresh = false);

        /*
        [OperationContract]
        [ServiceKnownType(typeof(SpelersProfiel))]
        SpelersProfiel GetPersoonsprofiel(string bondsnummer, bool refresh = false);
        */
        /*
        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Tracking))]
        ClubCloud_Tracking GetTracking(string bondsnummer, bool refresh = false);
        */

        [OperationContract]
        [ServiceKnownType(typeof(ClubCloud_Vereniging))]
        ClubCloud_Vereniging GetVerenigingById(string bondsnummer, Guid verenigingId, bool refresh = false);

    }
}
