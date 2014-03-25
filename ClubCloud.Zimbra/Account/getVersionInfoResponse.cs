using ClubCloud.Zimbra.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Account
{
    [MessageContract(WrapperName = "GetVersionInfoResponse", WrapperNamespace = "urn:zimbraAccount")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:zimbraAdmin")]
    [System.Xml.Serialization.XmlRootAttribute("GetVersionInfoResponse", Namespace = "urn:zimbraAccount", IsNullable = false)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "GetVersionInfoResponse", Namespace = "urn:zimbraAccount")]

    public partial class GetVersionInfoResponse : ZimbraMessage // System.ComponentModel.INotifyPropertyChanged
    {

        private versionInfo _info;

        public GetVersionInfoResponse()
        {
            this._info = new versionInfo();
        }

        [System.Xml.Serialization.XmlElementAttribute(ElementName = "info", Namespace = "urn:zimbraAccount")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public versionInfo info
        {
            get
            {
                return this._info;
            }
            set
            {
                if (((this._info == null)
                            || (_info.Equals(value) != true)))
                {
                    this._info = value;
                    this.OnPropertyChanged("info");
                }
            }
        }
    }

}
