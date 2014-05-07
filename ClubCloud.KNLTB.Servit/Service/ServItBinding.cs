using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.KNLTB.Servit
{
    public class ServItBinding : BasicHttpBinding
    {
        public ServItBinding()
            : base()
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
