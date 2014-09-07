using System;
using System.Text;
using System.Web;
using System.IdentityModel.Claims;
using System.IdentityModel;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration.Claims;
using System.IdentityModel.Services;
using System.Security.Principal;
using System.Security.Claims;
using System.Web.Security;

namespace ClubCloud.Provider
{
    public class ZimbraModule : IHttpModule
    {
        private const string SignOutCookieName = "ZimbraSignOut";

        public void Init(HttpApplication context)
        {
            context.AuthenticateRequest += context_AuthenticateRequest;
            context.AuthorizeRequest += context_AuthorizeRequest;
            context.PostAuthenticateRequest += context_PostAuthenticateRequest;
            context.PostAuthorizeRequest += context_PostAuthorizeRequest;

            FederatedAuthentication.SessionAuthenticationModule.SessionSecurityTokenCreated += SessionAuthenticationModule_SessionSecurityTokenCreated;
            FederatedAuthentication.SessionAuthenticationModule.SessionSecurityTokenReceived += SessionAuthenticationModule_SessionSecurityTokenReceived;
            FederatedAuthentication.SessionAuthenticationModule.SignedOut += SessionAuthenticationModule_SignedOut;
            FederatedAuthentication.SessionAuthenticationModule.SigningOut += SessionAuthenticationModule_SigningOut;
            FederatedAuthentication.SessionAuthenticationModule.SignOutError += SessionAuthenticationModule_SignOutError;

            FederatedAuthentication.WSFederationAuthenticationModule.AuthorizationFailed += WSFederationAuthenticationModule_AuthorizationFailed;
            FederatedAuthentication.WSFederationAuthenticationModule.SecurityTokenReceived += WSFederationAuthenticationModule_SecurityTokenReceived;
            FederatedAuthentication.WSFederationAuthenticationModule.SecurityTokenValidated += WSFederationAuthenticationModule_SecurityTokenValidated;
            FederatedAuthentication.WSFederationAuthenticationModule.SessionSecurityTokenCreated += WSFederationAuthenticationModule_SessionSecurityTokenCreated;
            FederatedAuthentication.WSFederationAuthenticationModule.SignedIn += WSFederationAuthenticationModule_SignedIn;
            FederatedAuthentication.WSFederationAuthenticationModule.SignedOut += WSFederationAuthenticationModule_SignedOut;
            FederatedAuthentication.WSFederationAuthenticationModule.SigningOut += WSFederationAuthenticationModule_SigningOut;

            // Single Sign-Out
            //FederatedAuthentication.WSFederationAuthenticationModule.SignedIn += WSFederationAuthenticationModule_SignedIn;
            //FederatedAuthentication.SessionAuthenticationModule.SigningOut += SessionAuthenticationModule_SigningOut;
            //FederatedAuthentication.SessionAuthenticationModule.SessionSecurityTokenReceived += SessionAuthenticationModule_SessionSecurityTokenReceived;
        }

        void WSFederationAuthenticationModule_SigningOut(object sender, SigningOutEventArgs e)
        {
            //throw new NotImplementedException();
        }

