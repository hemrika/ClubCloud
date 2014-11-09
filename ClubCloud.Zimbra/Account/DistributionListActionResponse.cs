using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Account
{
    [MessageContract(WrapperName = "DistributionListActionResponse", WrapperNamespace = "urn:zimbraAccount")]
    public class DistributionListActionResponse : ZimbraMessage
    {
    }
}
