using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.KNLTB.Client
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PartijSpeler))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Speler : object, System.ComponentModel.INotifyPropertyChanged
    {

        private bool speeltThuisField;

        private string resultaatField;

        private string actueleRatingField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public bool SpeeltThuis
        {
            get
            {
                return this.speeltThuisField;
            }
            set
            {
                this.speeltThuisField = value;
                this.RaisePropertyChanged("SpeeltThuis");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Resultaat
        {
            get
            {
                return this.resultaatField;
            }
            set
            {
                this.resultaatField = value;
                this.RaisePropertyChanged("Resultaat");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string ActueleRating
        {
            get
            {
                return this.actueleRatingField;
            }
            set
            {
                this.actueleRatingField = value;
                this.RaisePropertyChanged("ActueleRating");
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
