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
    using Microsoft.SharePoint;
    using ClubCloud.Service.Model;
    using System.Net;
    using ClubCloud.KNLTB.ServIt.LedenAdministratieService;

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
        private CookieContainer RequestContainer(string bondsnummer, string wachtwoord)
        {
            ClubCloud.KNLTB.Security.KNLTBContainer container = new KNLTB.Security.KNLTBContainer();
            container.MijnRequestAcces(bondsnummer, wachtwoord);
            while (container.Container == null) { }
            return container.Container;
        }
        /*
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
        */

        public string GetCurrentUser()
        {
            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                return SPContext.Current.Web.CurrentUser.LoginName;
            }
            else
            {
                return null;
            }
        }
        
        
        public Persoonsgegevens GetPersoonsGegevens()
        {
            Persoonsgegevens persoonsgegevens = null;

            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                ClubCloud_Gebruiker user = client.GetClubCloudUser(SPContext.Current.Web.CurrentUser.LoginName);

                CookieContainer cc = RequestContainer(user.Id.ToString(), user.mijnknltb_password);

                LedenadministratieServiceClient LedenAdministratie = new LedenadministratieServiceClient(cc);
                GetPersoonsgegevensResponse persoon = LedenAdministratie.GetPersoonsgegevens(new GetPersoonsgegevensRequest { Bondsnummer = user.Id.ToString() });
                persoonsgegevens = persoon.Persoonsgegevens;
            }

            return persoonsgegevens;
        }
        
    }
}
