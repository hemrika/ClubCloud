//-----------------------------------------------------------------------
// <copyright file="HelloWorldRESTService.cs" company="">
// Copyright © 
// </copyright>
//-----------------------------------------------------------------------
namespace ClubCloud.Service
{
    using ClubCloud.Provider;
    using ClubCloud.Model;
    using Microsoft.IdentityModel.Web;
    using Microsoft.SharePoint;
    using Microsoft.SharePoint.Administration;
    using Microsoft.SharePoint.Client.Services;
    using Microsoft.SharePoint.IdentityModel;
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.IdentityModel.Tokens;
    using System.ServiceModel;
    using System.ServiceModel.Activation;
    using System.Web;
    using System.Web.Configuration;
    using System.Web.Security;

    public enum LoginErrorCode
    {
        NoError,
        NotInFormsAuthenticationMode,
        PasswordNotMatch
    }

    public struct LoginResult
    {
        public string CookieName;

        public LoginErrorCode ErrorCode;

        public int TimeoutSeconds;
    }
    /// <summary>
    /// The REST Service.
    /// </summary>    
    [BasicHttpBindingServiceMetadataExchangeEndpoint]
    [ServiceFactoryUsingAuthSchemeInEndpointAddress(UsingAuthSchemeInEndpointAddress = false)]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    //[AspNetHostingPermission(System.Security.Permissions.SecurityAction.)]
    [System.Runtime.InteropServices.Guid("b32b459e-04b5-427f-a0f1-b40dd6f571af")]
    [ServiceBehavior(Namespace = "http://clubcloud.nl/", Name = "ClubCloudMobiel", IncludeExceptionDetailInFaults = true)]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1812:AvoidUninstantiatedInternalClasses", Justification = "Instantiated by the WCF runtime automatically.")]
    public class ClubCloudMobielService : IClubCloudMobielService
    {
        #region Afhangen

        public LoginResult Login(string username, string password)
        {
            SPSessionAuthenticationModule sessionAuthenticationModule = FederatedAuthentication.SessionAuthenticationModule as SPSessionAuthenticationModule;
            sessionAuthenticationModule.CookieHandler.HideFromClientScript = false;

            if (AuthenticationMode.Forms != SPSecurity.AuthenticationMode || sessionAuthenticationModule == null)
            {
                //result.ErrorCode = LoginErrorCode.NotInFormsAuthenticationMode;
                return new LoginResult { ErrorCode = LoginErrorCode.NotInFormsAuthenticationMode };
            }
            if (!SPClaimsUtility.AuthenticateFormsUser(SPAlternateUrl.ContextUri, username, password))
            {
                //result.ErrorCode = LoginErrorCode.PasswordNotMatch;
                return new LoginResult { ErrorCode = LoginErrorCode.PasswordNotMatch };
            }

            TimeSpan formsAuthenticationTimeout = TimeSpan.FromMinutes(30);
            TimeSpan PersistentSessionLifetime = sessionAuthenticationModule.CookieHandler.PersistentSessionLifetime.Value;
            Microsoft.IdentityModel.Tokens.SessionSecurityToken token = sessionAuthenticationModule.ContextSessionSecurityToken;

            return new LoginResult
            {
                ErrorCode = LoginErrorCode.NoError,
                CookieName = sessionAuthenticationModule.CookieHandler.Name,
                TimeoutSeconds = (int)Math.Floor(formsAuthenticationTimeout.TotalSeconds)
            };
        }

        public AuthenticationMode LoginMode()
        {
            return SPSecurity.AuthenticationMode;
        }

        public ClubCloud_Setting GetClubCloudSettings()
        {
            ClubCloud_Setting settings = null;

            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                string bondsnummer = SPContext.Current.Web.CurrentUser.LoginName.Split('|').Last();
                settings = client.GetClubCloudSettings(bondsnummer);
            }

            return settings;
        }

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

        public bool DeleteReservering(string verenigingId, string reserveringId)
        {
            bool deleted = false;

            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                //Guid vId = Guid.Parse(verenigingId);
                //Guid rId = Guid.Parse(reserveringId);
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                deleted = client.DeleteReservering(SPContext.Current.Web.CurrentUser.LoginName, Guid.Parse(verenigingId), Guid.Parse(reserveringId), false);
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

        /*
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
        */

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

        public ClubCloud_Gebruiker GetGebruikerByNummer(string bondsnummer, string verenigingId, string nummer)
        {
            ClubCloud_Gebruiker gebruiker = new ClubCloud_Gebruiker();

            if (SPContext.Current != null && SPContext.Current.Web != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                gebruiker = client.GetGebruikerByNummer(bondsnummer, Guid.Parse(verenigingId), nummer);
            }

            return gebruiker;

        }

        public ClubCloud_Gebruiker GetGebruikerById(string bondsnummer, string verenigingId, string gebruikerId)
        {
            ClubCloud_Gebruiker gebruiker = new ClubCloud_Gebruiker();

            if (SPContext.Current != null && SPContext.Current.Web != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                gebruiker = client.GetGebruikerById(Guid.Parse(gebruikerId), false, new ClubCloud_Setting { Id = int.Parse(bondsnummer), VerenigingId = Guid.Parse(verenigingId) });
            }

            return gebruiker;

        }

        /*
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
        */

        
        public ClubCloud_Foto GetFotoById(string bondsnummer, string verenigingId, string gebruikerId)
        {
            ClubCloud_Foto foto = null;

            if (SPContext.Current != null && SPContext.Current.Web != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                foto = client.GetFotoForGebruikerById(bondsnummer, Guid.Parse(gebruikerId), false, new ClubCloud_Setting { Id = int.Parse(bondsnummer), VerenigingId = Guid.Parse(verenigingId), GebruikerId = Guid.Parse(gebruikerId) });
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

        public ClubCloud_Vereniging GetVerenigingByNummer(string bondsnummer, string verenigingNummer)
        {
            ClubCloud_Vereniging vereniging = new ClubCloud_Vereniging();

            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                string LoginName = SPContext.Current.Web.CurrentUser.LoginName;
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                vereniging = client.GetVerenigingByNummer(bondsnummer, verenigingNummer, false);
            }

            return vereniging;
        }

        public ClubCloud_Vereniging GetVerenigingById(string bondsnummer, string verenigingId)
        {
            ClubCloud_Vereniging vereniging = new ClubCloud_Vereniging();

            if (SPContext.Current != null && SPContext.Current.Web != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                vereniging = client.GetVerenigingById(Guid.Parse(verenigingId), false, new ClubCloud_Setting { Id = int.Parse(bondsnummer), VerenigingId = Guid.Parse(verenigingId) });
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

            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                string LoginName = SPContext.Current.Web.CurrentUser.LoginName;
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                Ureservering = client.UpdateReservering(bondsnummer, verenigingId, reservering, final, push);
            }

            return Ureservering;
        }

        #endregion


        public ClubCloud_Afhang GetVerenigingAfhangSettings(string bondsnummer, string verenigingId)
        {
            ClubCloud_Afhang afhang = new ClubCloud_Afhang();

            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                string LoginName = SPContext.Current.Web.CurrentUser.LoginName;
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                afhang = client.GetVerenigingAfhangSettings(bondsnummer, Guid.Parse(verenigingId), false);
            }

            return afhang;

        }
    }
}
