﻿//-----------------------------------------------------------------------
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
    using System.Security.Principal;
    using System.ServiceModel.Web;
    using System.Net;
    using System.Runtime.Serialization;
    using ClubCloud.Service.Attributes;
    using Microsoft.SharePoint.Administration.Claims;
    using Microsoft.IdentityModel.Claims;

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

        public string Message;

        public string FedAuth;
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
        private static ClubCloudServiceClient client;

        public static ClubCloudServiceClient Client
        {
            get
            {
                if (client == null)
                    client = new ClubCloudServiceClient(SPServiceContext.Current);

                //client.Proxy.Status == SPObjectStatus.Offline

                return ClubCloudMobielService.client;
            }
            private set { client = value; }
        }

        private static SPFederationAuthenticationModule _FederationAuthenticationModule = null;

        internal static SPFederationAuthenticationModule FederationAuthenticationModule
        {
            get
            {
                if (ClubCloudMobielService._FederationAuthenticationModule == null)
                    ClubCloudMobielService._FederationAuthenticationModule = FederatedAuthentication.WSFederationAuthenticationModule as SPFederationAuthenticationModule;

                return ClubCloudMobielService._FederationAuthenticationModule;
            }
            private set { _FederationAuthenticationModule = value; }
        }

        private static SPSessionAuthenticationModule _SessionAuthenticationModule = null;

        internal static SPSessionAuthenticationModule SessionAuthenticationModule
        {
            get
            {
                if (ClubCloudMobielService._SessionAuthenticationModule == null)
                    ClubCloudMobielService._SessionAuthenticationModule = FederatedAuthentication.SessionAuthenticationModule as SPSessionAuthenticationModule;

                return ClubCloudMobielService._SessionAuthenticationModule;
            }
            private set { _SessionAuthenticationModule = value; }
        }

        /*
        private static SPClaimsAuthenticationManager _ClaimsAuthenticationManager = null;

        public static SPClaimsAuthenticationManager ClaimsAuthenticationManager
        {
            get
            {
                if (ClubCloudMobielService._ClaimsAuthenticationManager == null)
                    _ClaimsAuthenticationManager = FederatedAuthentication.ClaimsPrincipalHttpModule.AuthenticationManager as SPClaimsAuthenticationManager;

                return ClubCloudMobielService._ClaimsAuthenticationManager;
            }
            private set { _ClaimsAuthenticationManager = value; }
        }
        */

        public static bool Authorized
        {
            get
            {
                bool result = false;

                if (HttpContext.Current != null && HttpContext.Current.User != null && HttpContext.Current.User.Identity != null && HttpContext.Current.User.Identity.IsAuthenticated)
                {
                    result = true;
                }
                else
                {
                    IClaimsPrincipal principal = null;
                    string FedAuth_header = HttpContext.Current.Request.Headers.Get("FedAuth");                    

                    if (!string.IsNullOrWhiteSpace(FedAuth_header))
                    {
                        byte[] FedAuth_bytes = System.Convert.FromBase64String(FedAuth_header);
                        Microsoft.IdentityModel.Tokens.SessionSecurityToken sstoken = SessionAuthenticationModule.ReadSessionTokenFromCookie(FedAuth_bytes);

                        principal = sstoken.ClaimsPrincipal;

                        if (sstoken.ClaimsPrincipal.Identity.IsAuthenticated)
                            FederationAuthenticationModule.SetPrincipalAndWriteSessionToken(sstoken, false);
                        else
                            SessionAuthenticationModule.AuthenticateSessionSecurityToken(sstoken, true);
                            //principal = ClaimsAuthenticationManager.Authenticate(string.Empty, sstoken.ClaimsPrincipal); FederationAuthenticationModule.SetPrincipalAndWriteSessionToken(sstoken, false);

                        
                    }

                    if(principal != null)
                        result = principal.Identity.IsAuthenticated;
                    /*
                    if (principal != null)
                    {
                        IClaimsIdentity claimsIdentity = (IClaimsIdentity)principal.Identity;

                        foreach (Claim claim in claimsIdentity.Claims)
                        {
                            string ClaimType = claim.ClaimType;
                            string Value = claim.Value;
                        }
                    }
                    */
                }

                if (!result)
                    HttpContext.Current.Items.Add("Send401ForceAuthenticationContextItemKey", true);

                    //HttpContext.Current.Items.Add("Send401ForceAuthenticationContextItemKey", true);
                    //WebOperationContext.Current.OutgoingResponse.StatusCode = HttpStatusCode.Unauthorized; FederationAuthenticationModule.PassiveRedirectEnabled = false; HttpContext.Current.Response.StatusCode = (int)HttpStatusCode.Unauthorized;


                return result;
            }
        }

        public static bool Forbidden
        {
            get
            {
                WebOperationContext.Current.OutgoingResponse.StatusCode = HttpStatusCode.Forbidden;
                HttpContext.Current.Response.StatusCode = (int)HttpStatusCode.Forbidden;
                HttpContext.Current.ApplicationInstance.CompleteRequest();
                return true;
            }
        }
        public static bool InternalServerError
        {
            get
            {
                WebOperationContext.Current.OutgoingResponse.StatusCode = HttpStatusCode.InternalServerError;
                HttpContext.Current.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                HttpContext.Current.ApplicationInstance.CompleteRequest();
                return true;
            }
        }

        #region Security

        public LoginResult Login(string username, string password)
        {
            try
            {
                if (AuthenticationMode.Forms != SPSecurity.AuthenticationMode || SessionAuthenticationModule == null)
                {
                    return new LoginResult { ErrorCode = LoginErrorCode.NotInFormsAuthenticationMode, Message = "NotInFormsAuthenticationMode" };
                }
                if (!SPClaimsUtility.AuthenticateFormsUser(SPAlternateUrl.ContextUri, username, password))
                {
                    return new LoginResult { ErrorCode = LoginErrorCode.PasswordNotMatch, Message = "PasswordNotMatch" };
                }

                return new LoginResult
                {
                    ErrorCode = LoginErrorCode.NoError,
                    CookieName = SessionAuthenticationModule.CookieHandler.Name,
                    TimeoutSeconds = SessionAuthenticationModule.CookieHandler.PersistentSessionLifetime.Value.Seconds,
                    FedAuth = HttpContext.Current.Response.Cookies.Get(SessionAuthenticationModule.CookieHandler.Name).Value
                };
            }
            catch (Exception ex)
            {
                string messge = ex.Message;
                return new LoginResult
                {
                    ErrorCode = LoginErrorCode.Exception,
                    Message = ex.Message
                };
            }
        }

        public void Logout()
        {
            FederationAuthenticationModule.SignOut(true);
            SessionAuthenticationModule.SignOut();            
        }

        #endregion

        #region Gebruiker

        public ClubCloud_Gebruiker GetGebruiker()
        {
            ClubCloud_Gebruiker gebruiker = new ClubCloud_Gebruiker();

            int parsed;

            if (HttpContext.Current != null && HttpContext.Current.User != null && HttpContext.Current.User.Identity != null && HttpContext.Current.User.Identity.IsAuthenticated)
            {
                string bondsnummer = HttpContext.Current.User.Identity.Name.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    try
                    {
                        ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                        ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                        if (settings != null)
                            gebruiker = client.GetGebruikerById(settings.GebruikerId.Value, false, settings);
                    }
                    catch (Exception ex)
                    {
                        throw new WebFaultException<string>(ex.Message, HttpStatusCode.InternalServerError);
                    }
                }
                else
                {
                    throw new WebFaultException(HttpStatusCode.Forbidden);
                }
            }
            else
            {
                throw new WebFaultException(HttpStatusCode.Unauthorized);
            }

            return gebruiker;
        }

        public ClubCloud_Setting GetSettings()
        {
            ClubCloud_Setting settings = new ClubCloud_Setting();

            int parsed;
            if (HttpContext.Current != null && HttpContext.Current.User != null && HttpContext.Current.User.Identity != null && HttpContext.Current.User.Identity.IsAuthenticated)
            {
                string bondsnummer = HttpContext.Current.User.Identity.Name.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    try
                    {
                        ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                        settings = client.GetClubCloudSettings(bondsnummer);
                        //public List<ClubCloud_Setting> GetSettingsForGebruikerById(
                    }
                    catch (Exception ex)
                    {
                        throw new WebFaultException<string>(ex.Message, HttpStatusCode.InternalServerError);
                    }
                }
                else
                {
                    throw new WebFaultException(HttpStatusCode.Forbidden);
                }
            }
            else
            {
                throw new WebFaultException(HttpStatusCode.Unauthorized);
            }

            return settings;
        }

        public ClubCloud_Foto GetFoto()
        {
            ClubCloud_Foto foto = new ClubCloud_Foto();

            int parsed;
            if (HttpContext.Current != null && HttpContext.Current.User != null && HttpContext.Current.User.Identity != null && HttpContext.Current.User.Identity.IsAuthenticated)
            {
                string bondsnummer = HttpContext.Current.User.Identity.Name.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    try
                    {
                        ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                        ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                        if (settings != null)
                            foto = client.GetFotoForGebruikerById(bondsnummer, settings.GebruikerId.Value, false, settings);
                    }
                    catch (Exception ex)
                    {
                        throw new WebFaultException<string>(ex.Message, HttpStatusCode.InternalServerError);
                    }
                }
                else
                {
                    throw new WebFaultException(HttpStatusCode.Forbidden);
                }
            }
            else
            {
                throw new WebFaultException(HttpStatusCode.Unauthorized);
            }

            return foto;
        }

        public List<ClubCloud_Functionaris> GetFunctionarissen()
        {
            List<ClubCloud_Functionaris> result = new List<ClubCloud_Functionaris>();

            int parsed;
            if (HttpContext.Current != null && HttpContext.Current.User != null && HttpContext.Current.User.Identity != null && HttpContext.Current.User.Identity.IsAuthenticated)
            {
                string bondsnummer = HttpContext.Current.User.Identity.Name.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    try
                    {
                        ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                        ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                        if (settings != null)
                            result = client.GetFunctionarissenForGebruikerById(settings.GebruikerId.Value, false, settings);
                    }
                    catch (Exception ex)
                    {
                        throw new WebFaultException<string>(ex.Message, HttpStatusCode.InternalServerError);
                    }
                }
                else
                {
                    throw new WebFaultException(HttpStatusCode.Forbidden);
                }
            }
            else
            {
                throw new WebFaultException(HttpStatusCode.Unauthorized);
            }

            return result;
        }

        public List<ClubCloud_Lidmaatschap> GetLidmaatschappen()
        {
            List<ClubCloud_Lidmaatschap> result = new List<ClubCloud_Lidmaatschap>();

            int parsed;
            if (HttpContext.Current != null && HttpContext.Current.User != null && HttpContext.Current.User.Identity != null && HttpContext.Current.User.Identity.IsAuthenticated)
            {
                string bondsnummer = HttpContext.Current.User.Identity.Name.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    try
                    {
                        ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                        ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                        if (settings != null)
                            result = client.GetLidmaatschappenForGebruikerById(settings.GebruikerId.Value, false, settings);
                    }
                    catch (Exception ex)
                    {
                        throw new WebFaultException<string>(ex.Message, HttpStatusCode.InternalServerError);
                    }
                }
                else
                {
                    throw new WebFaultException(HttpStatusCode.Forbidden);
                }
            }
            else
            {
                throw new WebFaultException(HttpStatusCode.Unauthorized);
            }


            return result;
        }

        public List<ClubCloud_Address> GetAddressen()
        {
            List<ClubCloud_Address> result = new List<ClubCloud_Address>();

            int parsed;
            
            if (Authorized)
            {
                string bondsnummer = HttpContext.Current.User.Identity.Name.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    try
                    {
                        ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                        ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                        if (settings != null)
                            result = client.GetAddressenForGebruikerById(settings.GebruikerId.Value, false, settings);
                    }
                    catch (Exception ex)
                    {
                        WebOperationContext.Current.OutgoingResponse.StatusCode = HttpStatusCode.InternalServerError;
                        //throw new WebFaultException<string>(ex.Message, HttpStatusCode.InternalServerError);
                    }
                }
                else
                {
                    WebOperationContext.Current.OutgoingResponse.StatusCode = HttpStatusCode.Forbidden;
                    throw new WebFaultException(HttpStatusCode.Forbidden);
                }
            }
            /*
            else
            {
                WebOperationContext.Current.OutgoingResponse.StatusCode = HttpStatusCode.Unauthorized;
                //throw new WebFaultException(HttpStatusCode.Unauthorized);
            }
            */

            return result;
        }

        public ClubCloud_Vereniging GetVereniging()
        {
            ClubCloud_Vereniging result = new ClubCloud_Vereniging();

            int parsed;
            if (HttpContext.Current != null && HttpContext.Current.User != null && HttpContext.Current.User.Identity != null && HttpContext.Current.User.Identity.IsAuthenticated)
            {
                string bondsnummer = HttpContext.Current.User.Identity.Name.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    try
                    {
                        ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                        ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                        if (settings != null)
                            result = client.GetVerenigingForGebruikerById(settings.GebruikerId.Value, false, settings);
                    }
                    catch (Exception ex)
                    {
                        throw new WebFaultException<string>(ex.Message, HttpStatusCode.InternalServerError);
                    }
                }
                else
                {
                    throw new WebFaultException(HttpStatusCode.Forbidden);
                }
            }
            else
            {
                throw new WebFaultException(HttpStatusCode.Unauthorized);
            }


            return result;
        }

        public List<ClubCloud_Profiel> GetProfielen()
        {
            List<ClubCloud_Profiel> result = new List<ClubCloud_Profiel>();

            int parsed;
            if (HttpContext.Current != null && HttpContext.Current.User != null && HttpContext.Current.User.Identity != null && HttpContext.Current.User.Identity.IsAuthenticated)
            {
                string bondsnummer = HttpContext.Current.User.Identity.Name.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    try
                    {
                        ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                        ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                        if (settings != null)
                            result = client.GetProfielenForGebruikerById(settings.GebruikerId.Value, false, settings);
                    }
                    catch (Exception ex)
                    {
                        throw new WebFaultException<string>(ex.Message, HttpStatusCode.InternalServerError);
                    }
                }
                else
                {
                    throw new WebFaultException(HttpStatusCode.Forbidden);
                }
            }
            else
            {
                throw new WebFaultException(HttpStatusCode.Unauthorized);
            }


            return result;
        }

        public ClubCloud_Nationaliteit GetNationaliteitForGebruiker()
        {
            ClubCloud_Nationaliteit result = new ClubCloud_Nationaliteit();

            int parsed;
            if (HttpContext.Current != null && HttpContext.Current.User != null && HttpContext.Current.User.Identity != null && HttpContext.Current.User.Identity.IsAuthenticated)
            {
                string bondsnummer = HttpContext.Current.User.Identity.Name.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    try
                    {
                        ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                        ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                        if (settings != null)
                            result = client.GetNationaliteitForGebruikerById(settings.GebruikerId.Value, false, settings);
                    }
                    catch (Exception ex)
                    {
                        throw new WebFaultException<string>(ex.Message, HttpStatusCode.InternalServerError);
                    }
                }
                else
                {
                    throw new WebFaultException(HttpStatusCode.Forbidden);
                }
            }
            else
            {
                throw new WebFaultException(HttpStatusCode.Unauthorized);
            }

            return result;
        }

        #endregion

        #region Vereniging

        public List<ClubCloud_Functionaris> GetFunctionarissenForVereniging()
        {
            List<ClubCloud_Functionaris> result = new List<ClubCloud_Functionaris>();

            int parsed;
            if (HttpContext.Current != null && HttpContext.Current.User != null && HttpContext.Current.User.Identity != null && HttpContext.Current.User.Identity.IsAuthenticated)
            {
                string bondsnummer = HttpContext.Current.User.Identity.Name.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    try
                    {
                        ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                        ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                        if (settings != null)
                            result = client.GetFunctionarissenForVerenigingById(settings.VerenigingId.Value, false, settings);
                    }
                    catch (Exception ex)
                    {
                        throw new WebFaultException<string>(ex.Message, HttpStatusCode.InternalServerError);
                    }
                }
                else
                {
                    throw new WebFaultException(HttpStatusCode.Forbidden);
                }
            }
            else
            {
                throw new WebFaultException(HttpStatusCode.Unauthorized);
            }

            return result;
        }

        public List<ClubCloud_Bestuursorgaan> GetBestuursorganenForVereniging()
        {
            List<ClubCloud_Bestuursorgaan> result = new List<ClubCloud_Bestuursorgaan>();

            int parsed;
            if (HttpContext.Current != null && HttpContext.Current.User != null && HttpContext.Current.User.Identity != null && HttpContext.Current.User.Identity.IsAuthenticated)
            {
                string bondsnummer = HttpContext.Current.User.Identity.Name.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    try
                    {
                        ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                        ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                        if (settings != null)
                            result = client.GetBestuursorganenForVerenigingById(settings.VerenigingId.Value, false, settings);
                    }
                    catch (Exception ex)
                    {
                        throw new WebFaultException<string>(ex.Message, HttpStatusCode.InternalServerError);
                    }
                }
                else
                {
                    throw new WebFaultException(HttpStatusCode.Forbidden);
                }
            }
            else
            {
                throw new WebFaultException(HttpStatusCode.Unauthorized);
            }

            return result;
        }

        public ClubCloud_District GetDistrictForVereniging()
        {
            ClubCloud_District result = new ClubCloud_District();

            int parsed;
            if (HttpContext.Current != null && HttpContext.Current.User != null && HttpContext.Current.User.Identity != null && HttpContext.Current.User.Identity.IsAuthenticated)
            {
                string bondsnummer = HttpContext.Current.User.Identity.Name.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    try
                    {
                        ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                        ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                        if (settings != null)
                            result = client.GetDistrictForVerenigingById(settings.VerenigingId.Value, false, settings);
                    }
                    catch (Exception ex)
                    {
                        throw new WebFaultException<string>(ex.Message, HttpStatusCode.InternalServerError);
                    }
                }
                else
                {
                    throw new WebFaultException(HttpStatusCode.Forbidden);
                }
            }
            else
            {
                throw new WebFaultException(HttpStatusCode.Unauthorized);
            }

            return result;
        }

        public ClubCloud_Accommodatie GetAccommodatieForVereniging()
        {
            ClubCloud_Accommodatie result = new ClubCloud_Accommodatie();

            int parsed;
            if (HttpContext.Current != null && HttpContext.Current.User != null && HttpContext.Current.User.Identity != null && HttpContext.Current.User.Identity.IsAuthenticated)
            {
                string bondsnummer = HttpContext.Current.User.Identity.Name.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    try
                    {
                        ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                        ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                        if (settings != null)
                            result = client.GetAccommodatieForVerenigingById(settings.VerenigingId.Value, false, settings);
                    }
                    catch (Exception ex)
                    {
                        throw new WebFaultException<string>(ex.Message, HttpStatusCode.InternalServerError);
                    }
                }
                else
                {
                    throw new WebFaultException(HttpStatusCode.Forbidden);
                }
            }
            else
            {
                throw new WebFaultException(HttpStatusCode.Unauthorized);
            }

            return result;
        }

        public List<ClubCloud_Address> GetAddressenForVereniging()
        {
            List<ClubCloud_Address> result = new List<ClubCloud_Address>();

            int parsed;
            if (HttpContext.Current != null && HttpContext.Current.User != null && HttpContext.Current.User.Identity != null && HttpContext.Current.User.Identity.IsAuthenticated)
            {
                string bondsnummer = HttpContext.Current.User.Identity.Name.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    try
                    {
                        ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                        ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                        if (settings != null)
                            result = client.GetAddressenForVerenigingById(settings.VerenigingId.Value, false, settings);
                    }
                    catch (Exception ex)
                    {
                        throw new WebFaultException<string>(ex.Message, HttpStatusCode.InternalServerError);
                    }
                }
                else
                {
                    throw new WebFaultException(HttpStatusCode.Forbidden);
                }
            }
            else
            {
                throw new WebFaultException(HttpStatusCode.Unauthorized);
            }

            return result;
        }

        public ClubCloud_Regio GetRegioForVereniging()
        {
            ClubCloud_Regio result = new ClubCloud_Regio();

            int parsed;
            if (HttpContext.Current != null && HttpContext.Current.User != null && HttpContext.Current.User.Identity != null && HttpContext.Current.User.Identity.IsAuthenticated)
            {
                string bondsnummer = HttpContext.Current.User.Identity.Name.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    try
                    {
                        ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                        ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                        if (settings != null)
                            result = client.GetRegioForVerenigingById(settings.VerenigingId.Value, false, settings);
                    }
                    catch (Exception ex)
                    {
                        throw new WebFaultException<string>(ex.Message, HttpStatusCode.InternalServerError);
                    }
                }
                else
                {
                    throw new WebFaultException(HttpStatusCode.Forbidden);
                }
            }
            else
            {
                throw new WebFaultException(HttpStatusCode.Unauthorized);
            }

            return result;
        }

        public List<ClubCloud_Afhang> GetAfhangenForVereniging()
        {
            List<ClubCloud_Afhang> result = new List<ClubCloud_Afhang>();

            int parsed;
            if (HttpContext.Current != null && HttpContext.Current.User != null && HttpContext.Current.User.Identity != null && HttpContext.Current.User.Identity.IsAuthenticated)
            {
                string bondsnummer = HttpContext.Current.User.Identity.Name.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    try
                    {
                        ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                        ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                        if (settings != null)
                            result = client.GetAfhangenForVerenigingById(settings.VerenigingId.Value, false, settings);
                    }
                    catch (Exception ex)
                    {
                        throw new WebFaultException<string>(ex.Message, HttpStatusCode.InternalServerError);
                    }
                }
                else
                {
                    throw new WebFaultException(HttpStatusCode.Forbidden);
                }
            }
            else
            {
                throw new WebFaultException(HttpStatusCode.Unauthorized);
            }

            return result;
        }

        public List<ClubCloud_Sponsor> GetSponsorenForVereniging()
        {
            List<ClubCloud_Sponsor> result = new List<ClubCloud_Sponsor>();

            int parsed;
            if (HttpContext.Current != null && HttpContext.Current.User != null && HttpContext.Current.User.Identity != null && HttpContext.Current.User.Identity.IsAuthenticated)
            {
                string bondsnummer = HttpContext.Current.User.Identity.Name.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    try
                    {
                        ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                        ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                        if (settings != null)
                            result = client.GetSponsorenForVerenigingById(settings.VerenigingId.Value, false, settings);
                    }
                    catch (Exception ex)
                    {
                        throw new WebFaultException<string>(ex.Message, HttpStatusCode.InternalServerError);
                    }
                }
                else
                {
                    throw new WebFaultException(HttpStatusCode.Forbidden);
                }
            }
            else
            {
                throw new WebFaultException(HttpStatusCode.Unauthorized);
            }

            return result;
        }

        public List<ClubCloud_Baanschema> GetBaanschemasForVereniging()
        {
            List<ClubCloud_Baanschema> result = new List<ClubCloud_Baanschema>();

            int parsed;
            if (HttpContext.Current != null && HttpContext.Current.User != null && HttpContext.Current.User.Identity != null && HttpContext.Current.User.Identity.IsAuthenticated)
            {
                string bondsnummer = HttpContext.Current.User.Identity.Name.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    try
                    {
                        ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                        ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                        if (settings != null)
                            result = client.GetBaanschemasForVerenigingById(settings.VerenigingId.Value, false, settings);
                    }
                    catch (Exception ex)
                    {
                        throw new WebFaultException<string>(ex.Message, HttpStatusCode.InternalServerError);
                    }
                }
                else
                {
                    throw new WebFaultException(HttpStatusCode.Forbidden);
                }
            }
            else
            {
                throw new WebFaultException(HttpStatusCode.Unauthorized);
            }

            return result;
        }

        public List<ClubCloud_Lidmaatschapsoort> GetLidmaatschapsoortenForVereniging()
        {
            List<ClubCloud_Lidmaatschapsoort> result = new List<ClubCloud_Lidmaatschapsoort>();

            int parsed;
            if (HttpContext.Current != null && HttpContext.Current.User != null && HttpContext.Current.User.Identity != null && HttpContext.Current.User.Identity.IsAuthenticated)
            {
                string bondsnummer = HttpContext.Current.User.Identity.Name.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    try
                    {
                        ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                        ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                        if (settings != null)
                            result = client.GetLidmaatschapsoortenForVerenigingById(settings.VerenigingId.Value, false, settings);
                    }
                    catch (Exception ex)
                    {
                        throw new WebFaultException<string>(ex.Message, HttpStatusCode.InternalServerError);
                    }
                }
                else
                {
                    throw new WebFaultException(HttpStatusCode.Forbidden);
                }
            }
            else
            {
                throw new WebFaultException(HttpStatusCode.Unauthorized);
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
            if (HttpContext.Current != null && HttpContext.Current.User != null && HttpContext.Current.User.Identity != null && HttpContext.Current.User.Identity.IsAuthenticated)
            {
                string bondsnummer = HttpContext.Current.User.Identity.Name.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    try
                    {
                        ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                        ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                        if (settings != null && Guid.TryParse(AccommodatieId, out Id))
                            result = client.GetAccommodatieById(Id, false, settings);
                    }
                    catch (Exception ex)
                    {
                        throw new WebFaultException<string>(ex.Message, HttpStatusCode.InternalServerError);
                    }
                }
                else
                {
                    throw new WebFaultException(HttpStatusCode.Forbidden);
                }
            }
            else
            {
                throw new WebFaultException(HttpStatusCode.Unauthorized);
            }

            return result;
        }

        public List<ClubCloud_Baanblok> GetBaanblokkenForAccommodatie(string AccommodatieId)
        {
            List<ClubCloud_Baanblok> result = new List<ClubCloud_Baanblok>();

            int parsed;
            Guid Id;
            if (HttpContext.Current != null && HttpContext.Current.User != null && HttpContext.Current.User.Identity != null && HttpContext.Current.User.Identity.IsAuthenticated)
            {
                string bondsnummer = HttpContext.Current.User.Identity.Name.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    try
                    {
                        ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                        ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                        if (settings != null && Guid.TryParse(AccommodatieId, out Id))
                            result = client.GetBaanblokkenForAccommodatieById(Id, false, settings);
                    }
                    catch (Exception ex)
                    {
                        throw new WebFaultException<string>(ex.Message, HttpStatusCode.InternalServerError);
                    }
                }
                else
                {
                    throw new WebFaultException(HttpStatusCode.Forbidden);
                }
            }
            else
            {
                throw new WebFaultException(HttpStatusCode.Unauthorized);
            }

            return result;
        }

        public List<ClubCloud_Baan> GetBanenForAccommodatie(string AccommodatieId)
        {
            List<ClubCloud_Baan> result = new List<ClubCloud_Baan>();

            int parsed;
            Guid Id;
            if (HttpContext.Current != null && HttpContext.Current.User != null && HttpContext.Current.User.Identity != null && HttpContext.Current.User.Identity.IsAuthenticated)
            {
                string bondsnummer = HttpContext.Current.User.Identity.Name.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    try
                    {
                        ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                        ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                        if (settings != null && Guid.TryParse(AccommodatieId, out Id))
                            result = client.GetBanenForAccommodatieById(Id, false, settings);
                    }
                    catch (Exception ex)
                    {
                        throw new WebFaultException<string>(ex.Message, HttpStatusCode.InternalServerError);
                    }
                }
                else
                {
                    throw new WebFaultException(HttpStatusCode.Forbidden);
                }
            }
            else
            {
                throw new WebFaultException(HttpStatusCode.Unauthorized);
            }


            return result;
        }

        public List<ClubCloud_BaanSpeciaal> GetBanenSpeciaalForAccommodatie(string AccommodatieId)
        {
            List<ClubCloud_BaanSpeciaal> result = new List<ClubCloud_BaanSpeciaal>();

            int parsed;
            Guid Id;
            if (HttpContext.Current != null && HttpContext.Current.User != null && HttpContext.Current.User.Identity != null && HttpContext.Current.User.Identity.IsAuthenticated)
            {
                string bondsnummer = HttpContext.Current.User.Identity.Name.Split('|').Last();
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
            if (HttpContext.Current != null && HttpContext.Current.User != null && HttpContext.Current.User.Identity != null && HttpContext.Current.User.Identity.IsAuthenticated)
            {
                string bondsnummer = HttpContext.Current.User.Identity.Name.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    try
                    {
                        ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                        ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                        if (settings != null && Guid.TryParse(AccommodatieId, out Id))
                            result = client.GetAddressenForAccommodatieById(Id, false, settings);
                    }
                    catch (Exception ex)
                    {
                        throw new WebFaultException<string>(ex.Message, HttpStatusCode.InternalServerError);
                    }
                }
                else
                {
                    throw new WebFaultException(HttpStatusCode.Forbidden);
                }
            }
            else
            {
                throw new WebFaultException(HttpStatusCode.Unauthorized);
            }

            return result;
        }

        #endregion

        #region Reservering

        public List<ClubCloud_Reservering> GetReserveringen()
        {
            List<ClubCloud_Reservering> result = new List<ClubCloud_Reservering>();

            int parsed;
            if (HttpContext.Current != null && HttpContext.Current.User != null && HttpContext.Current.User.Identity != null && HttpContext.Current.User.Identity.IsAuthenticated)
            {
                string bondsnummer = HttpContext.Current.User.Identity.Name.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    try
                    {
                        ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                        ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                        if (settings != null)
                            result = client.GetReserveringenByBondsnummer(bondsnummer, settings.VerenigingId.Value, bondsnummer, false);
                    }
                    catch (Exception ex)
                    {
                        throw new WebFaultException<string>(ex.Message, HttpStatusCode.InternalServerError);
                    }
                }
                else
                {
                    throw new WebFaultException(HttpStatusCode.Forbidden);
                }
            }
            else
            {
                throw new WebFaultException(HttpStatusCode.Unauthorized);
            }

            return result;
        }

        #endregion

        #region Lookup

        public ClubCloud_Land GetLand(string LandId)
        {
            ClubCloud_Land result = new ClubCloud_Land();

            int parsed;
            Guid Id;
            if (HttpContext.Current != null && HttpContext.Current.User != null && HttpContext.Current.User.Identity != null && HttpContext.Current.User.Identity.IsAuthenticated)
            {
                string bondsnummer = HttpContext.Current.User.Identity.Name.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    try
                    {
                        ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                        ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                        if (settings != null && Guid.TryParse(LandId, out Id))
                            result = client.GetLandById(Id, false, settings);
                    }
                    catch (Exception ex)
                    {
                        throw new WebFaultException<string>(ex.Message, HttpStatusCode.InternalServerError);
                    }
                }
                else
                {
                    throw new WebFaultException(HttpStatusCode.Forbidden);
                }
            }
            else
            {
                throw new WebFaultException(HttpStatusCode.Unauthorized);
            }

            return result;
        }

        public ClubCloud_District GetDistrict(string DistrictId)
        {
            ClubCloud_District result = new ClubCloud_District();

            int parsed;
            Guid Id;
            if (HttpContext.Current != null && HttpContext.Current.User != null && HttpContext.Current.User.Identity != null && HttpContext.Current.User.Identity.IsAuthenticated)
            {
                string bondsnummer = HttpContext.Current.User.Identity.Name.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    try
                    {
                        ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                        ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                        if (settings != null && Guid.TryParse(DistrictId, out Id))
                            result = client.GetDistrictById(Id, false, settings);
                    }
                    catch (Exception ex)
                    {
                        throw new WebFaultException<string>(ex.Message, HttpStatusCode.InternalServerError);
                    }
                }
                else
                {
                    throw new WebFaultException(HttpStatusCode.Forbidden);
                }
            }
            else
            {
                throw new WebFaultException(HttpStatusCode.Unauthorized);
            }

            return result;
        }

        public ClubCloud_Regio GetRegio(string RegioId)
        {
            ClubCloud_Regio result = new ClubCloud_Regio();

            int parsed;
            Guid Id;
            if (HttpContext.Current != null && HttpContext.Current.User != null && HttpContext.Current.User.Identity != null && HttpContext.Current.User.Identity.IsAuthenticated)
            {
                string bondsnummer = HttpContext.Current.User.Identity.Name.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    try
                    {
                        ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                        ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                        if (settings != null && Guid.TryParse(RegioId, out Id))
                            result = client.GetRegioById(Id, false, settings);
                    }
                    catch (Exception ex)
                    {
                        throw new WebFaultException<string>(ex.Message, HttpStatusCode.InternalServerError);
                    }
                }
                else
                {
                    throw new WebFaultException(HttpStatusCode.Forbidden);
                }
            }
            else
            {
                throw new WebFaultException(HttpStatusCode.Unauthorized);
            }

            return result;
        }

        public ClubCloud_Rechtsvorm GetRechtsvorm(string RechtsvormId)
        {
            ClubCloud_Rechtsvorm result = new ClubCloud_Rechtsvorm();

            int parsed;
            Guid Id;
            if (HttpContext.Current != null && HttpContext.Current.User != null && HttpContext.Current.User.Identity != null && HttpContext.Current.User.Identity.IsAuthenticated)
            {
                string bondsnummer = HttpContext.Current.User.Identity.Name.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    try
                    {
                        ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                        ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                        if (settings != null && Guid.TryParse(RechtsvormId, out Id))
                            result = client.GetRechtsvormById(Id, false, settings);
                    }
                    catch (Exception ex)
                    {
                        throw new WebFaultException<string>(ex.Message, HttpStatusCode.InternalServerError);
                    }
                }
                else
                {
                    throw new WebFaultException(HttpStatusCode.Forbidden);
                }
            }
            else
            {
                throw new WebFaultException(HttpStatusCode.Unauthorized);
            }

            return result;
        }

        public ClubCloud_Bestuursorgaan GetBestuursorgaan(string BestuursorgaanId)
        {
            ClubCloud_Bestuursorgaan result = new ClubCloud_Bestuursorgaan();

            int parsed;
            Guid Id;
            if (HttpContext.Current != null && HttpContext.Current.User != null && HttpContext.Current.User.Identity != null && HttpContext.Current.User.Identity.IsAuthenticated)
            {
                string bondsnummer = HttpContext.Current.User.Identity.Name.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    try
                    {
                        ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                        ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                        if (settings != null && Guid.TryParse(BestuursorgaanId, out Id))
                            result = client.GetBestuursorgaanById(Id, false, settings);
                    }
                    catch (Exception ex)
                    {
                        throw new WebFaultException<string>(ex.Message, HttpStatusCode.InternalServerError);
                    }
                }
                else
                {
                    throw new WebFaultException(HttpStatusCode.Forbidden);
                }
            }
            else
            {
                throw new WebFaultException(HttpStatusCode.Unauthorized);
            }

            return result;
        }

        public ClubCloud_Functie GetFunctie(string FunctieId)
        {
            ClubCloud_Functie result = new ClubCloud_Functie();

            int parsed;
            Guid Id;
            if (HttpContext.Current != null && HttpContext.Current.User != null && HttpContext.Current.User.Identity != null && HttpContext.Current.User.Identity.IsAuthenticated)
            {
                string bondsnummer = HttpContext.Current.User.Identity.Name.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    try
                    {
                        ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                        ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                        if (settings != null && Guid.TryParse(FunctieId, out Id))
                            result = client.GetFunctieById(Id, false, settings);
                    }
                    catch (Exception ex)
                    {
                        throw new WebFaultException<string>(ex.Message, HttpStatusCode.InternalServerError);
                    }
                }
                else
                {
                    throw new WebFaultException(HttpStatusCode.Forbidden);
                }
            }
            else
            {
                throw new WebFaultException(HttpStatusCode.Unauthorized);
            }

            return result;
        }

        public ClubCloud_Lidmaatschapsoort GetLidmaatschapsoort(string LidmaatschapsoortId)
        {
            ClubCloud_Lidmaatschapsoort result = new ClubCloud_Lidmaatschapsoort();

            int parsed;
            Guid Id;
            if (HttpContext.Current != null && HttpContext.Current.User != null && HttpContext.Current.User.Identity != null && HttpContext.Current.User.Identity.IsAuthenticated)
            {
                string bondsnummer = HttpContext.Current.User.Identity.Name.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    try
                    {
                        ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                        ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                        if (settings != null && Guid.TryParse(LidmaatschapsoortId, out Id))
                            result = client.GetLidmaatschapsoortById(Id, false, settings);
                    }
                    catch (Exception ex)
                    {
                        throw new WebFaultException<string>(ex.Message, HttpStatusCode.InternalServerError);
                    }
                }
                else
                {
                    throw new WebFaultException(HttpStatusCode.Forbidden);
                }
            }
            else
            {
                throw new WebFaultException(HttpStatusCode.Unauthorized);
            }

            return result;
        }

        public ClubCloud_Nationaliteit GetNationaliteit(string NationaliteitId)
        {
            ClubCloud_Nationaliteit result = new ClubCloud_Nationaliteit();

            int parsed;
            Guid Id;
            if (HttpContext.Current != null && HttpContext.Current.User != null && HttpContext.Current.User.Identity != null && HttpContext.Current.User.Identity.IsAuthenticated)
            {
                string bondsnummer = HttpContext.Current.User.Identity.Name.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    try
                    {
                        ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                        ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                        if (settings != null && Guid.TryParse(NationaliteitId, out Id))
                            result = client.GetNationaliteitById(Id, false, settings);
                    }
                    catch (Exception ex)
                    {
                        throw new WebFaultException<string>(ex.Message, HttpStatusCode.InternalServerError);
                    }
                }
                else
                {
                    throw new WebFaultException(HttpStatusCode.Forbidden);
                }
            }
            else
            {
                throw new WebFaultException(HttpStatusCode.Unauthorized);
            }

            return result;
        }

        public ClubCloud_Gebruiker GetGebruikerByNummer(string nummer)
        {
            ClubCloud_Gebruiker gebruiker = new ClubCloud_Gebruiker();

            int parsed;
            if (HttpContext.Current != null && HttpContext.Current.User != null && HttpContext.Current.User.Identity != null && HttpContext.Current.User.Identity.IsAuthenticated)
            {
                string bondsnummer = HttpContext.Current.User.Identity.Name.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    try
                    {
                        ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                        ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                        if (settings != null)
                            gebruiker = client.GetGebruikerByNummer(bondsnummer, settings.VerenigingId.Value, nummer);
                    }
                    catch (Exception ex)
                    {
                        throw new WebFaultException<string>(ex.Message, HttpStatusCode.InternalServerError);
                    }
                }
                else
                {
                    throw new WebFaultException(HttpStatusCode.Forbidden);
                }
            }
            else
            {
                throw new WebFaultException(HttpStatusCode.Unauthorized);
            }

            return gebruiker;
        }

        public ClubCloud_Gebruiker GetGebruikerById(string GebruikerId)
        {
            ClubCloud_Gebruiker result = new ClubCloud_Gebruiker();

            int parsed;
            Guid Id;
            if (HttpContext.Current != null && HttpContext.Current.User != null && HttpContext.Current.User.Identity != null && HttpContext.Current.User.Identity.IsAuthenticated)
            {
                string bondsnummer = HttpContext.Current.User.Identity.Name.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    try
                    {
                        ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                        ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                        if (settings != null && Guid.TryParse(GebruikerId, out Id))
                            result = client.GetGebruikerById(Id, false, settings);
                    }
                    catch (Exception ex)
                    {
                        throw new WebFaultException<string>(ex.Message, HttpStatusCode.InternalServerError);
                    }
                }
                else
                {
                    throw new WebFaultException(HttpStatusCode.Forbidden);
                }
            }
            else
            {
                throw new WebFaultException(HttpStatusCode.Unauthorized);
            }

            return result;
        }

        public ClubCloud_Vereniging GetVerenigingByLocation(string Latitude, string Longitude)
        {
            ClubCloud_Vereniging vereniging = new ClubCloud_Vereniging();

            int parsed;
            if (HttpContext.Current != null && HttpContext.Current.User != null && HttpContext.Current.User.Identity != null && HttpContext.Current.User.Identity.IsAuthenticated)
            {
                string bondsnummer = HttpContext.Current.User.Identity.Name.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    try
                    {
                        ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                        ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                        if (settings != null)
                            vereniging = client.GetVerenigingByLocation(bondsnummer, double.Parse(Latitude), double.Parse(Longitude), false);
                    }
                    catch (Exception ex)
                    {
                        throw new WebFaultException<string>(ex.Message, HttpStatusCode.InternalServerError);
                    }
                }
                else
                {
                    throw new WebFaultException(HttpStatusCode.Forbidden);
                }
            }
            else
            {
                throw new WebFaultException(HttpStatusCode.Unauthorized);
            }

            return vereniging;
        }

        public ClubCloud_Vereniging GetVerenigingByNummer(string verenigingNummer)
        {
            ClubCloud_Vereniging vereniging = new ClubCloud_Vereniging();

            int parsed;
            if (HttpContext.Current != null && HttpContext.Current.User != null && HttpContext.Current.User.Identity != null && HttpContext.Current.User.Identity.IsAuthenticated)
            {
                string bondsnummer = HttpContext.Current.User.Identity.Name.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    try
                    {
                        ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                        ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                        if (settings != null)
                            vereniging = client.GetVerenigingByNummer(bondsnummer, verenigingNummer, false);
                    }
                    catch (Exception ex)
                    {
                        throw new WebFaultException<string>(ex.Message, HttpStatusCode.InternalServerError);
                    }
                }
                else
                {
                    throw new WebFaultException(HttpStatusCode.Forbidden);
                }
            }
            else
            {
                throw new WebFaultException(HttpStatusCode.Unauthorized);
            }

            return vereniging;
        }

        public List<ClubCloud_Vereniging> GetVerenigingenBySearch(string prefixText, string count, string contextKey)
        {
            List<ClubCloud_Vereniging> result = new List<ClubCloud_Vereniging>();
            try
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);

                result = client.GetVerenigingenBySearch(prefixText, int.Parse(count), contextKey);
            }
            catch { };

            return result;
        }

        public List<ClubCloud_Gebruiker> GetGebruikersBySearch(string prefixText, string count, string contextKey)
        {
            List<ClubCloud_Gebruiker> result = new List<ClubCloud_Gebruiker>();

            int parsed;
            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                string bondsnummer = HttpContext.Current.User.Identity.Name.Split('|').Last();
                if (int.TryParse(bondsnummer, out parsed))
                {
                    try
                    {
                        ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                        ClubCloud_Setting settings = client.GetClubCloudSettings(bondsnummer);
                        if (settings != null)
                            result = client.GetGebruikersBySearch(prefixText, int.Parse(count), contextKey, settings);
                    }
                    catch { }
                }

            }

            return result;
        }        
        #endregion

        #region ClubCloud Verenigingen

        public List<ClubCloud_Vereniging> GetVerenigingen(string query)
        {
            List<ClubCloud_Vereniging> result = new List<ClubCloud_Vereniging>();
            try
            {
                //if(Authorized)
                    result = Client.GetVerenigingenBySearch(query, 5, query);
            }
            catch (Exception ex)
            {
                throw new WebFaultException<string>(ex.Message, HttpStatusCode.InternalServerError);
            }

            return result;
        }

        public ClubCloud_Vereniging GetVerenigingById(string VerenigingId)
        {
            ClubCloud_Vereniging result = new ClubCloud_Vereniging();
            try
            {
                Guid parsed;
                if (Guid.TryParse(VerenigingId, out parsed))
                {
                    result = Client.GetVerenigingById(parsed, false, new ClubCloud_Setting { Id = 00000000, VerenigingId = parsed, Access = false });
                }
            }
            catch (Exception ex)
            {
                throw new WebFaultException<string>(ex.Message, HttpStatusCode.InternalServerError);
            }

            return result;
        }

        public List<ClubCloud_Address> GetVerenigingAdressen(string VerenigingId)
        {
            List<ClubCloud_Address> result = new List<ClubCloud_Address>();
            try
            {
                Guid parsed;
                if (Guid.TryParse(VerenigingId, out parsed))
                {
                    result = Client.GetAddressenForVerenigingById(parsed, false, new ClubCloud_Setting { Id = 00000000, VerenigingId = Guid.Empty, Access = false });
                }
            }
            catch (Exception ex)
            {
                throw new WebFaultException<string>(ex.Message, HttpStatusCode.InternalServerError);
            }

            return result;
        }

        public ClubCloud_Accommodatie GetVerenigingAccommodatie(string VerenigingId)
        {
            ClubCloud_Accommodatie result = new ClubCloud_Accommodatie();
            try
            {
                Guid parsed;
                if (Guid.TryParse(VerenigingId, out parsed))
                {
                    result = Client.GetAccommodatieForVerenigingById(parsed, false, new ClubCloud_Setting { Id = 00000000, VerenigingId = parsed, Access = false });
                }
            }
            catch (Exception ex)
            {
                throw new WebFaultException<string>(ex.Message, HttpStatusCode.InternalServerError);
            }

            return result;
        }

        public List<ClubCloud_Address> GetVerenigingAccommodatieAdressen(string VerenigingId)
        {
            List<ClubCloud_Address> result = new List<ClubCloud_Address>();
            try
            {
                Guid parsed;
                if (Guid.TryParse(VerenigingId, out parsed))
                {
                    ClubCloud_Accommodatie accommodatie = Client.GetAccommodatieForVerenigingById(parsed, false, new ClubCloud_Setting { Id = 00000000, VerenigingId = parsed, Access = false });

                    if (accommodatie != null)
                        result = Client.GetAddressenForAccommodatieById(accommodatie.Id, false, new ClubCloud_Setting { Id = 00000000, VerenigingId = parsed, Access = false });                      
                }
            }
            catch (Exception ex)
            {
                throw new WebFaultException<string>(ex.Message, HttpStatusCode.InternalServerError);
            }

            return result;
        }

        public List<ClubCloud_Functionaris> GetVerenigingFunctionarissen(string VerenigingId)
        {
            List<ClubCloud_Functionaris> result = new List<ClubCloud_Functionaris>();
            try
            {
                Guid parsed;
                if (Guid.TryParse(VerenigingId, out parsed))
                {
                    result = Client.GetFunctionarissenForVerenigingById(parsed, false, new ClubCloud_Setting { Id = 00000000, VerenigingId = parsed, Access = false });
                }
            }
            catch (Exception ex)
            {
                throw new WebFaultException<string>(ex.Message, HttpStatusCode.InternalServerError);
            }

            return result;

        }

        public ClubCloud_Functionaris GetVerenigingFunctionaris(string VerenigingId, string FunctionarisId)
        {
            ClubCloud_Functionaris result = new ClubCloud_Functionaris();
            try
            {
                Guid parsed;
                if (Guid.TryParse(FunctionarisId, out parsed))
                {
                    Guid fparsed;
                    if (Guid.TryParse(FunctionarisId, out fparsed))
                    {
                        result = Client.GetFunctionarisById(fparsed, false, new ClubCloud_Setting { Id = 00000000, VerenigingId = parsed, Access = false });
                    }
                }
            }
            catch (Exception ex)
            {
                throw new WebFaultException<string>(ex.Message, HttpStatusCode.InternalServerError);
            }

            return result;
        }

        public ClubCloud_Vereniging GetVerenigingNearby(string Latitude, string Longitude)
        {
            ClubCloud_Vereniging vereniging = new ClubCloud_Vereniging();

            try
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);

                vereniging = client.GetVerenigingByLocation("00000000", double.Parse(Latitude), double.Parse(Longitude));
            }
            catch (Exception ex)
            {
                throw new WebFaultException<string>(ex.Message, HttpStatusCode.InternalServerError);
            }

            return vereniging;
        }

        #endregion

    }
}