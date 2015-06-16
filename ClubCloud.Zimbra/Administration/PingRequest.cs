using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Administration
{
    [MessageContract(WrapperName = "PingRequest", WrapperNamespace = "urn:zimbraAdmin")]
    public partial class PingRequest : ZimbraMessage
    {
    }
}
