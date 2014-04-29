//-----------------------------------------------------------------------
// <copyright file="ClubCloudDatabase.cs" company="">
// Copyright © 
// </copyright>
//-----------------------------------------------------------------------

namespace ClubCloud.Service
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Security.Principal;
    using Microsoft.SharePoint.Administration;
    using Microsoft.SharePoint.Utilities;

    /// <summary>
    /// Custom Database class. Contains logic to Provision/Upgrade/Remove the custom database.
    /// </summary>
    [System.Runtime.InteropServices.Guid("a965364b-3e92-468f-985f-ddf9f661174f")]
    internal sealed class ClubCloudDatabase : SPDatabase
    {
        #region Fields

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ClubCloudDatabase"/> class. Default constructor (required for SPPersistedObject serialization). Do not call this directly.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ClubCloudDatabase()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClubCloudDatabase"/> class. Use this constructor when creating a new database in the farm.
        /// </summary>
        /// <param name="databaseParameters">The database parameters to use when creating the new database.</param>
        internal ClubCloudDatabase(SPDatabaseParameters databaseParameters)
            : base(databaseParameters)
        {
            this.Status = SPObjectStatus.Disabled;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Contains the logic to Provision the database.
        /// </summary>
        public override void Provision()
        {
            // Stop if the DB has already been provisioned
            if (this.Status == SPObjectStatus.Online)
            {
                return;
            }

            // Update the status to provisioning
            this.Status = SPObjectStatus.Provisioning;
            this.Update();

            // Run the provisioning scripts if we are not attaching to an existing database
            if (!this.Exists)
            {
                // Create any DB options
                //Dictionary<string, bool> options = new Dictionary<string, bool>();
                Dictionary<DatabaseOptions, bool> options = new Dictionary<DatabaseOptions, bool>();
                //options.Add(SPDatabase.SqlDatabaseOption[(int)DatabaseOptions.AutoClose], false);
                options.Add(DatabaseOptions.AutoClose, false);
                SPDatabase.Provision(
                    this.DatabaseConnectionString,
                    //SPUtility.GetGenericSetupPath(@"TEMPLATE\SQL\ClubCloud.Service\CreateDatabase.sql"),
                    SPUtility.GetVersionedGenericSetupPath(@"TEMPLATE\SQL\ClubCloud.Service\ClubCloud.sql",15),
                    options);
            }

            this.Status = SPObjectStatus.Online;
            this.Update();
        }

        /// <summary>
        /// Grants the application pool service account rights to the database. Call this after you call Provision() 
        /// on this class.
        /// </summary>
        /// <param name="processSecurityIdentifier">The application pool service account.</param>
        internal void GrantApplicationPoolAccess(SecurityIdentifier processSecurityIdentifier)
        {
            this.GrantAccess(processSecurityIdentifier, "db_owner");
        }

        #endregion
    }
}
