using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Administration
{
    [System.Runtime.Serialization.DataContractAttribute(Name = "AddDistributionListMemberRequest", Namespace = "urn:zimbraAdmin")]
    public partial class AddDistributionListMemberRequest : ZimbraMessage
    {

        private List<string> _dlm;

        private string _id;

        public AddDistributionListMemberRequest()
        {
            this._dlm = new List<string>();
        }

        [System.Xml.Serialization.XmlElementAttribute("dlm")]
        [System.Runtime.Serialization.DataMemberAttribute()]
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

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
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
