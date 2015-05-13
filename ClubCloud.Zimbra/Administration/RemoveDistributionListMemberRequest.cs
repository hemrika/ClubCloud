using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Administration
{
    //[System.Runtime.Serialization.DataContractAttribute(Name = "RemoveDistributionListMemberRequest", Namespace = "urn:zimbraAdmin")]
    [MessageContract(WrapperName = "RemoveDistributionListMemberRequest", WrapperNamespace = "urn:zimbraAdmin")]
    public partial class RemoveDistributionListMemberRequest : ZimbraMessage
    {

        private List<string> _dlm;

        private string _id;

        public RemoveDistributionListMemberRequest()
        {
            this._dlm = new List<string>();
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = false, EmitDefaultValue = false)]
        [System.Xml.Serialization.XmlElement(ElementName = "dlm", Namespace = "urn:zimbraAdmin")]
        [MessageBodyMember]
        public List<string> dlm
        {
            get
            {
                return this._dlm;
            }
            set
            {
                if (((this._dlm == null)
                            || (_dlm.Equals(value) != true)))
                {
                    this._dlm = value;
                    this.OnPropertyChanged("dlm");
                }
            }
        }

        //[System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public string id
        {
            get
            {
                return this._id;
            }
            set
            {
                if (((this._id == null)
                            || (_id.Equals(value) != true)))
                {
                    this._id = value;
                    this.OnPropertyChanged("id");
                }
            }
        }
    }
}
