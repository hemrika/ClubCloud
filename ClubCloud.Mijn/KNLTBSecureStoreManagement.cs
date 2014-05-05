using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security;
using Microsoft.BusinessData.Infrastructure.SecureStore;
using Microsoft.Office.SecureStoreService.Server;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;
using Microsoft.SharePoint.Administration.Claims;


namespace ClubCloud.Mijn
{
    internal static class KNLTBSecureStoreManagement
    {
        #region Internals

        internal static SecureString MakeSecureString(string str)
        {
            if (str == null)
            {
                return null;
            }
            var str2 = new SecureString();
            char[] chArray = str.ToCharArray();
            for (int i = 0; i < chArray.Length; i++)
            {
                str2.AppendChar(chArray[i]);
                chArray[i] = '0';
            }
            return str2;
        }

        internal static string ReadSecureString(SecureString sstrIn)
        {
            if (sstrIn == null)
            {
                return null;
            }
            IntPtr ptr = Marshal.SecureStringToBSTR(sstrIn);
            string str = Marshal.PtrToStringBSTR(ptr);
            Marshal.ZeroFreeBSTR(ptr);
            return str;
        }

        internal static ISecureStore GetSecureStore()
        {
            var context = SPServiceContext.GetContext(SPServiceApplicationProxyGroup.Default, SPSiteSubscriptionIdentifier.Default);
            var ssp = new SecureStoreServiceProxy();
            return ssp.GetSecureStore(context);
        }

        internal static SecureStoreServiceClaim GetSecureStoreClaim(string userName)
        {
            SPClaim claim = SPClaimProviderManager.CreateUserClaim(userName, SPOriginalIssuerType.ClaimProvider);
            return new SecureStoreServiceClaim(claim);
        }

        #endregion

        #region TargetApplication

        public static TargetApplication GetTargetApplication(string applicationId)
        {
            return GetSecureStore().GetApplication(applicationId);
        }

        public static void CreateTargetApplicationId(string name, string friendlyName, string contactEmail, int ticketTimeOut, TargetApplicationType type)
        {
            if (GetTargetApplication(name) != null)
            {
                var iSecureStore = GetSecureStore();
                IList<SecureStoreServiceClaim> ssClaims = new List<SecureStoreServiceClaim>() { GetSecureStoreClaim(SPContext.Current.Web.CurrentUser.UserId.NameId) };
                var targetApplicationClaims = new TargetApplicationClaims(ssClaims, null, null);
                iSecureStore.CreateApplication(new TargetApplication(name, friendlyName, contactEmail, ticketTimeOut, type, null), GetTargetApplicationFields(), targetApplicationClaims);
            }
        }

        private static IList<TargetApplicationField> GetTargetApplicationFields()
        {
            IList<TargetApplicationField> appFields = new List<TargetApplicationField>()
                                                          {
                                                              CreateTargetApplicationField(SecureStoreCredentialType.UserName,"KNLTBUsername",false ),
                                                              CreateTargetApplicationField(SecureStoreCredentialType.Password,"KNLTBPassword",true ),
                                                          };
            return appFields;
        }

        private static TargetApplicationField CreateTargetApplicationField(SecureStoreCredentialType type, string name, bool masked)
        {
            return new TargetApplicationField(name, masked, type);
        }

        #endregion

        #region Credentials

        public static void SetCredentials(string userName, string userPassword, string targetApplicationId)
        {
            IList<ISecureStoreCredential> creds = new List<ISecureStoreCredential>();
            creds.Add(new SecureStoreCredential(MakeSecureString(userName), SecureStoreCredentialType.UserName));
            creds.Add(new SecureStoreCredential(MakeSecureString(userPassword), SecureStoreCredentialType.Password));

            using (var credentials = new SecureStoreCredentialCollection(creds))
            {
                var iSecureStore = GetSecureStore();
                iSecureStore.SetUserCredentials(targetApplicationId, GetSecureStoreClaim(SPContext.Current.Web.CurrentUser.UserId.NameId), credentials);
                //if the target application  is using group type credentials then call this.//iss.SetGroupCredentials(targetApplicationID, credentials);
            }
        }

        public static SecureStoreCredentialCollection GetCredentials(string targetApplicationId)
        {
            SecureStoreCredentialCollection credentials = null;
            var iSecureStore = GetSecureStore();
            credentials = iSecureStore.GetCredentials(targetApplicationId);
            return credentials;
        }

        public static List<string> VerifyStoredCredentials(SecureStoreCredentialCollection credentials)
        {
            var vcreds = new List<string>();

            foreach (SecureStoreCredential ssc in credentials)
            {
                vcreds.Add(ReadSecureString(ssc.Credential));

            }

            return vcreds;
        }

        public static void DeleteSecureStoreCredentials(string targetApplicationId)
        {
            var iSecureStore = GetSecureStore();
            iSecureStore.DeleteCredentials(targetApplicationId);
        }

        #endregion
    }
}
