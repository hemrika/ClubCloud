using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Global
{
    public partial class versionInfo : System.ComponentModel.INotifyPropertyChanged
    {

        private string _type;

        private string _version;

        private string _release;

        private string _buildDate;

        private string _host;

        private string _majorversion;

        private string _minorversion;

        private string _microversion;

        private string _platform;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string type
        {
            get
            {
                return this._type;
            }
            set
            {
                if (((this._type == null)
                            || (_type.Equals(value) != true)))
                {
                    this._type = value;
                    this.OnPropertyChanged("type");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string version
        {
            get
            {
                return this._version;
            }
            set
            {
                if (((this._version == null)
                            || (_version.Equals(value) != true)))
                {
                    this._version = value;
                    this.OnPropertyChanged("version");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string release
        {
            get
            {
                return this._release;
            }
            set
            {
                if (((this._release == null)
                            || (_release.Equals(value) != true)))
                {
                    this._release = value;
                    this.OnPropertyChanged("release");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string buildDate
        {
            get
            {
                return this._buildDate;
            }
            set
            {
                if (((this._buildDate == null)
                            || (_buildDate.Equals(value) != true)))
                {
                    this._buildDate = value;
                    this.OnPropertyChanged("buildDate");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string host
        {
            get
            {
                return this._host;
            }
            set
            {
                if (((this._host == null)
                            || (_host.Equals(value) != true)))
                {
                    this._host = value;
                    this.OnPropertyChanged("host");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string majorversion
        {
            get
            {
                return this._majorversion;
            }
            set
            {
                if (((this._majorversion == null)
                            || (_majorversion.Equals(value) != true)))
                {
                    this._majorversion = value;
                    this.OnPropertyChanged("majorversion");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string minorversion
        {
            get
            {
                return this._minorversion;
            }
            set
            {
                if (((this._minorversion == null)
                            || (_minorversion.Equals(value) != true)))
                {
                    this._minorversion = value;
                    this.OnPropertyChanged("minorversion");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string microversion
        {
            get
            {
                return this._microversion;
            }
            set
            {
                if (((this._microversion == null)
                            || (_microversion.Equals(value) != true)))
                {
                    this._microversion = value;
                    this.OnPropertyChanged("microversion");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string platform
        {
            get
            {
                return this._platform;
            }
            set
            {
                if (((this._platform == null)
                            || (_platform.Equals(value) != true)))
                {
                    this._platform = value;
                    this.OnPropertyChanged("platform");
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

/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Global
{
    public partial class versionInfo : System.ComponentModel.INotifyPropertyChanged
    {

        private string _version;

        private string _release;

        private string _buildDate;

        private string _host;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string version
        {
            get
            {
                return this._version;
            }
            set
            {
                if (((this._version == null)
                            || (_version.Equals(value) != true)))
                {
                    this._version = value;
                    this.OnPropertyChanged("version");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string release
        {
            get
            {
                return this._release;
            }
            set
            {
                if (((this._release == null)
                            || (_release.Equals(value) != true)))
                {
                    this._release = value;
                    this.OnPropertyChanged("release");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string buildDate
        {
            get
            {
                return this._buildDate;
            }
            set
            {
                if (((this._buildDate == null)
                            || (_buildDate.Equals(value) != true)))
                {
                    this._buildDate = value;
                    this.OnPropertyChanged("buildDate");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string host
        {
            get
            {
                return this._host;
            }
            set
            {
                if (((this._host == null)
                            || (_host.Equals(value) != true)))
                {
                    this._host = value;
                    this.OnPropertyChanged("host");
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
*/