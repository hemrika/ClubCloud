using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Mail
{
    [MessageContract(WrapperName = "SendMsgRequest", WrapperNamespace = "urn:zimbraMail")]
    public partial class SendMsgRequest : ZimbraMessage
    {

        private msgToSend _m;

        private System.Nullable<bool> _needCalendarSentByFixup;

        private System.Nullable<bool> _isCalendarForward;

        private System.Nullable<bool> _noSave;

        private string _suid;

        public SendMsgRequest()
        {
            this._m = new msgToSend();
        }

        [System.Xml.Serialization.XmlElementAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public msgToSend m
        {
            get
            {
                return this._m;
            }
            set
            {
                if (((this._m == null)
                            || (_m.Equals(value) != true)))
                {
                    this._m = value;
                    this.OnPropertyChanged("m");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool needCalendarSentByFixup
        {
            get
            {
                if (this._needCalendarSentByFixup.HasValue)
                {
                    return this._needCalendarSentByFixup.Value;
                }
                else
                {
                    return default(bool);
                }
            }
            set
            {
                if ((_needCalendarSentByFixup.Equals(value) != true))
                {
                    this._needCalendarSentByFixup = value;
                    this.OnPropertyChanged("needCalendarSentByFixup");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool needCalendarSentByFixupSpecified
        {
            get
            {
                return this._needCalendarSentByFixup.HasValue;
            }
            set
            {
                if (value == false)
                {
                    this._needCalendarSentByFixup = null;
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool isCalendarForward
        {
            get
            {
                if (this._isCalendarForward.HasValue)
                {
                    return this._isCalendarForward.Value;
                }
                else
                {
                    return default(bool);
                }
            }
            set
            {
                if ((_isCalendarForward.Equals(value) != true))
                {
                    this._isCalendarForward = value;
                    this.OnPropertyChanged("isCalendarForward");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool isCalendarForwardSpecified
        {
            get
            {
                return this._isCalendarForward.HasValue;
            }
            set
            {
                if (value == false)
                {
                    this._isCalendarForward = null;
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool noSave
        {
            get
            {
                if (this._noSave.HasValue)
                {
                    return this._noSave.Value;
                }
                else
                {
                    return default(bool);
                }
            }
            set
            {
                if ((_noSave.Equals(value) != true))
                {
                    this._noSave = value;
                    this.OnPropertyChanged("noSave");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool noSaveSpecified
        {
            get
            {
                return this._noSave.HasValue;
            }
            set
            {
                if (value == false)
                {
                    this._noSave = null;
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string suid
        {
            get
            {
                return this._suid;
            }
            set
            {
                if (((this._suid == null)
                            || (_suid.Equals(value) != true)))
                {
                    this._suid = value;
                    this.OnPropertyChanged("suid");
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
