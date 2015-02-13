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
    using Microsoft.SharePoint;
    using ClubCloud.Model;
    using System.Net;
    using System.Threading.Tasks;
    using System.ServiceModel.Web;
    using System.Collections.Generic;
    using System.Web.Script.Serialization;
    using System.Web.UI;

    /// <summary>
    /// The REST Service.
    /// </summary>
    [BasicHttpBindingServiceMetadataExchangeEndpoint]
    [ServiceFactoryUsingAuthSchemeInEndpointAddress(UsingAuthSchemeInEndpointAddress = false)]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    [System.Runtime.InteropServices.Guid("ca13956f-3676-4c74-abdc-e16f784d08ac")]
    [ServiceBehavior(Namespace = "http://clubcloud.nl/", Name = "ClubCloudService", IncludeExceptionDetailInFaults = true)]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1812:AvoidUninstantiatedInternalClasses", Justification = "Instantiated by the WCF runtime automatically.")]
    public class ClubCloudClientService : IClubCloudClientService
    {
        /*
        #region Settings

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
        */
        /*
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
        */
        /*
        public ClubCloud_Gebruiker GetGebruikerByNummer(string bondsnummer, Guid verenigingId, string nummer, bool refresh = false)
        {
            ClubCloud_Gebruiker clubCloud_gebruiker = new ClubCloud_Gebruiker();

            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                clubCloud_gebruiker = client.GetGebruikerByNummer(SPContext.Current.Web.CurrentUser.LoginName,verenigingId, nummer, refresh);
            }

            return clubCloud_gebruiker;
        }

        public ClubCloud_Gebruiker GetGebruikerById(string bondsnummer, Guid verenigingId, Guid gebruikerId, bool refresh = false)
        {
            ClubCloud_Gebruiker clubCloud_gebruiker = new ClubCloud_Gebruiker();

            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                clubCloud_gebruiker = client.GetGebruikerById(SPContext.Current.Web.CurrentUser.LoginName, verenigingId, gebruikerId, refresh);
            }

            return clubCloud_gebruiker;
        }

        public ClubCloud_Foto GetFotoByNummer(string bondsnummer, Guid verenigingId, string nummer, bool refresh = false)
        {
            ClubCloud_Foto clubCloud_foto = null;

            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                clubCloud_foto = client.GetFotoByNummer(SPContext.Current.Web.CurrentUser.LoginName, verenigingId, nummer, refresh);
            }

            return clubCloud_foto;
        }

        public ClubCloud_Foto GetFotoById(string bondsnummer, Guid verenigingId, Guid gebruikerId, bool refresh = false)
        {
            ClubCloud_Foto clubCloud_foto = null;

            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                clubCloud_foto = client.GetFotoById(SPContext.Current.Web.CurrentUser.LoginName, verenigingId, gebruikerId, refresh);
            }

            return clubCloud_foto;
        }

        #endregion

        public ClubCloud_Vereniging GetVerenigingById(string bondsnummer, Guid verenigingId, bool refresh = false)
        {
            ClubCloud_Vereniging vereniging = new ClubCloud_Vereniging();

            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                vereniging = client.GetVerenigingById(SPContext.Current.Web.CurrentUser.LoginName, verenigingId, refresh);
            }

            return vereniging;
        }
        */
        #region Public WebSite

        public string[] GetGebruikerAutoComplete(string prefixText, int count, string contextKey)
        {
            List<string> customers = new List<string>();

            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);

                List<ClubCloud_Gebruiker> gebruikers = client.GetGebruikersBySearch(SPContext.Current.Web.CurrentUser.LoginName, prefixText, count, true);

                if (gebruikers != null && gebruikers.Count > 0)
                {
                    foreach (ClubCloud_Gebruiker gebruiker in gebruikers)
                    {
                        customers.Add((new JavaScriptSerializer()).Serialize(new Pair(string.Format("{0} - {1}", gebruiker.Bondsnummer, gebruiker.Volledigenaam), gebruiker.Bondsnummer)));
                    }

                    return customers.ToArray();

                }
                else
                {
                    return default(string[]);
                }
            }
            else
            {
                return default(string[]);
            }
        }


        public string[] GetVereniningen(string prefixText, int count, string contextKey)
        {
            List<string> verenigingen = new List<string>();
            try
            {
                //if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
                //{
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);

                //TextBox verenigingsnummer = (TextBox)fvw_vereniging.FindControl("tbx_verenigingsnummer");
                ClubCloud_Vereniging vereniging = client.GetVerenigingByNummer("00000000", prefixText, true);

                if (vereniging != null)
                {
                    verenigingen.Add((new JavaScriptSerializer()).Serialize(new Pair(string.Format("{0} - {1}", vereniging.Nummer, vereniging.Naam), vereniging.Nummer)));
                    return verenigingen.ToArray();
                }
                //}
            }
            catch { };

            return default(string[]);
        }

        #endregion
    }
}
