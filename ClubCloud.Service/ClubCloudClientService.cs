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
    using System.Threading.Tasks;

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
        /*
        private CookieContainer RequestContainer(string bondsnummer, string wachtwoord)
        {
            ClubCloud.KNLTB.Security.KNLTBContainer container = new KNLTB.Security.KNLTBContainer();
            container.MijnRequestAcces(bondsnummer, wachtwoord);
            while (container.Container == null) { }
            return container.Container;
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

        public ClubCloud_Setting SetPrivacy(ClubCloud_Setting settings)
        {
            ClubCloud_Setting currentsettings = new ClubCloud_Setting();

            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                currentsettings = client.SetPrivacy(settings);
            }

            return currentsettings;
        }

        public ClubCloud_Setting SetMijnKNLTB(ClubCloud_Setting settings)
        {
            ClubCloud_Setting currentsettings = new ClubCloud_Setting();

            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                currentsettings = client.SetMijnKNLTB(settings);
            }

            return currentsettings;
        }

        public ClubCloud_Setting SetTwitter(ClubCloud_Setting settings)
        {
            ClubCloud_Setting currentsettings = new ClubCloud_Setting();

            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                currentsettings = client.SetTwitter(settings);
            }

            return currentsettings;
        }

        public ClubCloud_Setting SetFaceBook(ClubCloud_Setting settings)
        {
            ClubCloud_Setting currentsettings = new ClubCloud_Setting();

            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                currentsettings = client.SetFaceBook(settings);
            }

            return currentsettings;
        }

        public ClubCloud_Setting SetFinancieel(ClubCloud_Setting settings)
        {
            ClubCloud_Setting currentsettings = new ClubCloud_Setting();

            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                currentsettings = client.SetFinancieel(settings);
            }

            return currentsettings;
        }

        public ClubCloud_Setting SetTracking(ClubCloud_Setting settings)
        {
            ClubCloud_Setting currentsettings = new ClubCloud_Setting();

            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                currentsettings = client.SetTracking(settings);
            }

            return currentsettings;
        }

        public async Task<ClubCloud_Setting> GetClubCloudSettingsTask(string bondsnummer)
        {
            ClubCloud_Setting currentsettings = new ClubCloud_Setting();

            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                currentsettings = await Task.Run(() => GetClubCloudSettings(bondsnummer));
                //currentsettings = client.GetClubCloudSettings(SPContext.Current.Web.CurrentUser.LoginName);
            }
            return currentsettings;
        }

        public ClubCloud_Setting GetClubCloudSettings(string bondsnummer)
        {
            ClubCloud_Setting currentsettings = new ClubCloud_Setting();

            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                currentsettings = client.GetClubCloudSettings(SPContext.Current.Web.CurrentUser.LoginName);
            }

            return currentsettings;
        }

        public ClubCloud_Gebruiker GetClubCloudGebruiker(bool refresh = false)
        {
            ClubCloud_Gebruiker clubCloud_gebruiker = new ClubCloud_Gebruiker();

            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                clubCloud_gebruiker = client.GetClubCloudGebruiker(SPContext.Current.Web.CurrentUser.LoginName, refresh);
            }

            return clubCloud_gebruiker;
        }



        public SpelersProfiel GetPersoonsprofiel(string bondsnummer, bool refresh = false)
        {
            SpelersProfiel spelersprofiel = new SpelersProfiel();

            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                spelersprofiel = client.GetSpelersProfiel(SPContext.Current.Web.CurrentUser.LoginName, refresh);
            }

            return spelersprofiel;
        }


        public SpelerTracking GetTracking(string bondsnummer, bool refresh = false)
        {
            SpelerTracking tracking = new SpelerTracking();

            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                tracking = client.GetTracking(SPContext.Current.Web.CurrentUser.LoginName, refresh);
            }

            return tracking;

        }
    }
}
