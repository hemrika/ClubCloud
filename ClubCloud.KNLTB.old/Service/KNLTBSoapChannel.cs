using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.KNLTB.Service
{
    internal interface KNLTBSoapChannel : KNLTBSoap, System.ServiceModel.IClientChannel
    {
    }
}
