//-----------------------------------------------------------------------
// <copyright file="HelloWorldWCFService.cs" company="">
// Copyright © 
// </copyright>
//-----------------------------------------------------------------------

namespace ClubCloud.Service
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.ServiceModel;
    using Microsoft.SharePoint.Administration;
    using Microsoft.SharePoint.Client.Services;
    using System.ServiceModel.Activation;
    using System.Data.Entity.Core.Objects;
    using ClubCloud.Service.Model;
    using System.Data.Entity;
    using ClubCloud.KNLTB.ServIt.LedenAdministratieService;
    using System.Net;

    /// <summary>
    /// The WCF Service.
    /// </summary>
    [BasicHttpBindingServiceMetadataExchangeEndpoint]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [System.Runtime.InteropServices.Guid("e00d1eca-a977-4ba9-a357-5fd35dfc0f63")]
    [ServiceBehavior(Namespace = "http://clubcloud.nl/", Name="ClubCloudService")]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1812:AvoidUninstantiatedInternalClasses", Justification = "Instantiated by the WCF runtime automatically.")]
    internal class ClubCloudApplicationService : IClubCloudApplicationService
    {
        private CookieContainer RequestContainer(string bondsnummer, string wachtwoord)
        {
            ClubCloud.KNLTB.Security.KNLTBContainer container = new KNLTB.Security.KNLTBContainer();
            container.MijnRequestAcces(bondsnummer, wachtwoord);
            while (container.Container == null) { }
            return container.Container;
        }

        #region Methods

        /*
        /// <summary>
        /// Returns a hello world string.
        /// </summary>
        /// <param name="helloWorld">An input string of text.</param>
        /// <returns>A string of text echoing the input value.</returns>
        public string HelloWorld(string helloWorld)
        {
            return "Hello World - You entered: " + helloWorld;
        }

        /// <summary>
        /// Returns a hello world string.
        /// </summary>
        /// <param name="helloWorld">An input string of text.</param>
        /// <returns>A string of text echoing the input value.</returns>
        public string HelloWorldFromDatabase(string helloWorld)
        {
            ClubCloudServiceApplication application = SPIisWebServiceApplication.Current as ClubCloudServiceApplication;
            if (application == null)
            {
                throw new InvalidOperationException("Could not find the current Service Application.");
            }

            using (SqlConnection connection = new SqlConnection(application.Database.DatabaseConnectionString))
            {
                ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer();
                model.Database.Connection.ConnectionString = connection.ConnectionString;
                ObjectParameter output = new ObjectParameter("output", SqlDbType.NVarChar);
                model.HelloWorld(helloWorld, output);


                return (string)output.Value;

                
                //using (SqlCommand command = new SqlCommand("HelloWorld", connection))
                //{
                //    command.CommandType = CommandType.StoredProcedure;
                //    command.Parameters.AddWithValue("@input", helloWorld);
                //    SqlParameter output = new SqlParameter("@output", SqlDbType.NVarChar) { Direction = ParameterDirection.Output, Size = -1 };
                //    command.Parameters.Add(output);

                //    connection.Open();

                //    command.ExecuteNonQuery();

                //    string returnValue = (string)command.Parameters[1].Value;

                //    return returnValue;
                //}
                
            }
        }
        */

        #endregion


        public ClubCloud_Gebruiker GetClubCloudUserFromDatabase(string user)
        {
            ClubCloud_Gebruiker gebruiker = null;
            ClubCloudServiceApplication application = SPIisWebServiceApplication.Current as ClubCloudServiceApplication;
            if (application == null)
            {
                throw new InvalidOperationException("Could not find the current Service Application.");
            }

            using (SqlConnection connection = new SqlConnection(application.Database.DatabaseConnectionString))
            {
                using (ClubCloud.Service.Model.ClubCloudModelContainer model = new Model.ClubCloudModelContainer(connection.ConnectionString))
                {
                    
                    model.Database.CreateIfNotExists();
                    /*
                    if (model.Database.Exists())
                    {
                        model.Database.Initialize(true);
                    }
                    */

                    gebruiker = model.ClubCloud_Gebruikers.Find(int.Parse(user));

                    if (gebruiker != null && !string.IsNullOrWhiteSpace(gebruiker.mijnknltb_password))
                    {
                        CookieContainer cc = RequestContainer(gebruiker.Id.ToString(), gebruiker.mijnknltb_password);

                        LedenadministratieServiceClient LedenAdministratie = new LedenadministratieServiceClient(cc);
                        GetPersoonsgegevensResponse persoon = LedenAdministratie.GetPersoonsgegevens(new GetPersoonsgegevensRequest { Bondsnummer = gebruiker.Id.ToString() });
                        Persoonsgegevens persoonsgegevens = persoon.Persoonsgegevens;
                        gebruiker.FirstName = persoonsgegevens.Voornamen;
                        gebruiker.MiddleName = persoonsgegevens.Tussenvoegsel;
                        gebruiker.LastName = persoonsgegevens.Achternaam;
                        model.SaveChanges();
                    }
                }
            }
            return gebruiker;
        }

    }
}
