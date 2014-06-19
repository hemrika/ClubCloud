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
using System.Globalization;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Security;
using System.Web.UI.WebControls;
using System.Xml;

namespace ClubCloud.Provider.IdentityModel
{
    public class ZimbraSignInPage : IdentityModelSignInPageBase
    {
        protected Login signInControl;

        protected EncodedLiteral ClaimsFormsPageTitle;

        protected EncodedLiteral ClaimsFormsPageTitleInTitleArea;

        protected EncodedLiteral ClaimsFormsPageMessage;

        protected override string LogPrefix
        {
            get
            {
                return "Zimbra Forms Sign-In: ";
            }
        }

        public ZimbraSignInPage()
        { }

        protected override void OnInit(EventArgs eventArgs)
        {
            try
            {
                this.SetThreadCultureFromRequestedWeb();

                //ZimbraMembershipProvider z_membershipProvider = (ZimbraMembershipProvider)Membership.Providers["ZimbraMembershipProvider"];
                //ZimbraRoleProvider z_roleProvider = (ZimbraRoleProvider)Roles.Providers["ZimbraRoleProvider"];

            }
            catch { }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.ClaimsFormsPageTitle.Text = SPHttpUtility.NoEncode((string)HttpContext.GetGlobalResourceObject("wss", "login_pagetitle", Thread.CurrentThread.CurrentUICulture));
            if (this.ClaimsFormsPageTitleInTitleArea != null)
            {
                this.ClaimsFormsPageTitleInTitleArea.Text = SPHttpUtility.NoEncode((string)HttpContext.GetGlobalResourceObject("wss", "login_pagetitle", Thread.CurrentThread.CurrentUICulture));
            }
            this.ClaimsFormsPageMessage.Text = SPHttpUtility.NoEncode((string)HttpContext.GetGlobalResourceObject("wss", "SSL_warning", Thread.CurrentThread.CurrentUICulture));

            this.signInControl.Focus();

            this.signInControl.LoggingIn += new LoginCancelEventHandler(this.LoggingInEventHandler);
            this.signInControl.Authenticate += new AuthenticateEventHandler(this.AuthenticateEventHandler);

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
        }

        protected void AuthenticateEventHandler(object sender, AuthenticateEventArgs formAuthenticateEventArgs)
        {
            if (sender == null)
            {
                throw new ArgumentNullException("sender");
            }
            if (formAuthenticateEventArgs == null)
            {
                throw new ArgumentNullException("formAuthenticateEventArgs");
            }
            bool flag = false;
            Login login = sender as Login;
            SecurityToken securityToken = null;
            if (login == null)
            {
                throw new ArgumentException(null, "sender");
            }

            using (SPMonitoredScope sPMonitoredScope = new SPMonitoredScope("ZimbraSignInPage.AuthenticateEventHandler: Retrieve security token and establish session."))
            {
                securityToken = this.GetSecurityToken(login);
                if (securityToken != null)
                {
                    try
                    {
                        this.EstablishSessionWithToken(securityToken, this.GetSessionTokenWriteType(login));
                        this.ExecuteRegisteredAsyncTasks();

                        flag = true;
                    }
                    catch
                    {
                        flag = false;
                    }

                    try
                    {
                        SPFederationAuthenticationModule federationAuthenticationModule = FederatedAuthentication.WSFederationAuthenticationModule as SPFederationAuthenticationModule;
                        federationAuthenticationModule.SetPrincipalAndWriteSessionToken(securityToken, this.GetSessionTokenWriteType(login));
                    }
                    catch (Exception ex)
                    {
                        string message = ex.Message;
                    }
                }
                else
                {
                    flag = false;
                }
            }
            formAuthenticateEventArgs.Authenticated = flag;

            if (flag)
            {
                Guid id = SPContext.Current.Site.ID;
                SPSecurity.RunWithElevatedPrivileges(delegate()
                {
                    using (SPWeb elevatedWeb = new SPSite(id).OpenWeb())
                    {
                        elevatedWeb.AllowUnsafeUpdates = true;

                        
                        GenericXmlSecurityToken xmlToken = securityToken as GenericXmlSecurityToken;
                        XmlDocument xmlDoc = new XmlDocument();
                        xmlDoc.LoadXml(xmlToken.TokenXml.OuterXml);
                        XmlNamespaceManager nsmgr = new XmlNamespaceManager(xmlDoc.NameTable);
                        nsmgr.AddNamespace("saml", "urn:oasis:names:tc:SAML:1.0:assertion");
                        //string userid = xmlDoc.SelectSingleNode("//saml:Assertion/saml:AttributeStatement/saml:Attribute[@AttributeName='userid']/saml:AttributeValue", nsmgr).InnerText;
                        //string userlogonname = xmlDoc.SelectSingleNode("//saml:Assertion/saml:AttributeStatement/saml:Attribute[@AttributeName='userlogonname']/saml:AttributeValue", nsmgr).InnerText;
                        //string emailaddress = xmlDoc.SelectSingleNode("//saml:Assertion/saml:AttributeStatement/saml:Attribute[@AttributeName='emailaddress']/saml:AttributeValue", nsmgr).InnerText;
                        string name = xmlDoc.SelectNodes("//saml:Assertion/saml:AttributeStatement/saml:Attribute[@AttributeName='name']/saml:AttributeValue", nsmgr)[1].InnerText;
                        SPUser spUser = elevatedWeb.EnsureUser(name);
                        elevatedWeb.Update();
                        elevatedWeb.AllowUnsafeUpdates = false;
                    }

                    this.RedirectToSuccessUrl();
                });
            }
        }

