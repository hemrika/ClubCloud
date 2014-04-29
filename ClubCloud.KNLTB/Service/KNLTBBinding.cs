using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.KNLTB.Service
{
    public class KNLTBBinding : BasicHttpBinding
    {
        public KNLTBBinding()
            : base()
        {
        }

        public override string Scheme
        {
            get
            {
                return "http";
            }
        }
    }
}
