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
    using Microsoft.AspNet.SignalR.Infrastructure;
    using Microsoft.AspNet.SignalR;
    using ClubCloud.SignalR.Hubs;

    /// <summary>
    /// The REST Service.
    /// </summary>
    [BasicHttpBindingServiceMetadataExchangeEndpoint]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    [System.Runtime.InteropServices.Guid("ca13956f-3676-4c74-abdc-e16f784d08ac")]
    [ServiceBehavior(Namespace = "http://clubcloud.nl/", Name="ClubCloudService")]
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

            IConnectionManager connectionManager = GlobalHost.ConnectionManager;
            var context = connectionManager.GetHubContext<MijnHub>();

            context.Clients.Group(helloWorld).JoinClub(helloWorld);

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

            IConnectionManager connectionManager = GlobalHost.ConnectionManager;
            var context = connectionManager.GetHubContext<MijnHub>();

            context.Clients.Group(helloWorld).JoinClub(client.HelloWorldFromDatabase(helloWorld));

            return client.HelloWorldFromDatabase(helloWorld);
        }
    }
}
