using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.KNLTB.Client
{
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class PartijResult : Partij
    {

        private string omschrijvingField;

        private string wedstrijdField;

        private Set[] setsField;

        private PartijSpeler[] thuisSpelersField;

        private PartijSpeler[] uitSpelersField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string Omschrijving
        {
            get
            {
                return this.omschrijvingField;
            }
            set
            {
                this.omschrijvingField = value;
                this.RaisePropertyChanged("Omschrijving");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Wedstrijd
        {
            get
            {
                return this.wedstrijdField;
            }
            set
            {
                this.wedstrijdField = value;
                this.RaisePropertyChanged("Wedstrijd");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 2)]
        public Set[] Sets
        {
            get
            {
                return this.setsField;
            }
            set
            {
                this.setsField = value;
                this.RaisePropertyChanged("Sets");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 3)]
        public PartijSpeler[] ThuisSpelers
        {
            get
            {
                return this.thuisSpelersField;
            }
            set
            {
                this.thuisSpelersField = value;
                this.RaisePropertyChanged("ThuisSpelers");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 4)]
        public PartijSpeler[] UitSpelers
        {
            get
            {
                return this.uitSpelersField;
            }
            set
            {
                this.uitSpelersField = value;
                this.RaisePropertyChanged("UitSpelers");
            }
        }
    }
}
