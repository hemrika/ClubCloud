using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Administration
{
    //[System.Runtime.Serialization.DataContractAttribute(Name = "AddDistributionListMemberRequest", Namespace = "urn:zimbraAdmin")]
    [MessageContract(WrapperName = "AddDistributionListMemberRequest", WrapperNamespace = "urn:zimbraAdmin")]
    public partial class AddDistributionListMemberRequest : ZimbraMessage
    {

        private List<string> _dlm;

        private string _id;

        public AddDistributionListMemberRequest()
        {
            this._dlm = new List<string>();
            this._dlm.Capacity = 1;
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
