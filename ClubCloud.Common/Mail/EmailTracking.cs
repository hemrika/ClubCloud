using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Common.Mail
{
    public class EmailTracking
    {
        private string _TrackingId;

        /// <summary>
        /// tid
        /// </summary>
        public string TrackingId
        {
            get { return _TrackingId; }
            set { _TrackingId = value; }
        }

        private Guid _ClientId;

        /// <summary>
        /// cid
        /// </summary>
        public Guid ClientId
        {
            get { return _ClientId; }
            set { _ClientId = value; }
        }

        private string _RecipientId;

        public string RecipientId
        {
            get { return _RecipientId; }
            set { _RecipientId = value; }
        }

        private string _CampaignSource;

        /// <summary>
        /// utm_source or cs
        /// </summary>
        public string CampaignSource
        {
            get { return _CampaignSource; }
            set { _CampaignSource = value; }
        }

        private string _CampaignName;

        /// <summary>
        /// utm_campaign or cn
        /// </summary>
        public string CampaignName
        {
            get { return _CampaignName; }
            set { _CampaignName = value; }
        }

        private string _CampagneMedium;

        /// <summary>
        /// utm_medium or cm
        /// </summary>
        public string CampagneMedium
        {
            get { return _CampagneMedium; }
            set { _CampagneMedium = value; }
        }

        private string _CampagneTerm;

        /// <summary>
        /// utm_term
        /// </summary>
        public string CampagneTerm
        {
            get { return _CampagneTerm; }
            set { _CampagneTerm = value; }
        }

        private string _CampagneContent;

        /// <summary>
        /// utm_content
        /// </summary>
        public string CampagneContent
        {
            get { return _CampagneContent; }
            set { _CampagneContent = value; }
        }

    }
}
