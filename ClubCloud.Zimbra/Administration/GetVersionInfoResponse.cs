using ClubCloud.Zimbra.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Administration
{
    [MessageContract(WrapperName = "GetVersionInfoResponse", WrapperNamespace = "urn:zimbraAdmin")]
    public partial class GetVersionInfoResponse : ZimbraMessage
    {

        private versionInfo _info;

        public GetVersionInfoResponse()
        {
            this._info = new versionInfo();
        }

        [System.Xml.Serialization.XmlElementAttribute(ElementName = "info", Namespace = "urn:zimbraAdmin")]
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