        protected virtual SPSessionTokenWriteType GetSessionTokenWriteType(Login formsSignInControl)
        {
            if (formsSignInControl == null)
            {
                throw new ArgumentNullException("formsSignInControl");
            }
            SPSessionTokenWriteType sPSessionTokenWriteType = SPSessionTokenWriteType.WriteDefaultCookie;
            if (!SPSecurityTokenServiceManager.Local.UseSessionCookies && !formsSignInControl.RememberMeSet)
            {
                sPSessionTokenWriteType = SPSessionTokenWriteType.WriteSessionCookie;
            }
            return sPSessionTokenWriteType;
        }

        protected virtual SecurityToken GetSecurityToken(Login formsSignInControl)
        {
            if (formsSignInControl == null)
            {
                throw new ArgumentNullException("formsSignInControl");
            }
            SecurityToken securityToken = null;
            SPIisSettings iisSettings = this.IisSettings;
            if (!iisSettings.UseClaimsAuthentication || !iisSettings.UseFormsClaimsAuthenticationProvider)
            {
                /*
                ULSCat msoulscatWSSClaimsAuthentication = ULSCat.msoulscat_WSS_ClaimsAuthentication;
                string str = string.Concat(this.LogPrefix, "Loaded the FormsSignInPage from request '{0}' but we are not in a context where claims forms sign is is enabled.");
                object[] contextUri = new object[] { SPAlternateUrl.ContextUri };
                ULS.SendTraceTag(1430947, msoulscatWSSClaimsAuthentication, ULSTraceLevel.Unexpected, str, contextUri);
                */
                throw new InvalidOperationException();
            }
            if (this.IsLoginControlInValidState(formsSignInControl))
            {
                //string str1 = null;
                Uri appliesTo = this.AppliesTo;
                SPFormsAuthenticationProvider formsClaimsAuthenticationProvider = iisSettings.FormsClaimsAuthenticationProvider;
                CultureInfo invariantCulture = CultureInfo.InvariantCulture;
                object[] userName = new object[] { (formsSignInControl.RememberMeSet ? string.Empty : "non-"), formsSignInControl.UserName, formsClaimsAuthenticationProvider.MembershipProvider, formsClaimsAuthenticationProvider.RoleProvider, appliesTo, SPAlternateUrl.ContextUri };
                //str1 = string.Format(invariantCulture, "{0}persistant security token for user '{1}' with membership provider '{2}' and role provider '{3}' with applies to '{4}' for request '{5}'.", userName);
                //ULS.SendTraceTag(1430977, ULSCat.msoulscat_WSS_ClaimsAuthentication, ULSTraceLevel.Verbose, string.Concat(this.LogPrefix, "Requesting a ", str1));
                SPFormsAuthenticationOption sPFormsAuthenticationOption = SPFormsAuthenticationOption.None;
                if (formsSignInControl.RememberMeSet)
                {
                    sPFormsAuthenticationOption = SPFormsAuthenticationOption.PersistentSignInRequest;
                }
                try
                {
                    securityToken = SPSecurityContext.SecurityTokenForFormsAuthentication(appliesTo, formsClaimsAuthenticationProvider.MembershipProvider, formsClaimsAuthenticationProvider.RoleProvider, formsSignInControl.UserName, formsSignInControl.Password, sPFormsAuthenticationOption);
                    //ULS.SendTraceTag(1430978, ULSCat.msoulscat_WSS_ClaimsAuthentication, ULSTraceLevel.Verbose, string.Concat(this.LogPrefix, "Successfully got a ", str1));
                }
                catch //(Exception exception1)
                {
                    /*
                    Exception exception = exception1;
                    ULSCat uLSCat = ULSCat.msoulscat_WSS_ClaimsAuthentication;
                    string str2 = string.Concat(this.LogPrefix, "Failed to get a ", str1, " Exception: '{0}'");
                    object[] objArray = new object[] { exception };
                    ULS.SendTraceTag(1430979, uLSCat, ULSTraceLevel.Verbose, str2, objArray);
                    */
                    securityToken = null;
                }
            }
            else
            {
                /*
                ULSCat msoulscatWSSClaimsAuthentication1 = ULSCat.msoulscat_WSS_ClaimsAuthentication;
                string str3 = string.Concat(this.LogPrefix, "Cancelling sign-in for request '{0}'.");
                object[] contextUri1 = new object[] { SPAlternateUrl.ContextUri };
                ULS.SendTraceTag(1430976, msoulscatWSSClaimsAuthentication1, ULSTraceLevel.VerboseEx, str3, contextUri1);
                */
                securityToken = null;
            }
            return securityToken;
        }

