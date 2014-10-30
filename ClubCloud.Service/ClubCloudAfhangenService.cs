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
    //using ClubCloud.KNLTB.ServIt.LedenAdministratieService;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    /// <summary>
    /// The REST Service.
    /// </summary>
    [BasicHttpBindingServiceMetadataExchangeEndpoint]
    [ServiceFactoryUsingAuthSchemeInEndpointAddress( UsingAuthSchemeInEndpointAddress = true)]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    [System.Runtime.InteropServices.Guid("4d39ae1b-b9f8-4899-a6c7-2a50bff2351c")]
    [ServiceBehavior(Namespace = "http://clubcloud.nl/", Name = "ClubCloudAfhangen", IncludeExceptionDetailInFaults = true)]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1812:AvoidUninstantiatedInternalClasses", Justification = "Instantiated by the WCF runtime automatically.")]
    public class ClubCloudAfhangenService : IClubCloudAfhangenService
    {
        #region Afhangen

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

        public bool DeleteReservering(string bondsnummer, Guid verenigingId, Guid reserveringId, bool push = false)
        {
            bool deleted = false;

            if (SPContext.Current != null && SPContext.Current.Web != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                deleted = client.DeleteReservering(bondsnummer, verenigingId, reserveringId, push);
            }

            return deleted;
        }

        public System.Collections.Generic.List<ClubCloud_Baanschema> GetBaanSchemaByAccommodatieId(string bondsnummer, Guid verenigingId, Guid accommodatieId, bool refresh = false)
        {
            List<ClubCloud_Baanschema> baanschema = new List<ClubCloud_Baanschema>();

            if (SPContext.Current != null && SPContext.Current.Web != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                baanschema = client.GetBaanSchemaByAccommodatieId(bondsnummer, verenigingId, accommodatieId, refresh);
            }

            return baanschema;
        }

        public System.Collections.Generic.List<ClubCloud_Baanschema> GetBaanSchemaByVerenigingId(string bondsnummer, Guid verenigingId, bool refresh = false)
        {
            List<ClubCloud_Baanschema> baanschema = new List<ClubCloud_Baanschema>();

            if (SPContext.Current != null && SPContext.Current.Web != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                baanschema = client.GetBaanSchemaByVerenigingId(bondsnummer, verenigingId, refresh);
            }

            return baanschema;
        }

        public System.Collections.Generic.List<ClubCloud_Baan> GetBanenByAccommodatieId(string bondsnummer, Guid verenigingId, Guid accommodatieId, bool refresh = false)
        {
            List<ClubCloud_Baan> banen = new List<ClubCloud_Baan>();

            if (SPContext.Current != null && SPContext.Current.Web != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                banen = client.GetBanenByAccommodatieId(bondsnummer, verenigingId, accommodatieId, refresh);
            }

            return banen;
        }

        public System.Collections.Generic.List<ClubCloud_Baan> GetBanenByVerenigingId(string bondsnummer, Guid verenigingId, bool refresh = false)
        {
            List<ClubCloud_Baan> banen = new List<ClubCloud_Baan>();

            if (SPContext.Current != null && SPContext.Current.Web != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                banen = client.GetBanenByVerenigingId(bondsnummer, verenigingId, refresh);
            }

            return banen;
        }

        public System.Collections.Generic.List<ClubCloud_Gebruiker> GetGebruikersByReserveringId(string bondsnummer, Guid verenigingId, Guid reserveringId, bool refresh = false)
        {
            List<ClubCloud_Gebruiker> gebruikers = new List<ClubCloud_Gebruiker>();

            if (SPContext.Current != null && SPContext.Current.Web != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                gebruikers = client.GetGebruikersByReserveringId(bondsnummer, verenigingId, reserveringId, refresh);
            }

            return gebruikers;
        }

        public ClubCloud_Gebruiker GetGebruikerByNummer(string bondsnummer, Guid verenigingId, string nummer, bool refresh = false)
        {
            ClubCloud_Gebruiker gebruiker = new ClubCloud_Gebruiker();

            if (SPContext.Current != null && SPContext.Current.Web != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                gebruiker = client.GetGebruikerByNummer(bondsnummer, verenigingId, nummer, refresh);
            }

            return gebruiker;

        }

        public ClubCloud_Gebruiker GetGebruikerById(string bondsnummer, Guid verenigingId, Guid gebruikerId, bool refresh = false)
        {
            ClubCloud_Gebruiker gebruiker = new ClubCloud_Gebruiker();

            if (SPContext.Current != null && SPContext.Current.Web != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                gebruiker = client.GetGebruikerById(bondsnummer, verenigingId, gebruikerId, refresh);
            }

            return gebruiker;

        }

        public ClubCloud_Foto GetFotoByNummer(string bondsnummer, Guid verenigingId, string nummer, bool refresh = false)
        {
            ClubCloud_Foto foto = null;

            if (SPContext.Current != null && SPContext.Current.Web != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                foto = client.GetFotoByNummer(bondsnummer, verenigingId, nummer, refresh);
            }

            return foto;
        }

        public ClubCloud_Foto GetFotoById(string bondsnummer, Guid verenigingId, Guid gebruikerId, bool refresh = false)
        {
            ClubCloud_Foto foto = null;

            if (SPContext.Current != null && SPContext.Current.Web != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                foto = client.GetFotoById(bondsnummer, verenigingId, gebruikerId, refresh);
            }

            return foto;
        }

        public ClubCloud_Reservering GetReserveringByReserveringId(string bondsnummer, Guid verenigingId, Guid reserveringId, bool refresh = false)
        {
            ClubCloud_Reservering reservering = new ClubCloud_Reservering();

            if (SPContext.Current != null && SPContext.Current.Web != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                reservering = client.GetReserveringByReserveringId(bondsnummer, verenigingId, reserveringId, refresh);
            }

            return reservering;
        }

        public System.Collections.Generic.List<ClubCloud_Reservering> GetReserveringenByBaanId(string bondsnummer, Guid verenigingId, Guid baanId, bool refresh = false)
        {
            List<ClubCloud_Reservering> reserveringen = new List<ClubCloud_Reservering>();

            if (SPContext.Current != null && SPContext.Current.Web != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                reserveringen = client.GetReserveringenByBaanId(bondsnummer, verenigingId, baanId, refresh);
            }

            return reserveringen;
        }

        public System.Collections.Generic.List<ClubCloud_Reservering> GetReserveringenByBondsnummer(string bondsnummer, Guid verenigingId, string nummer, bool refresh = false)
        {
            List<ClubCloud_Reservering> reserveringen = new List<ClubCloud_Reservering>();

            if (SPContext.Current != null && SPContext.Current.Web != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                reserveringen = client.GetReserveringenByBondsnummer(bondsnummer, verenigingId, nummer, refresh);
            }

            return reserveringen;
        }

        public System.Collections.Generic.List<ClubCloud_Reservering> GetReserveringenByVerenigingId(string bondsnummer, Guid verenigingId, bool refresh = false)
        {
            List<ClubCloud_Reservering> reserveringen = new List<ClubCloud_Reservering>();

            if (SPContext.Current != null && SPContext.Current.Web != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                reserveringen = client.GetReserveringenByVerenigingId(bondsnummer, verenigingId, refresh);
            }

            return reserveringen;
        }

        public ClubCloud_Vereniging GetVerenigingByLocation(string bondsnummer, double Latitude, double Longitude, bool refresh = false)
        {
            ClubCloud_Vereniging vereniging = new ClubCloud_Vereniging();

            if (SPContext.Current != null && SPContext.Current.Web != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                vereniging = client.GetVerenigingByLocation(bondsnummer, Latitude, Longitude, refresh);
            }

            return vereniging;
        }

        public ClubCloud_Vereniging GetVerenigingByNummer(string bondsnummer, string verenigingNummer, bool refresh = false)
        {
            ClubCloud_Vereniging vereniging = new ClubCloud_Vereniging();

            if (SPContext.Current != null && SPContext.Current.Web != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                vereniging = client.GetVerenigingByNummer(bondsnummer, verenigingNummer, refresh);
            }

            return vereniging;
        }

        public ClubCloud_Vereniging GetVerenigingById(string bondsnummer, Guid verenigingId, bool refresh = false)
        {
            ClubCloud_Vereniging vereniging = new ClubCloud_Vereniging();

            if (SPContext.Current != null && SPContext.Current.Web != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                vereniging = client.GetVerenigingById(bondsnummer, verenigingId, refresh);
            }

            return vereniging;
        }
        public ClubCloud_Reservering SetReservering(string bondsnummer, Guid verenigingId, Guid baanId, Guid[] gebruikers, DateTime Datum,TimeSpan Tijd, TimeSpan Duur, ReserveringSoort Soort = ReserveringSoort.Afhangen, bool final = false, bool push = false, string Beschrijving = "")
        {
            ClubCloud_Reservering reservering = new ClubCloud_Reservering();

            if (SPContext.Current != null && SPContext.Current.Web != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                reservering = client.SetReservering(bondsnummer, verenigingId, baanId, gebruikers,Datum, Tijd, Duur,Soort, final, push, Beschrijving);
            }

            return reservering;
        }

        public ClubCloud_Reservering UpdateReservering(string bondsnummer, Guid verenigingId, ClubCloud_Reservering reservering, bool final = false, bool push = false)
        {
            ClubCloud_Reservering Ureservering = new ClubCloud_Reservering();

            if (SPContext.Current != null && SPContext.Current.Web != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                Ureservering = client.UpdateReservering(bondsnummer, verenigingId, reservering, final, push);
            }

            return Ureservering;
        }

        #endregion


        public ClubCloud_Afhang GetVerenigingSettings(string bondsnummer, Guid verenigingId, bool refresh = false)
        {
            ClubCloud_Afhang afhang = new ClubCloud_Afhang();

            if (SPContext.Current != null && SPContext.Current.Web != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                afhang = client.GetVerenigingSettings(bondsnummer, verenigingId, refresh);
            }

            return afhang;

        }
    }
}
