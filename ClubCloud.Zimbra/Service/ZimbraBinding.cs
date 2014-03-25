using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Service
{
    internal class ZimbraBinding : BasicHttpsBinding
    {

        internal ZimbraBinding()
            : base(BasicHttpsSecurityMode.Transport)
        {
        }

        public override string Scheme
        {
            get
            {
                return "https";
            }
        }
    }
}