        protected virtual bool IsLoginControlInValidState(Login formsSignInControl)
        {
            //string logPrefix;
            //string str;
            //ULSCat msoulscatWSSClaimsAuthentication;
            if (formsSignInControl == null)
            {
                throw new ArgumentNullException("formsSignInControl");
            }
            bool flag = false;
            bool flag1 = false;
            bool flag2 = string.IsNullOrEmpty(formsSignInControl.UserName);
            flag1 = flag2;
            if (!flag2)
            {
                bool flag3 = string.IsNullOrWhiteSpace(formsSignInControl.UserName.Trim());
                flag1 = flag3;
                if (flag3 || formsSignInControl.Password == null)
                {
                    /*
                    msoulscatWSSClaimsAuthentication = ULSCat.msoulscat_WSS_ClaimsAuthentication;
                    logPrefix = this.LogPrefix;
                    str = (flag1 ? "Username is null, empty or entirely whitespaces." : "Password is null.");
                    ULS.SendTraceTag(1430946, msoulscatWSSClaimsAuthentication, ULSTraceLevel.VerboseEx, string.Concat(logPrefix, str));
                    */
                    flag = false;
                    return flag;
                }
                flag = true;
                return flag;
            }
            /*
            msoulscatWSSClaimsAuthentication = ULSCat.msoulscat_WSS_ClaimsAuthentication;
            logPrefix = this.LogPrefix;
            str = (flag1 ? "Username is null, empty or entirely whitespaces." : "Password is null.");
            ULS.SendTraceTag(1430946, msoulscatWSSClaimsAuthentication, ULSTraceLevel.VerboseEx, string.Concat(logPrefix, str));
            */
            flag = false;
            return flag;
        }

        protected void LoggingInEventHandler(object sender, LoginCancelEventArgs e)
        {
            Login login = sender as Login;
            if (login == null)
            {
                throw new ArgumentException(null, "sender");
            }
            /*
            ULS.SendTraceTag(1714582895, ULSCat.msoulscat_WSS_ClaimsAuthentication, ULSTraceLevel.VerboseEx, string.Concat(this.LogPrefix, "Attempting to validate user input."));
            */
            login.UserName = login.UserName.Trim();
            if (login.UserName.Length > 249)
            {
                /*
                ULS.SendTraceTag(1714582896, ULSCat.msoulscat_WSS_ClaimsAuthentication, ULSTraceLevel.Unexpected, string.Concat(this.LogPrefix, "Failed to validate user input. Username is too long."));
                */
                e.Cancel = true;
                return;
            }
            if (!string.IsNullOrEmpty(login.UserName))
            {
                /*
                ULS.SendTraceTag(1430984, ULSCat.msoulscat_WSS_ClaimsAuthentication, ULSTraceLevel.VerboseEx, string.Concat(this.LogPrefix, "Succesfully validated user input."));
                */
                return;
            }
            /*
            ULS.SendTraceTag(1714582897, ULSCat.msoulscat_WSS_ClaimsAuthentication, ULSTraceLevel.VerboseEx, string.Concat(this.LogPrefix, "Failed to validate user input. Username is empty."));
            */
            e.Cancel = true;
        }

        protected override Uri AppliesTo
        {
            get
            {
                return base.AppliesTo;
            }
        }
    }
}