        void WSFederationAuthenticationModule_SignedOut(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        void WSFederationAuthenticationModule_SignedIn(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        void WSFederationAuthenticationModule_SessionSecurityTokenCreated(object sender, SessionSecurityTokenCreatedEventArgs e)
        {
            //throw new NotImplementedException();
        }

        void WSFederationAuthenticationModule_SecurityTokenValidated(object sender, SecurityTokenValidatedEventArgs e)
        {
            //throw new NotImplementedException();
        }

        void WSFederationAuthenticationModule_SecurityTokenReceived(object sender, SecurityTokenReceivedEventArgs e)
        {
            //throw new NotImplementedException();
        }

        void WSFederationAuthenticationModule_AuthorizationFailed(object sender, AuthorizationFailedEventArgs e)
        {
            //throw new NotImplementedException();
        }

        void SessionAuthenticationModule_SignOutError(object sender, ErrorEventArgs e)
        {
            //throw new NotImplementedException();
        }

        void SessionAuthenticationModule_SigningOut(object sender, SigningOutEventArgs e)
        {
            //throw new NotImplementedException();
        }

        void SessionAuthenticationModule_SignedOut(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        void SessionAuthenticationModule_SessionSecurityTokenReceived(object sender, SessionSecurityTokenReceivedEventArgs e)
        {
            //throw new NotImplementedException();
        }

        void SessionAuthenticationModule_SessionSecurityTokenCreated(object sender, SessionSecurityTokenCreatedEventArgs e)
        {
            //throw new NotImplementedException();
        }

        void context_PostAuthorizeRequest(object sender, EventArgs e)
        {
            //FormsAuthentication..SetAuthCookie(username, true);
            //throw new NotImplementedException();
        }

        void context_PostAuthenticateRequest(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        void context_AuthorizeRequest(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        void context_AuthenticateRequest(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        public void Dispose()
        {
        }

        /*
        private void WSFederationAuthenticationModule_SignedIn(object sender, EventArgs e)
        {
            ClaimsIdentity identity = HttpContext.Current.User.Identity as ClaimsIdentity;

            if (identity != null)
            {
                foreach (System.Security.Claims.Claim claim in identity.Claims)
                {
                    if (claim.Type == SPClaimTypes.IdentityProvider)
                    {
                        int index = claim.Value.IndexOf(':');
                        string loginProviderName = claim.Value.Substring(index + 1, claim.Value.Length - index - 1);
                        HttpCookie signOutCookie = new HttpCookie(SignOutCookieName, Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(loginProviderName)));
                        signOutCookie.Secure = FederatedAuthentication.SessionAuthenticationModule.CookieHandler.RequireSsl;
                        signOutCookie.HttpOnly = FederatedAuthentication.SessionAuthenticationModule.CookieHandler.HideFromClientScript;
                        signOutCookie.Domain = FederatedAuthentication.SessionAuthenticationModule.CookieHandler.Domain;
                        HttpContext.Current.Response.Cookies.Add(signOutCookie);
                        break;
                    }
                }
            }
        }

        private void SessionAuthenticationModule_SigningOut(object sender, EventArgs e)
        {
            DoFederatedSignOut();
        }

        private void DoFederatedSignOut()
        {
            string providerName = GetProviderNameFromCookie();
            SPTrustedLoginProvider loginProvider = null;
            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                loginProvider = GetLoginProvider(providerName);
            });

            if (loginProvider != null)
            {
                string returnUrl = string.Format(
                                   System.Globalization.CultureInfo.InvariantCulture,
                                   "{0}://{1}/_layouts/SignOut.aspx",
                                   HttpContext.Current.Request.Url.Scheme,
                                   HttpContext.Current.Request.Url.Host);
                HttpCookie signOutExpiredCookie = new HttpCookie(SignOutCookieName, string.Empty);
                signOutExpiredCookie.Expires = new DateTime(1970, 1, 1);
                HttpContext.Current.Response.Cookies.Remove(SignOutCookieName);
                HttpContext.Current.Response.Cookies.Add(signOutExpiredCookie);
                WSFederationAuthenticationModule.FederatedSignOut(loginProvider.ProviderUri, new Uri(returnUrl));
            }
        }

        private static string GetProviderNameFromCookie()
        {
            var signOutCookie = HttpContext.Current.Request.Cookies[SignOutCookieName];

            if (signOutCookie != null)
            {
                return Encoding.UTF8.GetString(Convert.FromBase64String(signOutCookie.Value));
            }

            return string.Empty;
        }

        private SPTrustedLoginProvider GetLoginProvider(string providerName)
        {
            if (!string.IsNullOrEmpty(providerName))
            {
                try
                {
                    var stsManager = SPSecurityTokenServiceManager.Local;
                    var loginProviders = stsManager.TrustedLoginProviders;
                    return loginProviders.GetProviderByName(providerName);
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Trace.WriteLine(ex.ToString());
                }
            }

            return null;
        }

        private void SessionAuthenticationModule_SessionSecurityTokenReceived(object sender, SessionSecurityTokenReceivedEventArgs e)
        {
            double sessionLifetimeInMinutes =
                (e.SessionToken.ValidTo - e.SessionToken.ValidFrom).TotalMinutes;
            var logonTokenCacheExpirationWindow = TimeSpan.FromSeconds(1);
            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                logonTokenCacheExpirationWindow =
                    Microsoft.SharePoint.Administration.Claims.SPSecurityTokenServiceManager.Local.LogonTokenCacheExpirationWindow;
            });

            DateTime now = DateTime.UtcNow;
            DateTime validTo = e.SessionToken.ValidTo - logonTokenCacheExpirationWindow;
            DateTime validFrom = e.SessionToken.ValidFrom;

            if ((now < validTo) && (now > validFrom.AddMinutes((validTo - validFrom).TotalMinutes / 2)))
            {
                SessionAuthenticationModule sam = FederatedAuthentication.SessionAuthenticationModule;
                e.SessionToken = sam.CreateSessionSecurityToken(e.SessionToken.ClaimsPrincipal, e.SessionToken.Context,
                    now, now.AddMinutes(sessionLifetimeInMinutes), e.SessionToken.IsPersistent);

                e.ReissueCookie = true;
            }
        }
        */
    }
}
