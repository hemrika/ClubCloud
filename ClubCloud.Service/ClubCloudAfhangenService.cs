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
    using System.Collections.Generic;
    using System.Web.Script.Serialization;
    using System.Web.UI;

    /// <summary>
    /// The REST Service.
    /// </summary>
    [BasicHttpBindingServiceMetadataExchangeEndpoint]
    [ServiceFactoryUsingAuthSchemeInEndpointAddress( UsingAuthSchemeInEndpointAddress = true)]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    [System.Runtime.InteropServices.Guid("4d39ae1b-b9f8-4899-a6c7-2a50bff2351c")]
    [ServiceBehavior(Namespace = "http://clubcloud.nl/", Name = "ClubCloudAfhangen", IncludeExceptionDetailInFaults = true, AddressFilterMode = AddressFilterMode.Any )]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1812:AvoidUninstantiatedInternalClasses", Justification = "Instantiated by the WCF runtime automatically.")]
    public class ClubCloudAfhangenService : IClubCloudAfhangenService
    {
        #region Afhangen

        public bool DeleteReservering(string bondsnummer, Guid verenigingId, Guid reserveringId, bool push = false)
        {
            bool deleted = false;

            if (SPContext.Current != null && SPContext.Current.Web != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                deleted = client.DeleteReserveringById(reserveringId, new ClubCloud_Setting { Id = int.Parse(bondsnummer), VerenigingId = verenigingId });
            }

            return deleted;
        }

        public System.Collections.Generic.List<ClubCloud_Gebruiker> GetGebruikersByReserveringId(string bondsnummer, Guid verenigingId, Guid reserveringId, bool refresh = false)
        {
            List<ClubCloud_Gebruiker> gebruikers = new List<ClubCloud_Gebruiker>();

            if (SPContext.Current != null && SPContext.Current.Web != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                gebruikers = client.GetGebruikersForReserveringById(bondsnummer, verenigingId, reserveringId, refresh);
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
                gebruiker = client.GetGebruikerById(gebruikerId, refresh, new ClubCloud_Setting { Id = int.Parse(bondsnummer), VerenigingId = verenigingId });
            }

            return gebruiker;

        }

        //public ClubCloud_Foto GetFotoByNummer(string bondsnummer, Guid verenigingId, string nummer, bool refresh = false)
        //{
        //    ClubCloud_Foto foto = null;

        //    if (SPContext.Current != null && SPContext.Current.Web != null)
        //    {
        //        ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
        //        foto = client.GetFotoByNummer(bondsnummer, verenigingId, nummer, refresh);
        //    }

        //    return foto;
        //}

        
        public ClubCloud_Foto GetFotoById(string bondsnummer, Guid verenigingId, Guid gebruikerId, bool refresh = false)
        {
            ClubCloud_Foto foto = null;

            if (SPContext.Current != null && SPContext.Current.Web != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                foto = client.GetFotoForGebruikerById(bondsnummer, gebruikerId, refresh, new ClubCloud_Setting { Id = int.Parse(bondsnummer), VerenigingId = verenigingId, GebruikerId = gebruikerId });
            }

            return foto;
        }
       

        public ClubCloud_Reservering GetReserveringByReserveringId(string bondsnummer, Guid verenigingId, Guid reserveringId, bool refresh = false)
        {
            ClubCloud_Reservering reservering = new ClubCloud_Reservering();

            if (SPContext.Current != null && SPContext.Current.Web != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                reservering = client.GetReserveringById(reserveringId, refresh, new ClubCloud_Setting { Id = int.Parse(bondsnummer), VerenigingId = verenigingId });
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

        public System.Collections.Generic.List<ClubCloud_Reservering> GetReserveringenByDate(string bondsnummer, Guid verenigingId, DateTime date, bool refresh = false)
        {
            List<ClubCloud_Reservering> reserveringen = new List<ClubCloud_Reservering>();

            if (SPContext.Current != null && SPContext.Current.Web != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                reserveringen = client.GetReserveringenByDate(bondsnummer, verenigingId, date, refresh);
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
                vereniging = client.GetVerenigingById(verenigingId, refresh, new ClubCloud_Setting { Id = int.Parse(bondsnummer), VerenigingId = verenigingId });
            }

            return vereniging;
        }
        public ClubCloud_Reservering AddReservering(string bondsnummer, Guid verenigingId, Guid baanId, Guid[] gebruikers, DateTime Datum,TimeSpan Tijd, TimeSpan Duur, ReserveringSoort Soort = ReserveringSoort.Afhangen, bool final = false, bool push = false, string Beschrijving = "")
        {
            ClubCloud_Reservering reservering = new ClubCloud_Reservering();

            if (SPContext.Current != null && SPContext.Current.Web != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                reservering = client.AddReservering(bondsnummer, verenigingId, baanId, gebruikers,Datum, Tijd, Duur,Soort, final, push, Beschrijving);
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

        public List<ClubCloud_Afhang> GetVerenigingAfhangSettings(string bondsnummer, Guid verenigingId, bool refresh = false)
        {
            List<ClubCloud_Afhang> afhang = new List<ClubCloud_Afhang>();

            if (SPContext.Current != null && SPContext.Current.Web != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                afhang = client.GetAfhangenForVerenigingById(verenigingId, refresh, new ClubCloud_Setting { Id = int.Parse(bondsnummer), VerenigingId = verenigingId });
            }

            return afhang;

        }
        #endregion

        #region Banen

        public ClubCloud_Baan GetBaanById(string bondsnummer, Guid verenigingId, Guid baanId, bool refresh = false)
        {
            ClubCloud_Baan baan = new ClubCloud_Baan();

            if (SPContext.Current != null && SPContext.Current.Web != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                baan = client.GetBaanById(baanId,refresh,new ClubCloud_Setting{ Id = int.Parse(bondsnummer), VerenigingId = verenigingId});
            }

            return baan;
        }


        //public System.Collections.Generic.List<ClubCloud_Baanschema> GetBaanSchemaByAccommodatieId(string bondsnummer, Guid verenigingId, Guid accommodatieId, bool refresh = false)
        //{
        //    List<ClubCloud_Baanschema> baanschema = new List<ClubCloud_Baanschema>();

        //    if (SPContext.Current != null && SPContext.Current.Web != null)
        //    {
        //        ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
        //        baanschema = client.GetBaanSchemaByAccommodatieId(bondsnummer, verenigingId, accommodatieId, refresh);
        //    }

        //    return baanschema;
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="verenigingId"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        public System.Collections.Generic.List<ClubCloud_Baanschema> GetBaanSchemaByVerenigingId(string bondsnummer, Guid verenigingId, bool refresh = false)
        {
            List<ClubCloud_Baanschema> baanschema = new List<ClubCloud_Baanschema>();

            if (SPContext.Current != null && SPContext.Current.Web != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                baanschema = client.GetBaanschemasForVerenigingById(verenigingId, refresh, new ClubCloud_Setting { Id = int.Parse(bondsnummer), VerenigingId = verenigingId });
            }

            return baanschema;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bondsnummer"></param>
        /// <param name="verenigingId"></param>
        /// <param name="date"></param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        public List<ClubCloud_Baanschema> GetBaanSchemaByDate(string bondsnummer, Guid verenigingId, DateTime date, bool refresh = false)
        {
            List<ClubCloud_Baanschema> baanschema = new List<ClubCloud_Baanschema>();

            if (SPContext.Current != null && SPContext.Current.Web != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                baanschema = client.GetBaanSchemaByDate(bondsnummer, verenigingId, date, refresh);
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


        //public System.Collections.Generic.List<ClubCloud_Baan> GetBanenByVerenigingId(string bondsnummer, Guid verenigingId, bool refresh = false)
        //{
        //    List<ClubCloud_Baan> banen = new List<ClubCloud_Baan>();

        //    if (SPContext.Current != null && SPContext.Current.Web != null)
        //    {
        //        ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
        //        banen = client.GetBanenByVerenigingId(bondsnummer, verenigingId, refresh);
        //    }

        //    return banen;
        //}        

        public List<ClubCloud_Baanblok> GetBaanblokkenByAccommodatieId(string bondsnummer, Guid verenigingId, Guid accommodatieId, bool refresh = false)
        {
            List<ClubCloud_Baanblok> baanblokken = new List<ClubCloud_Baanblok>();

            if (SPContext.Current != null && SPContext.Current.Web != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                baanblokken = client.GetBaanblokkenByAccommodatieId(bondsnummer, verenigingId, accommodatieId, refresh);
            }

            return baanblokken;
        }

        public ClubCloud_Baansoort GetBaansoortById(string bondsnummer, Guid verenigingId, Guid accommodatieId, Guid baansoortId, bool refresh = false)
        {
            ClubCloud_Baansoort baansoort = new ClubCloud_Baansoort();

            if (SPContext.Current != null && SPContext.Current.Web != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                baansoort = client.GetBaansoortById(baansoortId, refresh, new ClubCloud_Setting { Id = int.Parse(bondsnummer), VerenigingId = verenigingId });//, accommodatieId, baansoortId, refresh);
            }

            return baansoort;
        }
        public ClubCloud_Baantype GetBaantypeById(string bondsnummer, Guid verenigingId, Guid accommodatieId, Guid baantypeId, bool refresh = false)
        {
            ClubCloud_Baantype baantype = new ClubCloud_Baantype();

            if (SPContext.Current != null && SPContext.Current.Web != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                baantype = client.GetBaantypeById(baantypeId, refresh, new ClubCloud_Setting { Id = int.Parse(bondsnummer), VerenigingId = verenigingId });//, accommodatieId, BaantypeId, refresh);
            }

            return baantype;
        }


        #endregion

        #region Sponsor

        public List<ClubCloud_Sponsor> GetSponsorenByVerenigingId(string bondsnummer, Guid verenigingId, bool refresh = false)
        {
            List<ClubCloud_Sponsor> sponsoren = new List<ClubCloud_Sponsor>();

            if (SPContext.Current != null && SPContext.Current.Web != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                sponsoren = client.GetSponsorenForVerenigingById(verenigingId, refresh, new ClubCloud_Setting { Id = int.Parse(bondsnummer), VerenigingId = verenigingId });
            }

            return sponsoren;
        }

        public ClubCloud_Sponsor GetSponsorById(string bondsnummer, Guid verenigingId, Guid sponsorId, bool refresh = false)
        {
            ClubCloud_Sponsor sponsor = new ClubCloud_Sponsor();

            if (SPContext.Current != null && SPContext.Current.Web != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                sponsor = client.GetSponsorById(sponsorId, refresh, new ClubCloud_Setting { Id = int.Parse(bondsnummer), VerenigingId = verenigingId });
            }

            return sponsor;
        }

        public ClubCloud_Sponsor_Afbeelding GetSponsorImageById(string bondsnummer, Guid verenigingId, Guid afbeeldingId, bool refresh = false)
        {
            ClubCloud_Sponsor_Afbeelding afbeelding = new ClubCloud_Sponsor_Afbeelding();

            if (SPContext.Current != null && SPContext.Current.Web != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                afbeelding = client.GetAfbeeldingById(afbeeldingId, refresh, new ClubCloud_Setting { Id = int.Parse(bondsnummer), VerenigingId = verenigingId });
            }

            return afbeelding;
        }

        #endregion

        #region Store

        public List<ApplicationInfo> GetApplicationInfos()
        {
            List<ApplicationInfo> infos = new List<ApplicationInfo>();

            if (SPContext.Current != null && SPContext.Current.Web != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                infos = client.GetApplicationInfos();
            }

            return infos;
        }

        public ApplicationVersion GetApplicationVersion(int applicationInfoId, string version)
        {
            ApplicationVersion _version = new ApplicationVersion();

            if (SPContext.Current != null && SPContext.Current.Web != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                _version = client.GetApplicationVersion(applicationInfoId, version);
            }

            return _version;
        }

        public List<ApplicationProcessorArchitecture> GetApplicationProcessorArchitectures(int applicationVersionId, string version)
        {
            List<ApplicationProcessorArchitecture> architecture = new List<ApplicationProcessorArchitecture>();

            if (SPContext.Current != null && SPContext.Current.Web != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                architecture = client.GetApplicationProcessorArchitecture(applicationVersionId, version);
            }

            return architecture;
        }

        #endregion
    }
}
