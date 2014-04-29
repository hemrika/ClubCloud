using Microsoft.IdentityModel.Web;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;
using Microsoft.SharePoint.Administration.Claims;
using Microsoft.SharePoint.IdentityModel;
using Microsoft.SharePoint.IdentityModel.Pages;
using Microsoft.SharePoint.Utilities;
using Microsoft.SharePoint.WebControls;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI.WebControls;

namespace ClubCloud.Provider.IdentityModel
{
    public class AuthenticatePage : IdentityModelSignInPageBase
    {
        /*
        protected Login signInControl;

        protected EncodedLiteral ClaimsFormsPageTitle;

        protected EncodedLiteral ClaimsFormsPageTitleInTitleArea;

        protected EncodedLiteral ClaimsFormsPageMessage;
        */
        public AuthenticatePage()
        {
        }

        protected override string LogPrefix
        {
            get
            {
                return "Zimbra Forms Sign-In: ";
            }
        }

        protected override void OnInit(EventArgs eventArgs)
        {
            try
            {
                this.SetThreadCultureFromRequestedWeb();
            }
            catch { }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            /*
            this.ClaimsFormsPageTitle.Text = SPHttpUtility.NoEncode((string)HttpContext.GetGlobalResourceObject("wss", "login_pagetitle", Thread.CurrentThread.CurrentUICulture));
            if (this.ClaimsFormsPageTitleInTitleArea != null)
            {
                this.ClaimsFormsPageTitleInTitleArea.Text = SPHttpUtility.NoEncode((string)HttpContext.GetGlobalResourceObject("wss", "login_pagetitle", Thread.CurrentThread.CurrentUICulture));
            }
            this.ClaimsFormsPageMessage.Text = SPHttpUtility.NoEncode((string)HttpContext.GetGlobalResourceObject("wss", "SSL_warning", Thread.CurrentThread.CurrentUICulture));
            this.signInControl.Focus();
            */

            //this.signInControl.LoggingIn += new LoginCancelEventHandler(this.LoggingInEventHandler);
            //this.signInControl.Authenticate += new AuthenticateEventHandler(this.AuthenticateEventHandler);
            /*
            CheckBox checkBox = null;

            if (SPSecurityTokenServiceManager.Local.UseSessionCookies)
            {
                CheckBox checkBox1 = this.signInControl.FindControl("RememberMe") as CheckBox;
                checkBox = checkBox1;
                if (checkBox1 != null)
                {
                    checkBox.Enabled = false;
                    checkBox.Visible = false;
                }
            }
            */
            SecurityToken securityToken = null;
            SPIisSettings iisSettings = this.IisSettings;
            SPFormsAuthenticationProvider formsClaimsAuthenticationProvider = iisSettings.FormsClaimsAuthenticationProvider;
            SPSessionTokenWriteType sPSessionTokenWriteType = SPSessionTokenWriteType.WriteDefaultCookie;

            if (!SPSecurityTokenServiceManager.Local.UseSessionCookies )
            {
                sPSessionTokenWriteType = SPSessionTokenWriteType.WriteSessionCookie;
            }

            if (!string.IsNullOrEmpty(HttpContext.Current.Request.QueryString["loginasuser"])) 
            {
                string username = HttpContext.Current.Request.QueryString["loginasuser"];

                securityToken = SPSecurityContext.SecurityTokenForFormsAuthentication(this.AppliesTo, formsClaimsAuthenticationProvider.MembershipProvider, formsClaimsAuthenticationProvider.RoleProvider, username, String.Empty, SPFormsAuthenticationOption.PersistentSignInRequest);
                SPFederationAuthenticationModule wSFederationAuthenticationModule = FederatedAuthentication.WSFederationAuthenticationModule as SPFederationAuthenticationModule;
                //wSFederationAuthenticationModule.SetPrincipalAndWriteSessionToken(st,SPSessionTokenWriteType.WritePersistentCookie)
                this.EstablishSessionWithToken(securityToken, sPSessionTokenWriteType);
            }
        }
    }
}
