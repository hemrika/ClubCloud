using ClubCloud.Zimbra.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Administration
{
    [MessageContract(WrapperName = "GetCosRequest", WrapperNamespace = "urn:zimbraAdmin")]
    public partial class GetCosRequest : attributeSelectorImpl
    {

        private cosSelector _cos;

        public GetCosRequest()
        {
            this._cos = new cosSelector();
        }

        [System.Xml.Serialization.XmlElementAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public cosSelector cos
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
