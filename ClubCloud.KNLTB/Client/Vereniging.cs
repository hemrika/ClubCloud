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
    public partial class Vereniging : object, System.ComponentModel.INotifyPropertyChanged
    {

        private System.Guid idField;

        private string naamField;

        private string verenigingsnummerField;

        private string plaatsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public System.Guid Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
                this.RaisePropertyChanged("Id");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Naam
        {
            get
            {
                return this.naamField;
            }
            set
            {
                this.naamField = value;
                this.RaisePropertyChanged("Naam");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string Verenigingsnummer
        {
            get
            {
                return this.verenigingsnummerField;
            }
            set
            {
                this.verenigingsnummerField = value;
                this.RaisePropertyChanged("Verenigingsnummer");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string Plaats
        {
            get
            {
                return this.plaatsField;
            }
            set
            {
                this.plaatsField = value;
                this.RaisePropertyChanged("Plaats");
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
