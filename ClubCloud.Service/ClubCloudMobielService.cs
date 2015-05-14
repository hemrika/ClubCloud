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
        PasswordNotMatch,
        Exception
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
    [System.Runtime.InteropServices.Guid("b32b459e-04b5-427f-a0f1-b40dd6f571af")]
    [ServiceBehavior(Namespace = "http://clubcloud.nl/", Name = "ClubCloudMobiel", IncludeExceptionDetailInFaults = true, AddressFilterMode = AddressFilterMode.Any)]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1812:AvoidUninstantiatedInternalClasses", Justification = "Instantiated by the WCF runtime automatically.")]
    public class ClubCloudMobielService : IClubCloudMobielService
    {
        #region Security

        public LoginResult Login(string username, string password)
        {
            SPSessionAuthenticationModule sessionAuthenticationModule = FederatedAuthentication.SessionAuthenticationModule as SPSessionAuthenticationModule;
            sessionAuthenticationModule.CookieHandler.HideFromClientScript = false;

            TimeSpan formsAuthenticationTimeout = TimeSpan.FromMinutes(30);

            try
            {
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

                
                TimeSpan PersistentSessionLifetime = sessionAuthenticationModule.CookieHandler.PersistentSessionLifetime.Value;
                Microsoft.IdentityModel.Tokens.SessionSecurityToken token = sessionAuthenticationModule.ContextSessionSecurityToken;


                return new LoginResult
                {
                    ErrorCode = LoginErrorCode.NoError,
                    CookieName = sessionAuthenticationModule.CookieHandler.Name,
                    TimeoutSeconds = (int)Math.Floor(formsAuthenticationTimeout.TotalSeconds)
                };
            }
            catch (Exception ex)
            {
                string messge = ex.Message;
                return new LoginResult
                {
                    ErrorCode = LoginErrorCode.Exception,
                    CookieName = sessionAuthenticationModule.CookieHandler.Name,
                    TimeoutSeconds = (int)Math.Floor(formsAuthenticationTimeout.TotalSeconds)
                };

            }
        }

        public AuthenticationMode LoginMode()
        {
            return SPSecurity.AuthenticationMode;
        }

        #endregion

        #region Gebruiker

        public ClubCloud_Gebruiker GetGebruiker()
        {
            ClubCloud_Gebruiker gebruiker = new ClubCloud_Gebruiker();

            int parsed;
            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                string bondsnummer = SPContext.Current.Web.CurrentUser.LoginName.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                    ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                    if (settings != null)
                        gebruiker = client.GetGebruikerById(settings.GebruikerId.Value, false, settings);
                }
            }
            return gebruiker;
        }
       
        public ClubCloud_Setting GetSettings()
        {
            ClubCloud_Setting settings = new ClubCloud_Setting();

            int parsed;
            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                string bondsnummer = SPContext.Current.Web.CurrentUser.LoginName.Split('|').Last();                
                if (int.TryParse(bondsnummer, out parsed))
                {
                    ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                    settings = client.GetClubCloudSettings(bondsnummer);
                    //public List<ClubCloud_Setting> GetSettingsForGebruikerById(
                }
            }
            
            return settings;
        }

        public ClubCloud_Foto GetFoto()
        {
            ClubCloud_Foto foto = new ClubCloud_Foto();

            int parsed;
            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                string bondsnummer = SPContext.Current.Web.CurrentUser.LoginName.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                    ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                    if (settings != null)
                        foto = client.GetFotoForGebruikerById(bondsnummer, settings.GebruikerId.Value, false, settings);
                }
            }

            return foto;
        }

        public List<ClubCloud_Functionaris> GetFunctionarissen()
        {
            List<ClubCloud_Functionaris> result = new List<ClubCloud_Functionaris>();

            int parsed;
            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                string bondsnummer = SPContext.Current.Web.CurrentUser.LoginName.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                    ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                    if (settings != null)
                        result = client.GetFunctionarissenForGebruikerById(settings.GebruikerId.Value, false, settings);
                }
            }

            return result;
        }

        public List<ClubCloud_Lidmaatschap> GetLidmaatschappen()
        {
            List<ClubCloud_Lidmaatschap> result = new List<ClubCloud_Lidmaatschap>();

            int parsed;
            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                string bondsnummer = SPContext.Current.Web.CurrentUser.LoginName.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                    ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                    if (settings != null)
                        result = client.GetLidmaatschappenForGebruikerById(settings.GebruikerId.Value, false, settings);
                }
            }

            return result;
        }

        public List<ClubCloud_Address> GetAddressen()
        {
            List<ClubCloud_Address> result = new List<ClubCloud_Address>();

            int parsed;
            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                string bondsnummer = SPContext.Current.Web.CurrentUser.LoginName.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                    ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                    if (settings != null)
                        result = client.GetAddressenForGebruikerById(settings.GebruikerId.Value, false, settings);
                }
            }

            return result;
        }

        public ClubCloud_Vereniging GetVereniging() 
        {
            ClubCloud_Vereniging result = new ClubCloud_Vereniging();

            int parsed;
            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                string bondsnummer = SPContext.Current.Web.CurrentUser.LoginName.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                    ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                    if (settings != null)
                        result = client.GetVerenigingForGebruikerById(settings.GebruikerId.Value, false, settings);
                }
            }

            return result;
        }

        public List<ClubCloud_Profiel> GetProfielen() 
        {
            List<ClubCloud_Profiel> result = new List<ClubCloud_Profiel>();

            int parsed;
            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                string bondsnummer = SPContext.Current.Web.CurrentUser.LoginName.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                    ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                    if (settings != null)
                        result = client.GetProfielenForGebruikerById(settings.GebruikerId.Value, false, settings);
                }
            }

            return result;
        }

        public ClubCloud_Nationaliteit GetNationaliteit() 
        {
            ClubCloud_Nationaliteit result = new ClubCloud_Nationaliteit();

            int parsed;
            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                string bondsnummer = SPContext.Current.Web.CurrentUser.LoginName.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                    ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                    if (settings != null)
                        result = client.GetNationaliteitForGebruikerById(settings.GebruikerId.Value, false, settings);
                }
            }

            return result;
        }

        #endregion

        #region Vereniging

        public List<ClubCloud_Functionaris> GetFunctionarissenForVereniging()
        {
            List<ClubCloud_Functionaris> result = new List<ClubCloud_Functionaris>();

            int parsed;
            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                string bondsnummer = SPContext.Current.Web.CurrentUser.LoginName.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                    ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                    if (settings != null)
                        result = client.GetFunctionarissenForVerenigingById(settings.VerenigingId.Value, false, settings);
                }
            }

            return result;
        }

        public List<ClubCloud_Bestuursorgaan> GetBestuursorganenForVereniging()
        {
            List<ClubCloud_Bestuursorgaan> result = new List<ClubCloud_Bestuursorgaan>();

            int parsed;
            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                string bondsnummer = SPContext.Current.Web.CurrentUser.LoginName.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                    ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                    if (settings != null)
                        result = client.GetBestuursorganenForVerenigingById(settings.VerenigingId.Value, false, settings);
                }
            }

            return result;
        }

        public ClubCloud_District GetDistrictForVereniging()
        {
            ClubCloud_District result = new ClubCloud_District();

            int parsed;
            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                string bondsnummer = SPContext.Current.Web.CurrentUser.LoginName.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                    ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                    if (settings != null)
                        result = client.GetDistrictForVerenigingById(settings.VerenigingId.Value, false, settings);
                }
            }

            return result;
        }

        public ClubCloud_Accommodatie GetAccommodatieForVereniging()
        {
            ClubCloud_Accommodatie result = new ClubCloud_Accommodatie();

            int parsed;
            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                string bondsnummer = SPContext.Current.Web.CurrentUser.LoginName.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                    ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                    if (settings != null)
                        result = client.GetAccommodatieForVerenigingById(settings.VerenigingId.Value, false, settings);
                }
            }

            return result;
        }

        public List<ClubCloud_Address> GetAddressenForVereniging()
        {
            List<ClubCloud_Address> result = new List<ClubCloud_Address>();

            int parsed;
            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                string bondsnummer = SPContext.Current.Web.CurrentUser.LoginName.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                    ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                    if (settings != null)
                        result = client.GetAddressenForVerenigingById(settings.VerenigingId.Value, false, settings);
                }
            }

            return result;
        }

        public ClubCloud_Regio GetRegioForVereniging()
        {
            ClubCloud_Regio result = new ClubCloud_Regio();

            int parsed;
            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                string bondsnummer = SPContext.Current.Web.CurrentUser.LoginName.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                    ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                    if (settings != null)
                        result = client.GetRegioForVerenigingById(settings.VerenigingId.Value, false, settings);
                }
            }

            return result;
        }

        public List<ClubCloud_Afhang> GetAfhangenForVereniging()
        {
            List<ClubCloud_Afhang> result = new List<ClubCloud_Afhang>();

            int parsed;
            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                string bondsnummer = SPContext.Current.Web.CurrentUser.LoginName.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                    ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                    if (settings != null)
                        result = client.GetAfhangenForVerenigingById(settings.VerenigingId.Value, false, settings);
                }
            }

            return result;
        }

        public List<ClubCloud_Sponsor> GetSponsorenForVereniging()
        {
            List<ClubCloud_Sponsor> result = new List<ClubCloud_Sponsor>();

            int parsed;
            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                string bondsnummer = SPContext.Current.Web.CurrentUser.LoginName.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                    ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                    if (settings != null)
                        result = client.GetSponsorenForVerenigingById(settings.VerenigingId.Value, false, settings);
                }
            }

            return result;
        }

        public List<ClubCloud_Baanschema> GetBaanschemasForVereniging()
        {
            List<ClubCloud_Baanschema> result = new List<ClubCloud_Baanschema>();

            int parsed;
            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                string bondsnummer = SPContext.Current.Web.CurrentUser.LoginName.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                    ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                    if (settings != null)
                        result = client.GetBaanschemasForVerenigingById(settings.VerenigingId.Value, false, settings);
                }
            }

            return result;
        }

        public List<ClubCloud_Lidmaatschapsoort> GetLidmaatschapsoortenForVereniging()
        {
            List<ClubCloud_Lidmaatschapsoort> result = new List<ClubCloud_Lidmaatschapsoort>();

            int parsed;
            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                string bondsnummer = SPContext.Current.Web.CurrentUser.LoginName.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                    ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                    if (settings != null)
                        result = client.GetLidmaatschapsoortenForVerenigingById(settings.VerenigingId.Value, false, settings);
                }
            }

            return result;
        }


        #endregion

        #region Accommodatie

        public ClubCloud_Accommodatie GetAccommodatie(string AccommodatieId)
        {
            ClubCloud_Accommodatie result = new ClubCloud_Accommodatie();

            int parsed;
            Guid Id;
            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                string bondsnummer = SPContext.Current.Web.CurrentUser.LoginName.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                    ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                    if (settings != null && Guid.TryParse(AccommodatieId, out Id))
                        result = client.GetAccommodatieById(Id, false, settings);
                }
            }

            return result;
        }

        public List<ClubCloud_Baanblok> GetBaanblokkenForAccommodatie(string AccommodatieId)
        {
            List<ClubCloud_Baanblok> result = new List<ClubCloud_Baanblok>();

            int parsed;
            Guid Id;
            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                string bondsnummer = SPContext.Current.Web.CurrentUser.LoginName.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                    ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                    if (settings != null && Guid.TryParse(AccommodatieId, out Id))
                        result = client.GetBaanblokkenForAccommodatieById(Id, false, settings);
                }
            }

            return result;
        }

        public List<ClubCloud_Baan> GetBanenForAccommodatie(string AccommodatieId)
        {
            List<ClubCloud_Baan> result = new List<ClubCloud_Baan>();

            int parsed;
            Guid Id;
            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                string bondsnummer = SPContext.Current.Web.CurrentUser.LoginName.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                    ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                    if (settings != null && Guid.TryParse(AccommodatieId, out Id))
                        result = client.GetBanenForAccommodatieById(Id, false, settings);
                }
            }

            return result;
        }

        public List<ClubCloud_BaanSpeciaal> GetBanenSpeciaalForAccommodatie(string AccommodatieId)
        {
            List<ClubCloud_BaanSpeciaal> result = new List<ClubCloud_BaanSpeciaal>();

            int parsed;
            Guid Id;
            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                string bondsnummer = SPContext.Current.Web.CurrentUser.LoginName.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                    ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                    if (settings != null && Guid.TryParse(AccommodatieId, out Id))
                        result = client.GetBanenSpeciaalForAccommodatieById(Id, false, settings);
                }
            }

            return result;
        }

        public List<ClubCloud_Address> GetAddressenForAccommodatie(string AccommodatieId)
        {
            List<ClubCloud_Address> result = new List<ClubCloud_Address>();

            int parsed;
            Guid Id;
            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                string bondsnummer = SPContext.Current.Web.CurrentUser.LoginName.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                    ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                    if (settings != null && Guid.TryParse(AccommodatieId, out Id))
                        result = client.GetAddressenForAccommodatieById(Id, false, settings);
                }
            }

            return result;
        }
        #endregion

        #region Lookup

        public ClubCloud_Gebruiker GetGebruikerByNummer(string nummer)
        {
            ClubCloud_Gebruiker gebruiker = new ClubCloud_Gebruiker();

            int parsed;
            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                string bondsnummer = SPContext.Current.Web.CurrentUser.LoginName.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                    ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                    if (settings != null)
                        gebruiker = client.GetGebruikerByNummer(bondsnummer, settings.VerenigingId.Value, nummer);
                }
            }
            return gebruiker;
        }




        public ClubCloud_Vereniging GetVerenigingByLocation(string Latitude, string Longitude)
        {
            ClubCloud_Vereniging vereniging = new ClubCloud_Vereniging();

            int parsed;
            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                string bondsnummer = SPContext.Current.Web.CurrentUser.LoginName.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                    ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                    if (settings != null)
                        vereniging = client.GetVerenigingByLocation(bondsnummer, double.Parse(Latitude), double.Parse(Longitude), false);
                }
            }
            return vereniging;
        }

        public ClubCloud_Vereniging GetVerenigingByNummer(string verenigingNummer)
        {
            ClubCloud_Vereniging vereniging = new ClubCloud_Vereniging();

            int parsed;
            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                string bondsnummer = SPContext.Current.Web.CurrentUser.LoginName.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                    ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                    if (settings != null)
                        vereniging = client.GetVerenigingByNummer(bondsnummer, verenigingNummer, false);
                }
            }
            return vereniging;
        }

        #endregion

    }
}