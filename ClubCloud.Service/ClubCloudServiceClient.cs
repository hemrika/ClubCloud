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
    using System.Threading.Tasks;

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

        public ClubCloud_Setting SetPrivacy(ClubCloud_Setting settings)
        {
            ClubCloud_Setting response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetPrivacy(settings);
                },
                false);

            return response;
        }

        public ClubCloud_Setting SetMijnKNLTB(ClubCloud_Setting settings)
        {
            ClubCloud_Setting response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetMijnKNLTB(settings);
                },
                false);

            return response;
        }

        public ClubCloud_Setting SetTwitter(ClubCloud_Setting settings)
        {
            ClubCloud_Setting response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetTwitter(settings);
                },
                false);

            return response;
        }

        public ClubCloud_Setting SetFaceBook(ClubCloud_Setting settings)
        {
            ClubCloud_Setting response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetFaceBook(settings);
                },
                false);

            return response;
        }

        public ClubCloud_Setting SetFinancieel(ClubCloud_Setting settings)
        {
            ClubCloud_Setting response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetFinancieel(settings);
                },
                false);

            return response;
        }

        public ClubCloud_Setting SetTracking(ClubCloud_Setting settings)
        {
            ClubCloud_Setting response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetTracking(settings);
                },
                false);

            return response;
        }

        public ClubCloud_Setting GetClubCloudSettings(string bondsnummer)
        {
            ClubCloud_Setting response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetClubCloudSettings(bondsnummer);
                },
                false);

            return response;
        }

        public async Task<ClubCloud_Setting> GetClubCloudSettingsAsync(string bondsnummer)
        {
            return await Task.Run(() => GetClubCloudSettings(bondsnummer));
            /*
            ClubCloud_Setting currentsettings = new ClubCloud_Setting();

            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {
                ClubCloudServiceClient client = new ClubCloudServiceClient(SPServiceContext.Current);
                currentsettings = await Task.Run(() => GetClubCloudSettings(bondsnummer));
            }
            return currentsettings;
            */
        }

        public ClubCloud_Gebruiker GetClubCloudGebruiker(string bondsnummer, bool refresh = false)
        {
            ClubCloud_Gebruiker response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetClubCloudGebruiker(bondsnummer, refresh);
                },
                false);

            return response;
        }

        public SpelersProfiel GetSpelersProfiel(string bondsnummer, bool refresh = false)
        {
            SpelersProfiel response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetSpelersProfiel(bondsnummer, refresh);
                },
                false);

            return response;

        }

        public List<ClubCloud_Gebruiker_Vereniging> GetVerenigingen(string bondsnummer, bool refresh = false)
        {
            List<ClubCloud_Gebruiker_Vereniging> response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetVerenigingen(bondsnummer, refresh);
                },
                false);

            return response;

        }

        public ClubCloud_Vereniging GetVerenigingById(string bondsnummer, Guid verenigingId, bool refresh = false)
        {
            ClubCloud_Vereniging response = null;

            try
            {
                this.ExecuteOnChannel<IClubCloudApplicationService>(
                    delegate(IClubCloudApplicationService channel)
                    {
                        response = channel.GetVerenigingById(bondsnummer, verenigingId, refresh);
                    },
                    false);
            }
            catch { }

            return response;

        }

        public ClubCloud_Vereniging GetVerenigingByNummer(string bondsnummer, string vereniginsnummer, bool refresh = false)
        {
            ClubCloud_Vereniging response = null;

            try
            {
                this.ExecuteOnChannel<IClubCloudApplicationService>(
                    delegate(IClubCloudApplicationService channel)
                    {
                        response = channel.GetVerenigingByNummer(bondsnummer, vereniginsnummer, refresh);
                    },
                    false);

            }
            catch { }

            return response;

        }

        public List<ClubCloud_Vereniging_BestuursLid> GetBestuurForVereniging(string bondsnummer, Guid verenigingId, bool refresh = false)
        {
            List<ClubCloud_Vereniging_BestuursLid> response = null;

            try
            {
                this.ExecuteOnChannel<IClubCloudApplicationService>(
                    delegate(IClubCloudApplicationService channel)
                    {
                        response = channel.GetBestuurForVereniging(bondsnummer, verenigingId, refresh);
                    },
                    false);

            }
            catch { }

            return response;

        }

        public ClubCloud_Vereniging_Accomodatie GetAccommodatieForVereniging(string bondsnummer, Guid verenigingId, bool refresh = false)
        {
            ClubCloud_Vereniging_Accomodatie response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetAccommodatieForVereniging(bondsnummer, verenigingId, refresh);
                },
                false);

            return response;

        }

        public ClubCloud_Accomodatie GetAccomodatie(string bondsnummer, Guid verenigingId, bool refresh = false)
        {
            ClubCloud_Accomodatie response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetAccommodatie(bondsnummer, verenigingId, refresh);
                },
                false);

            return response;

        }

        public SpelerTracking GetTracking(string bondsnummer, bool refresh = false)
        {
            SpelerTracking response = null;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.GetTracking(bondsnummer, refresh);
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

        public bool SetClubCloudGebruiker(string bondsnummer, ClubCloud_Gebruiker gebruiker, bool refresh = false)
        {
            bool response = false;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SetClubCloudGebruiker(bondsnummer, gebruiker, refresh);
                },
                false);

            return response;
        }
    }
}