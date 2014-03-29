using ClubCloud.Zimbra.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Administration
{
    [MessageContract(WrapperName = "GetCosResponse", WrapperNamespace = "urn:zimbraAdmin")]
    public partial class GetCosResponse : ZimbraMessage
    {

        private cosInfo _cos;

        public GetCosResponse()
        {
            this._cos = new cosInfo();
        }

        [System.Xml.Serialization.XmlElementAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public cosInfo cos
        {
            get
            {
                return this._cos;
            }
            set
            {
                if (((this._cos == null)
                            || (_cos.Equals(value) != true)))
                {
                    this._cos = value;
                    this.OnPropertyChanged("cos");
                }
            }
        }
    }
}
