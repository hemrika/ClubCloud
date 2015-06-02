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

        public string TrackingId
        {
            get { return _TrackingId; }
            set { _TrackingId = value; }
        }

        private string _ClientId;

        public string ClientId
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

        public string CampaignSource
        {
            get { return _CampaignSource; }
            set { _CampaignSource = value; }
        }

        private string _CampaignName;

        public string CampaignName
        {
            get { return _CampaignName; }
            set { _CampaignName = value; }
        }

        /*
        public static XElement ToXElement<T>(this T obj)
        {
            using (var memoryStream = new MemoryStream())
            {
                using (TextWriter streamWriter = new StreamWriter(memoryStream))
                {
                    var xmlSerializer = new XmlSerializer(typeof(T));
                    xmlSerializer.Serialize(streamWriter, obj);
                    return XElement.Parse(Encoding.ASCII.GetString(memoryStream.ToArray()));
                }
            }
        }

        public static T FromXElement<T>(this XElement xElement)
        {
            using (var memoryStream = new MemoryStream(Encoding.ASCII.GetBytes(xElement.ToString())))
            {
                var xmlSerializer = new XmlSerializer(typeof(T));
                return (T)xmlSerializer.Deserialize(memoryStream);
            }
        }
        */
    }
}
