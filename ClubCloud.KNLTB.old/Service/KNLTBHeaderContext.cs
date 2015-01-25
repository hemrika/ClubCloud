using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.KNLTB.Service
{
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:clubcloud")]
    [System.Xml.Serialization.XmlRootAttribute("context", Namespace = "urn:clubcloud", ElementName = "context")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "context", Namespace = "urn:clubcloud")]
    internal partial class KNLTBHeaderContext
    {

        public KNLTBHeaderContext()
        {
        }

        /*
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Name = "authToken", IsRequired = false)]
        public string authToken
        {
            get
            {
                return this._authToken;
            }
            set
            {
                if (((this._authToken == null)
                            || (_authToken.Equals(value) != true)))
                {
                    this._authToken = value;
                    //this.OnPropertyChanged("authToken");
                }
            }
        }
        */
    }
}
