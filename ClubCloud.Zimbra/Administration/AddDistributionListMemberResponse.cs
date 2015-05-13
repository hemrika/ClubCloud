using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Administration
{
    //[System.Runtime.Serialization.DataContractAttribute(Name = "AddDistributionListMemberResponse", Namespace = "urn:zimbraAdmin")]
    [MessageContract(WrapperName = "AddDistributionListMemberResponse", WrapperNamespace = "urn:zimbraAdmin")]
    public partial class AddDistributionListMemberResponse : ZimbraMessage
    {
    }
}
