//-----------------------------------------------------------------------
// <copyright file="SetClubCloudServiceApplication.cs" company="">
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
    /// Updates the service application.
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "ClubCloudServiceApplication", SupportsShouldProcess = true)]
    [SPCmdlet(RequireLocalFarmExist = true, RequireUserFarmAdmin = true)]
    [System.Runtime.InteropServices.Guid("11f4c31f-efba-4ff2-b039-19e2c574d845")]
    public class SetClubCloudServiceApplication : SPCmdlet
    {
        #region Fields
        /// <summary>
        /// The application pool.
        /// </summary>
        private SPServiceApplicationPipeBind application;

        /// <summary>
        /// The name of the service application.
        /// </summary>
        private string name;

        /// <summary>
        /// An application pool to update
        /// </summary>
        private SPIisWebServiceApplicationPoolPipeBind applicationPool;

        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the service application to update.
        /// </summary>
        [Parameter(Mandatory = true, Position = 0)]
        [ValidateNotNullOrEmpty]
        public SPServiceApplicationPipeBind Identity
        {
            get
            {
                return this.application;
            }

            set
            {
                this.application = value;
            }
        }

        /// <summary>
        /// Gets or sets the name of the application.
        /// </summary>
        [Parameter(Mandatory = false)]
        [ValidateNotNullOrEmpty]
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        /// <summary>
        /// Gets or sets the application pool.
        /// </summary>
        [Parameter(Mandatory = false)]
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
        /// Gets or sets the database credentials.
        /// </summary>
        [Parameter(Mandatory = false)]
        public PSCredential DatabaseCredentials
        {
            get;

            set;
        }

        /// <summary>
        /// Gets or sets the database failover server.
        /// </summary>
        [Parameter(Mandatory = false)]
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
            SPServiceApplication resolvedApplication = null;
            ClubCloudServiceApplication castedApplication = null;

            resolvedApplication = this.Identity.Read();

            if (resolvedApplication == null)
            {
                this.ThrowTerminatingError(new InvalidOperationException("No service application was found."), ErrorCategory.InvalidOperation, this);
            }

            castedApplication = resolvedApplication as ClubCloudServiceApplication;

            if (castedApplication == null)
            {
                this.ThrowTerminatingError(new InvalidOperationException("The service application provided was not of the correct type."), ErrorCategory.InvalidOperation, this);
            }

            if (this.ShouldProcess(castedApplication.Name))
            {
                // Update the name
                if (!string.IsNullOrEmpty(this.Name) && (!string.Equals(this.Name.Trim(), castedApplication.Name, StringComparison.OrdinalIgnoreCase)))
                {
                    // Get the service
                    ClubCloudService service = SPFarm.Local.Services.GetValue<ClubCloudService>();

                    if (service != null)
                    {
                        // Check for duplicate name
                        SPServiceApplication duplicateApplication = service.Applications[this.Name.Trim()];

                        if (duplicateApplication != null)
                        {
                            this.ThrowTerminatingError(new InvalidOperationException("A service application with that name already exists."), ErrorCategory.InvalidOperation, this);
                        }
                    }

                    castedApplication.Name = this.Name.Trim();
                }

                // Update the application pool
                if (this.ApplicationPool != null)
                {
                    SPIisWebServiceApplicationPool resolvedApplicationPool = this.ApplicationPool.Read();

                    if (resolvedApplicationPool != null)
                    {
                        castedApplication.ApplicationPool = resolvedApplicationPool;
                    }
                }

                if (this.DatabaseCredentials != null)
                {
                    NetworkCredential databaseCredentials = (NetworkCredential)this.DatabaseCredentials;

                    castedApplication.Database.Username = databaseCredentials.UserName;
                    castedApplication.Database.Password = databaseCredentials.Password;
                }
                else if (!string.IsNullOrEmpty(castedApplication.Database.Username))
                {
                    castedApplication.Database.Username = null;
                    castedApplication.Database.Password = null;
                }

                if (!string.IsNullOrEmpty(this.DatabaseFailoverServerName))
                {
                    castedApplication.Database.AddFailoverServiceInstance(this.DatabaseFailoverServerName);
                }
                else if (castedApplication.Database.FailoverServer != null)
                {
                    castedApplication.Database.AddFailoverServiceInstance(null);
                }

                castedApplication.Database.Update();

                castedApplication.Update();
            }
        }

        /// <summary>
        /// Validates the arguments.
        /// </summary>
        protected override void InternalValidate()
        {
            // Validate a farm exists
            SPFarm farm = SPFarm.Local;
            if (farm == null)
            {
                this.ThrowTerminatingError(new InvalidOperationException("SharePoint server farm not found."), ErrorCategory.ResourceUnavailable, this);
            }

            SPServer server = SPServer.Local;
            if (server == null)
            {
                this.ThrowTerminatingError(new InvalidOperationException("SharePoint local server not found."), ErrorCategory.ResourceUnavailable, this);
            }
        }

        #endregion
    }
}
