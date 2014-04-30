//-----------------------------------------------------------------------
// <copyright file="IHelloWorldRESTService.cs" company="">
// Copyright © 
// </copyright>
//-----------------------------------------------------------------------
namespace ClubCloud.Service
{
    using System;
    using System.ServiceModel;
    using System.ServiceModel.Web;
    
    /// <summary>
    /// The REST Service Contract.
    /// </summary>
    [ServiceContract]
    public interface IClubCloudClientService
    {
        /// <summary>
        /// Returns a hello world string.
        /// </summary>
        /// <param name="helloWorld">An input string of text.</param>
        /// <returns>A string of text echoing the input value.</returns>
        [OperationContract, WebGet(UriTemplate = "/HelloWorld/{helloWorld}", RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        string HelloWorld(string helloWorld);

        /// <summary>
        /// Returns a hello world string from the database.
        /// </summary>
        /// <param name="helloWorld">An input string of text.</param>
        /// <returns>A string of text echoing the input value.</returns>
        [OperationContract, WebGet(UriTemplate = "/HelloWorldFromDatabase/{helloWorld}", RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        string HelloWorldFromDatabase(string helloWorld);
    }
}
