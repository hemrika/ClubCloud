using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Mail
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(msgToSend))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(saveDraftMsg))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:zimbraMail")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "msg", Namespace = "urn:zimbraMail")]
    public partial class msg : System.ComponentModel.INotifyPropertyChanged
    {

        private string _content;

        private List<header> _header;

        private mimePartInfo _mp;

        private attachmentsInfo _attach;

        private invitationInfo _inv;

        private List<emailAddrInfo> _e;

        private List<calTZInfo> _tz;

        private string _fr;

        private List<System.Xml.XmlElement> _any;

        private string _aid;

        private string _origid;

        private string _rt;

        private string _idnt;

        private string _su;

        private string _irt;

        private string _l;

        private string _f;

        public msg()
        {
            this._any = new List<System.Xml.XmlElement>();
            this._tz = new List<calTZInfo>();
            this._e = new List<emailAddrInfo>();
            this._inv = new invitationInfo();
            this._attach = new attachmentsInfo();
            this._mp = new mimePartInfo();
            this._header = new List<header>();
        }

        [System.Xml.Serialization.XmlElementAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string content
        {
            get
            {
                return this._content;
            }
            set
            {
                if (((this._content == null)
                            || (_content.Equals(value) != true)))
                {
                    this._content = value;
                    this.OnPropertyChanged("content");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("header")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<header> header
        {
            get
            {
                return this._header;
            }
            set
            {
                if (((this._header == null)
                            || (_header.Equals(value) != true)))
                {
                    this._header = value;
                    this.OnPropertyChanged("header");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public mimePartInfo mp
        {
            get
            {
                return this._mp;
            }
            set
            {
                if (((this._mp == null)
                            || (_mp.Equals(value) != true)))
                {
                    this._mp = value;
                    this.OnPropertyChanged("mp");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public attachmentsInfo attach
        {
            get
            {
                return this._attach;
            }
            set
            {
                if (((this._attach == null)
                            || (_attach.Equals(value) != true)))
                {
                    this._attach = value;
                    this.OnPropertyChanged("attach");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public invitationInfo inv
        {
            get
            {
                return this._inv;
            }
            set
            {
                if (((this._inv == null)
                            || (_inv.Equals(value) != true)))
                {
                    this._inv = value;
                    this.OnPropertyChanged("inv");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("e")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<emailAddrInfo> e
        {
            get
            {
                return this._e;
            }
            set
            {
                if (((this._e == null)
                            || (_e.Equals(value) != true)))
                {
                    this._e = value;
                    this.OnPropertyChanged("e");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("tz")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<calTZInfo> tz
        {
            get
            {
                return this._tz;
            }
            set
            {
                if (((this._tz == null)
                            || (_tz.Equals(value) != true)))
                {
                    this._tz = value;
                    this.OnPropertyChanged("tz");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string fr
        {
            get
            {
                return this._fr;
            }
            set
            {
                if (((this._fr == null)
                            || (_fr.Equals(value) != true)))
                {
                    this._fr = value;
                    this.OnPropertyChanged("fr");
                }
            }
        }

        [System.Xml.Serialization.XmlAnyElementAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<System.Xml.XmlElement> Any
        {
            get
            {
                return this._any;
            }
            set
            {
                if (((this._any == null)
                            || (_any.Equals(value) != true)))
                {
                    this._any = value;
                    this.OnPropertyChanged("Any");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string aid
        {
            get
            {
                return this._aid;
            }
            set
            {
                if (((this._aid == null)
                            || (_aid.Equals(value) != true)))
                {
                    this._aid = value;
                    this.OnPropertyChanged("aid");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string origid
        {
            get
            {
                return this._origid;
            }
            set
            {
                if (((this._origid == null)
                            || (_origid.Equals(value) != true)))
                {
                    this._origid = value;
                    this.OnPropertyChanged("origid");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string rt
        {
            get
            {
                return this._rt;
            }
            set
            {
                if (((this._rt == null)
                            || (_rt.Equals(value) != true)))
                {
                    this._rt = value;
                    this.OnPropertyChanged("rt");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string idnt
        {
            get
            {
                return this._idnt;
            }
            set
            {
                if (((this._idnt == null)
                            || (_idnt.Equals(value) != true)))
                {
                    this._idnt = value;
                    this.OnPropertyChanged("idnt");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string su
        {
            get
            {
                return this._su;
            }
            set
            {
                if (((this._su == null)
                            || (_su.Equals(value) != true)))
                {
                    this._su = value;
                    this.OnPropertyChanged("su");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string irt
        {
            get
            {
                return this._irt;
            }
            set
            {
                if (((this._irt == null)
                            || (_irt.Equals(value) != true)))
                {
                    this._irt = value;
                    this.OnPropertyChanged("irt");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string l
        {
            get
            {
                return this._l;
            }
            set
            {
                if (((this._l == null)
                            || (_l.Equals(value) != true)))
                {
                    this._l = value;
                    this.OnPropertyChanged("l");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string f
        {
            get
            {
                return this._f;
            }
            set
            {
                if (((this._f == null)
                            || (_f.Equals(value) != true)))
                {
                    this._f = value;
                    this.OnPropertyChanged("f");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
