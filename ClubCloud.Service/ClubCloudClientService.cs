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

    /// <summary>
    /// The REST Service.
    /// </summary>
    [BasicHttpBindingServiceMetadataExchangeEndpoint]
    [ServiceFactoryUsingAuthSchemeInEndpointAddress(UsingAuthSchemeInEndpointAddress = false)]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    [System.Runtime.InteropServices.Guid("ca13956f-3676-4c74-abdc-e16f784d08ac")]
    [ServiceBehavior(Namespace = "http://clubcloud.nl/", Name = "ClubCloudService", IncludeExceptionDetailInFaults = true)]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1812:AvoidUninstantiatedInternalClasses", Justification = "Instantiated by the WCF runtime automatically.")]
    public class ClubCloudClientService : IClubCloudClientService
    {
        #region Public WebSite

        public string[] GetGebruikers(string prefixText, int count, string contextKey)
        {
            List<string> customers = new List<string>();

            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                
                List<ClubCloud_Gebruiker> gebruikers = client.GetGebruikersBySearch(prefixText, count, contextKey, new ClubCloud_Setting { Id = int.Parse(SPContext.Current.Web.CurrentUser.UserId.NameId) });

                if (gebruikers != null && gebruikers.Count > 0)
                {
                    foreach (ClubCloud_Gebruiker gebruiker in gebruikers)
                    {
                        customers.Add((new JavaScriptSerializer()).Serialize(new Pair(string.Format("{0} - {1}", gebruiker.Bondsnummer, gebruiker.Volledigenaam), gebruiker.Bondsnummer)));
                    }

                    return customers.ToArray();

                }
                else
                {
                    return default(string[]);
                }
                
                return customers.ToArray(); ;
            }
            else
            {
                return default(string[]);
            }
        }


        public string[] GetVerenigingen(string prefixText, int count, string contextKey)
        {
            List<string> results = new List<string>();
            try
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);

                List<ClubCloud_Vereniging> verenigingen = client.GetVerenigingenBySearch(prefixText, count, contextKey);

                if (verenigingen != null && verenigingen.Count > 0)
                {
                    foreach (ClubCloud_Vereniging vereniging in verenigingen)
                    {
                        results.Add((new JavaScriptSerializer()).Serialize(new Pair(string.Format("{0} - {1}", vereniging.Nummer, vereniging.Naam), vereniging.Nummer)));
                    }

                    return results.ToArray();
                }

                return results.ToArray(); ;
            }
            catch { };

            return default(string[]);
        }

        #endregion
    }
}
