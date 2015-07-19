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
    using Microsoft.SharePoint.IdentityModel;
    using System.Web;
    using Microsoft.IdentityModel.Claims;
    using System.Web.Configuration;
    using Microsoft.IdentityModel.Web;

    /// <summary>
    /// The REST Service.
    /// </summary>
    [BasicHttpBindingServiceMetadataExchangeEndpoint]
    [ServiceFactoryUsingAuthSchemeInEndpointAddress(UsingAuthSchemeInEndpointAddress = false)]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    [System.Runtime.InteropServices.Guid("76bd8f39-c25c-4dff-95c0-2d84a0a2a445")]
    [ServiceBehavior(Namespace = "http://clubcloud.nl/", Name = "ClubCloudWebSiteService", IncludeExceptionDetailInFaults = true)]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1812:AvoidUninstantiatedInternalClasses", Justification = "Instantiated by the WCF runtime automatically.")]
    public class ClubCloudAfhangenWebSiteService : IClubCloudAfhangenWebSiteService
    {
        private static ClubCloudServiceClient client;

        public static ClubCloudServiceClient Client
        {
            get
            {
                if (client == null)
                    client = new ClubCloudServiceClient(SPServiceContext.Current);

                //client.Proxy.Status == SPObjectStatus.Offline

                return ClubCloudAfhangenWebSiteService.client;
            }
            private set { client = value; }
        }

        private static SPFederationAuthenticationModule _FederationAuthenticationModule = null;

        internal static SPFederationAuthenticationModule FederationAuthenticationModule
        {
            get
            {
                if (ClubCloudAfhangenWebSiteService._FederationAuthenticationModule == null)
                    ClubCloudAfhangenWebSiteService._FederationAuthenticationModule = FederatedAuthentication.WSFederationAuthenticationModule as SPFederationAuthenticationModule;

                return ClubCloudAfhangenWebSiteService._FederationAuthenticationModule;
            }
            private set { _FederationAuthenticationModule = value; }
        }

        private static SPSessionAuthenticationModule _SessionAuthenticationModule = null;

        internal static SPSessionAuthenticationModule SessionAuthenticationModule
        {
            get
            {
                if (ClubCloudAfhangenWebSiteService._SessionAuthenticationModule == null)
                    ClubCloudAfhangenWebSiteService._SessionAuthenticationModule = FederatedAuthentication.SessionAuthenticationModule as SPSessionAuthenticationModule;

                return ClubCloudAfhangenWebSiteService._SessionAuthenticationModule;
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

                    if (principal != null)
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
    }
}
