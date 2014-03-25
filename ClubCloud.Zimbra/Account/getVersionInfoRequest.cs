using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Account
{
    [MessageContract(WrapperName = "GetVersionInfoRequest", WrapperNamespace = "urn:zimbraAccount")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:zimbraAdmin")]
    [System.Xml.Serialization.XmlRootAttribute("GetVersionInfoRequest", Namespace = "urn:zimbraAccount", IsNullable = false)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "GetVersionInfoRequest", Namespace = "urn:zimbraAccount")]
    public partial class GetVersionInfoRequest : ZimbraMessage // System.ComponentModel.INotifyPropertyChanged
    {
    }
}
