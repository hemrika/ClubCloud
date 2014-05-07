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

namespace ClubCloud.KNLTB.Servit
{
    public class ServItEndpointAddress : EndpointAddress
    {
        internal static AddressHeader[] headers = new AddressHeader[1] { AddressHeader.CreateAddressHeader(ServItHeaderContext) };

        private static ServItHeaderContext _ServItHeaderContext;
        internal static ServItHeaderContext ServItHeaderContext
        {
            get
            {
                if (_ServItHeaderContext == null)
                {
                    _ServItHeaderContext = new ServItHeaderContext();
                }
                return _ServItHeaderContext;
            }
            set
            {
                _ServItHeaderContext = value;
            }
        }

        internal ServItEndpointAddress(string uri)
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
