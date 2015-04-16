using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Mail
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:zimbraMail")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "msgToSend", Namespace = "urn:zimbraMail")]
    public partial class msgToSend : msg
    {

        private string _did;

        private System.Nullable<bool> _sfd;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string did
        {
            get
            {
                return this._did;
            }
            set
            {
                if (((this._did == null)
                            || (_did.Equals(value) != true)))
                {
                    this._did = value;
                    this.OnPropertyChanged("did");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool sfd
        {
            get
            {
                if (this._sfd.HasValue)
                {
                    return this._sfd.Value;
                }
                else
                {
                    return default(bool);
                }
            }
            set
            {
                if ((_sfd.Equals(value) != true))
                {
                    this._sfd = value;
                    this.OnPropertyChanged("sfd");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool sfdSpecified
        {
            get
            {
                return this._sfd.HasValue;
            }
            set
            {
                if (value == false)
                {
                    this._sfd = null;
                }
            }
        }
    }
}
