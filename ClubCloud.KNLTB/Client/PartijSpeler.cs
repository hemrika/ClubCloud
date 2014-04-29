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
    public partial class PartijSpeler : Speler
    {

        private string bondsnummerField;

        private string geslachtField;

        private string achternaamField;

        private string voorlettersField;

        private string roepnaamField;

        private string tussenvoegselsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string Bondsnummer
        {
            get
            {
                return this.bondsnummerField;
            }
            set
            {
                this.bondsnummerField = value;
                this.RaisePropertyChanged("Bondsnummer");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string Achternaam
        {
            get
            {
                return this.achternaamField;
            }
            set
            {
                this.achternaamField = value;
                this.RaisePropertyChanged("Achternaam");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string Voorletters
        {
            get
            {
                return this.voorlettersField;
            }
            set
            {
                this.voorlettersField = value;
                this.RaisePropertyChanged("Voorletters");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string Roepnaam
        {
            get
            {
                return this.roepnaamField;
            }
            set
            {
                this.roepnaamField = value;
                this.RaisePropertyChanged("Roepnaam");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string Tussenvoegsels
        {
            get
            {
                return this.tussenvoegselsField;
            }
            set
            {
                this.tussenvoegselsField = value;
                this.RaisePropertyChanged("Tussenvoegsels");
            }
        }
    }
}
