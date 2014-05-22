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
        #region Methods

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
                using (SqlCommand command = new SqlCommand("HelloWorld", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@input", helloWorld);
                    SqlParameter output = new SqlParameter("@output", SqlDbType.NVarChar) { Direction = ParameterDirection.Output, Size = -1 };
                    command.Parameters.Add(output);

                    connection.Open();

                    command.ExecuteNonQuery();

                    string returnValue = (string)command.Parameters[1].Value;

                    return returnValue;
                }
            }
        }

        #endregion
    }
}
