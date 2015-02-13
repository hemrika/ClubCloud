using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ClubCloud.KNLTB.DuplicaatPersonen
{
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [GeneratedCode("System.Xml", "4.0.30319.34230")]
    [Serializable]
    [XmlType(Namespace = "http://knltb.nl/services")]
    public class OrganizationHeader : INotifyPropertyChanged
    {
        private string organizationNameField;

        private string serverUrlField;

        private XmlAttribute[] anyAttrField;

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttr
        {
            get
            {
                return this.anyAttrField;
            }
            set
            {
                this.anyAttrField = value;
                this.RaisePropertyChanged("AnyAttr");
            }
        }

        [XmlElement(Order = 0)]
        public string OrganizationName
        {
            get
            {
                return this.organizationNameField;
            }
            set
            {
                this.organizationNameField = value;
                this.RaisePropertyChanged("OrganizationName");
            }
        }

        [XmlElement(Order = 1)]
        public string ServerUrl
        {
            get
            {
                return this.serverUrlField;
            }
            set
            {
                this.serverUrlField = value;
                this.RaisePropertyChanged("ServerUrl");
            }
        }

        public OrganizationHeader()
        {
        }

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
