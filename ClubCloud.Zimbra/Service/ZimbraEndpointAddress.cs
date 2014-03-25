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

namespace ClubCloud.Zimbra.Service
{
    internal class ZimbraEndpointAddress : EndpointAddress
    {
        internal static AddressHeader[] headers = new AddressHeader[1] { AddressHeader.CreateAddressHeader(ZimbraHeaderContext) };
        internal ZimbraEndpointAddress(string uri)
            : base(new Uri(uri), headers)
        {
            ServicePointManager.ServerCertificateValidationCallback = delegate(
            Object obj, X509Certificate certificate, X509Chain chain,
            SslPolicyErrors errors)
            {
                return (true);
            };

        }

        private static ZimbraHeaderContext _ZimbraHeaderContext;
        internal static ZimbraHeaderContext ZimbraHeaderContext
        {
            get
            { 
                if(_ZimbraHeaderContext == null)
                {
                    _ZimbraHeaderContext = new ZimbraHeaderContext();
                }
                return _ZimbraHeaderContext;
            }
            set {
                _ZimbraHeaderContext = value;
            }
        }
    }
}
