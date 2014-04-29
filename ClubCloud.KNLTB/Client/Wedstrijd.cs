using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.KNLTB.Client
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PouleWedstrijd))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CalWedstrijd))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Wedstrijd : object, System.ComponentModel.INotifyPropertyChanged
    {

        private System.Guid wedstrijdIdField;

        private string codeField;

        private System.DateTime inhaalDatumField;

        private System.DateTime speelDatumField;

        private System.DateTime aanvangsTijdField;

        private System.DateTime aanwezigTijdField;

        private string opmerkingField;

        private string telefoonField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public System.Guid WedstrijdId
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
                this.RaisePropertyChanged("Code");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public System.DateTime InhaalDatum
        {
            get
            {
                return this.inhaalDatumField;
            }
            set
            {
                this.inhaalDatumField = value;
                this.RaisePropertyChanged("InhaalDatum");
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
        public System.DateTime AanvangsTijd
        {
            get
            {
                return this.aanvangsTijdField;
            }
            set
            {
                this.aanvangsTijdField = value;
                this.RaisePropertyChanged("AanvangsTijd");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public System.DateTime AanwezigTijd
        {
            get
            {
                return this.aanwezigTijdField;
            }
            set
            {
                this.aanwezigTijdField = value;
                this.RaisePropertyChanged("AanwezigTijd");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string Opmerking
        {
            get
            {
                return this.opmerkingField;
            }
            set
            {
                this.opmerkingField = value;
                this.RaisePropertyChanged("Opmerking");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string Telefoon
        {
            get
            {
                return this.telefoonField;
            }
            set
            {
                this.telefoonField = value;
                this.RaisePropertyChanged("Telefoon");
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
