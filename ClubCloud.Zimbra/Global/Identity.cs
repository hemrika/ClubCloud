using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Global
{
    [System.Runtime.Serialization.DataContractAttribute(Name = "Identity", Namespace = "urn:zimbraAccount")]
    public partial class Identity : attrsImpl
    {

        private string _name;

        private string _id;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name
        {
            get
            {
                return this._name;
            }
            set
            {
                if (((this._name == null)
                            || (_name.Equals(value) != true)))
                {
                    this._name = value;
                    this.OnPropertyChanged("name");
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
