using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.KNLTB.Client
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PartijResult))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Partij : object, System.ComponentModel.INotifyPropertyChanged
    {

        private int partijIdField;

        private int wedstrijdIdField;

        private int toernooiIdField;

        private System.DateTime speelDatumField;

        private string uitslagThuisField;

        private string geslachtField;

        private bool isEnkelField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public int PartijId
        {
            get
            {
                return this.partijIdField;
            }
            set
            {
                this.partijIdField = value;
                this.RaisePropertyChanged("PartijId");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public int WedstrijdId
        {
            get
            {
                return this.wedstrijdIdField;
            }
            set
            {
                this.wedstrijdIdField = value;
                this.RaisePropertyChanged("WedstrijdId");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public int ToernooiId
        {
            get
            {
                return this.toernooiIdField;
            }
            set
            {
                this.toernooiIdField = value;
                this.RaisePropertyChanged("ToernooiId");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public System.DateTime SpeelDatum
        {
            get
            {
                return this.speelDatumField;
            }
            set
            {
                this.speelDatumField = value;
                this.RaisePropertyChanged("SpeelDatum");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string UitslagThuis
        {
            get
            {
                return this.uitslagThuisField;
            }
            set
            {
                this.uitslagThuisField = value;
                this.RaisePropertyChanged("UitslagThuis");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string Geslacht
        {
            get
            {
                return this.geslachtField;
            }
            set
            {
                this.geslachtField = value;
                this.RaisePropertyChanged("Geslacht");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public bool IsEnkel
        {
            get
            {
                return this.isEnkelField;
            }
            set
            {
                this.isEnkelField = value;
                this.RaisePropertyChanged("IsEnkel");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
