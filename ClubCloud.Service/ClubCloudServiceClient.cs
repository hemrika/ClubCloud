//-----------------------------------------------------------------------
// <copyright file="HelloWorldServiceClient.cs" company="">
// Copyright © 
// </copyright>
//-----------------------------------------------------------------------

namespace ClubCloud.Service
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Microsoft.SharePoint;
    using ClubCloud.Service.Model;
    using ClubCloud.KNLTB.ServIt.LedenAdministratieService;

    /// <summary>
    /// This is the class that is accessible to the Client callers (web parts, user controls, timer jobs, etc.).
    /// </summary>
    public class ClubCloudServiceClient : BaseServiceClient
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ClubCloudServiceClient"/> class.
        /// </summary>
        public ClubCloudServiceClient()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClubCloudServiceClient"/> class.
        /// </summary>
        /// <param name="serviceContext">An <see cref="Microsoft.SharePoint.Administration.SPServiceContext" />.</param>
        public ClubCloudServiceClient(SPServiceContext serviceContext)
            : base(serviceContext)
        {
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the name of the actual (.svc file) for this service.
        /// </summary>
        /// <remarks>
        /// Service applications are designed to support a single endpoint .svc file. For more complicated 
        /// service applications with many different types of services, it makes sense to create several .svc files 
        /// and classes. To support multiple end points, use a recognizable string here, and swap it out dynamically 
        /// in the BaseServiceClient's GetEndPoint method after the load balancer has provided the full path to this 
        /// original end point.
        /// </remarks>
        protected override string EndPoint
        {
            get { return "ClubCloud.svc"; }
        }

        #endregion

        #region Methods

        public ClubCloud_Gebruiker GetClubCloudUser(string user)
        {
            ClubCloud_Gebruiker response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetClubCloudUser(user);
                },
                false);

            return response;

        }

        public Persoonsgegevens GetPersoonsgegevens(string bondsnummer)
        {
            Persoonsgegevens response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetPersoonsgegevens(bondsnummer);
                },
                false);

            return response;

        }

        public SpelersProfiel GetPersoonsprofiel(string bondsnummer, bool track = false)
        {
            SpelersProfiel response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetPersoonsprofiel(bondsnummer);
                },
                false);

            return response;

        }

        public List<Vereniging> GetVerenigingen(string bondsnummer)
        {
            List<Vereniging> response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetVerenigingen(bondsnummer);
                },
                false);

            return response;

        }

        public ClubCloud_Vereniging GetVereniging(string bondsnummer, Guid verenigingId)
        {
            ClubCloud_Vereniging response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetVereniging(bondsnummer,verenigingId);
                },
                false);

            return response;

        }

        public List<District> GetDistricten(string user)
        {
            List<District> response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetDistricten(user);
                },
                false);

            return response;

        }

        public bool CreateClubCloudWebSite(string verenigingsnummer)
        {
            bool response = false;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.CreateClubCloudWebSite(verenigingsnummer);
                },
                false);

            return response;

        }

        #endregion
    }
}