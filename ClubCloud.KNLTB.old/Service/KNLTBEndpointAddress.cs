using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.KNLTB.Service
{
    public class KNLTBEndpointAddress : EndpointAddress
    {
        internal static AddressHeader[] headers = new AddressHeader[1] { AddressHeader.CreateAddressHeader(KNLTBHeaderContext) };

        private static KNLTBHeaderContext _KNLTBHeaderContext;
        internal static KNLTBHeaderContext KNLTBHeaderContext
        {
            get
            {
                if (_KNLTBHeaderContext == null)
                {
                    _KNLTBHeaderContext = new KNLTBHeaderContext();
                }
                return _KNLTBHeaderContext;
            }
            set
            {
                _KNLTBHeaderContext = value;
            }
        }

        internal KNLTBEndpointAddress(string uri)
            : base(new Uri(uri), headers)
        {
            ServicePointManager.ServerCertificateValidationCallback = delegate(
            Object obj, X509Certificate certificate, X509Chain chain,
            SslPolicyErrors errors)
            {
                return (true);
            };
        }
    }
}
