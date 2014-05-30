//-----------------------------------------------------------------------
// <copyright file="IHelloWorldRESTService.cs" company="">
// Copyright © 
// </copyright>
//-----------------------------------------------------------------------
namespace ClubCloud.Service
{
    using ClubCloud.KNLTB.ServIt.LedenAdministratieService;
    using Microsoft.SharePoint;
    using System;
    using System.ServiceModel;
    using System.ServiceModel.Web;
    
    /// <summary>
    ///
    /// </summary>
    [ServiceContract(Namespace = "http://clubcloud.nl/", Name = "ClubCloudService")]
    [ServiceKnownType(typeof(Persoonsgegevens))]

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
        
        
        /// <summary>
        /// Gets the current User
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        //[WebInvoke(UriTemplate = "/GetCurrentUserGegevens", RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        //[WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        Persoonsgegevens GetPersoonsGegevens();
        
        /*
        /// <summary>
        /// Returns a hello world string.
        /// </summary>
        /// <param name="helloWorld">An input string of text.</param>
        /// <returns>A string of text echoing the input value.</returns>
        [OperationContract]
        //[WebGet(UriTemplate = "/HelloWorld/{helloWorld}", RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        //[WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string HelloWorld(string helloWorld);

        /// <summary>
        /// Returns a hello world string from the database.
        /// </summary>
        /// <param name="helloWorld">An input string of text.</param>
        /// <returns>A string of text echoing the input value.</returns>
        [OperationContract]
        //[WebGet(UriTemplate = "/HelloWorldFromDatabase/{helloWorld}", RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        //[WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string HelloWorldFromDatabase(string helloWorld);
        */
    }
}
