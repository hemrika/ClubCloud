﻿//-----------------------------------------------------------------------
// <copyright file="NewClubCloudServiceApplication.cs" company="">
// Copyright © 
// </copyright>
//-----------------------------------------------------------------------

namespace ClubCloud.Service.PowerShell
{
    using System;
    using System.Management.Automation;
    using System.Net;
    using Microsoft.SharePoint.Administration;
    using Microsoft.SharePoint.PowerShell;
    using ClubCloud.Service;

    /// <summary>
    /// Creates a new service application.
    /// </summary>
    [Cmdlet(VerbsCommon.New, "ClubCloudServiceApplication", SupportsShouldProcess = true, DefaultParameterSetName = "DefaultSet")]
    [SPCmdlet(RequireLocalFarmExist = true, RequireUserFarmAdmin = true)]
    [System.Runtime.InteropServices.Guid("245809ef-3bba-444e-b165-7fec3200634c")]
    public sealed class NewClubCloudServiceApplication : SPCmdlet
    {
        #region Fields

        /// <summary>
        /// The application pool.
        /// </summary>
        private SPIisWebServiceApplicationPoolPipeBind applicationPool;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the name of the service application.
        /// </summary>
        [Parameter(Mandatory = true, Position = 0)]
        [ValidateNotNullOrEmpty]
        public string Name
        {
            get;

            set;
        }

        /// <summary>
        /// Gets or sets the application pool to use for the service application.
        /// </summary>
        [Parameter(Mandatory = true, Position = 1, ValueFromPipeline = true)]
        [ValidateNotNull]
        public SPIisWebServiceApplicationPoolPipeBind ApplicationPool
        {
            get
            {
                return this.applicationPool;
            }

            set
            {
                this.applicationPool = value;
            }
        }

        /// <summary>
        /// Gets or sets the name of the database to create.
        /// </summary>
        [Parameter(Mandatory = true, ParameterSetName = "DB")]
        [ValidateNotNullOrEmpty]
        public string DatabaseName
        {
            get;

            set;
        }

        /// <summary>
        /// Gets or sets the name of the database server.
        /// </summary>
        [Parameter(Mandatory = false, ParameterSetName = "DB")]
        [ValidateNotNullOrEmpty]
        public string DatabaseServerName
        {
            get;

            set;
        }

        /// <summary>
        /// Gets or sets the credentials for the database for SQL Authentication (windows authentication is recommended).
        /// </summary>
        [Parameter(Mandatory = false, ParameterSetName = "DB")]
        public PSCredential DatabaseCredentials
        {
            get;

            set;
        }

        /// <summary>
        /// Gets or sets the name of the failover server to participate in database mirroring.
        /// </summary>
        [Parameter(Mandatory = false, ParameterSetName = "DB")]
        public string DatabaseFailoverServerName
        {
            get;

            set;
        }

        #endregion

        #region Methods

        /// <summary>
        /// This method gets invoked when the command is called
        /// </summary>
        protected override void InternalProcessRecord()
        {
            SPIisWebServiceApplicationPool resolvedApplicationPool = this.ApplicationPool.Read();

            if (resolvedApplicationPool == null)
            {
                this.ThrowTerminatingError(new InvalidOperationException("Could not find the specified application pool."), ErrorCategory.InvalidOperation, this);
            }

            if (this.ShouldProcess(this.Name))
            {
                // Get or create the service
                ClubCloudService service = ClubCloudService.GetOrCreateService();

                // Get or create the service proxy
                ClubCloudServiceProxy.GetOrCreateServiceProxy();

                // Install the service instances to servers in this farm
                ClubCloudServiceInstance.CreateServiceInstances(service);

                // Create the service application
                ClubCloudServiceApplication application = new ClubCloudServiceApplication(this.Name, service, resolvedApplicationPool);
                application.Update();
                application.Provision();

                // Database settings
                if (string.Equals(this.ParameterSetName, "DB", StringComparison.OrdinalIgnoreCase))
                {
                    NetworkCredential databaseCredentials = null;

                    if (this.DatabaseCredentials != null)
                    {
                        databaseCredentials = (NetworkCredential)this.DatabaseCredentials;
                    }

                    SPDatabaseParameters databaseParameters = SPDatabaseParameters.CreateParameters(this.DatabaseName, this.DatabaseServerName, databaseCredentials, this.DatabaseFailoverServerName, SPDatabaseParameterOptions.None);

                    // Create the database
                    ClubCloudDatabase database = new ClubCloudDatabase(databaseParameters);

                    // Provision the database (runs the Create scripts)            
                    database.Provision();

                    // Grant the database the proper permissions
                    database.GrantApplicationPoolAccess(resolvedApplicationPool.ProcessAccount.SecurityIdentifier);

                    // Add the failover server instance (the base class does not do this for you)
                    if (!string.IsNullOrEmpty(this.DatabaseFailoverServerName))
                    {
                        database.AddFailoverServiceInstance(this.DatabaseFailoverServerName);
                    }

                    // Establish a relationship between the service application and the database
                    application.Database = database;
                    application.Update();
                }

                this.WriteObject(application);
            }
        }

        /// <summary>
        /// Validate the arguments.
        /// </summary>
        protected override void InternalValidate()
        {
            // Validate a farm exists
            SPFarm farm = SPFarm.Local;
            if (farm == null)
            {
                this.ThrowTerminatingError(new InvalidOperationException("SharePoint server farm not found."), ErrorCategory.InvalidOperation, this);
            }

            SPServer server = SPServer.Local;
            if (server == null)
            {
                this.ThrowTerminatingError(new InvalidOperationException("SharePoint local server not found."), ErrorCategory.InvalidOperation, this);
            }

            // Get the service
            ClubCloudService service = SPFarm.Local.Services.GetValue<ClubCloudService>();

            if (service != null)
            {
                // Check for duplicate name
                SPServiceApplication application = service.Applications[this.Name];

                if (application != null)
                {
                    this.ThrowTerminatingError(new InvalidOperationException("A service application with that name already exists."), ErrorCategory.InvalidOperation, this);
                }
            }

            if (string.IsNullOrEmpty(this.DatabaseServerName))
            {
                this.DatabaseServerName = SPWebService.ContentService.DefaultDatabaseInstance.NormalizedDataSource;
            }
        }

        #endregion
    }
}
