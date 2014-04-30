//-----------------------------------------------------------------------
// <copyright file="HelloWorldRESTService.cs" company="">
// Copyright © 
// </copyright>
//-----------------------------------------------------------------------
namespace ClubCloud.Service
{
    using System;  
    using System.ServiceModel;
    using System.ServiceModel.Activation;
    using Microsoft.SharePoint.Administration;
    using Microsoft.SharePoint.Client.Services;

    /// <summary>
    /// The REST Service.
    /// </summary>
    [BasicHttpBindingServiceMetadataExchangeEndpoint]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    [System.Runtime.InteropServices.Guid("ca13956f-3676-4c74-abdc-e16f784d08ac")]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1812:AvoidUninstantiatedInternalClasses", Justification = "Instantiated by the WCF runtime automatically.")]
    public class ClubCloudClientService : IClubCloudClientService
    {
        /// <summary>
        /// Returns a hello world string.
        /// </summary>
        /// <param name="helloWorld">An input string of text.</param>
        /// <returns>A string of text echoing the input value.</returns>
        public string HelloWorld(string helloWorld)
        {
            //return "Hello World - You entered: " + helloWorld;
            ClubCloudServiceClient client = new ClubCloudServiceClient();
            return client.HelloWorld(helloWorld);
        }

        /// <summary>
        /// Returns a hello world string from the database.
        /// </summary>
        /// <param name="helloWorld">An input string of text.</param>
        /// <returns>A string of text echoing the input value.</returns>
        public string HelloWorldFromDatabase(string helloWorld)
        {
            //return "Hello World - You entered: " + helloWorld;
            ClubCloudServiceClient client = new ClubCloudServiceClient();
            return client.HelloWorldFromDatabase(helloWorld);
        }
    }
}
