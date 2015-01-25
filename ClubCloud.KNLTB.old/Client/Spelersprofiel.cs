using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.KNLTB.Client
{
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Spelersprofiel : object, System.ComponentModel.INotifyPropertyChanged
    {

        private int persoonIdField;

        private string bondsnummerField;

        private string spelersnaamField;

        private string spelersgeslachtField;

        private string speelsterkteEnkelField;

        private string speelsterkteDubbelField;

        private string ratingEnkelField;

        private string ratingDubbelField;

        private string eindejaarsratingEnkelField;

        private string eindejaarsratingDubbelField;

        private string verenigingField;

        private string verenigingsNummerField;

        private string verenigingsPlaatsField;

        private System.DateTime geboorteDatumField;

        private string juniorSeniorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public int PersoonId
        {
            get
            {
                return this.persoonIdField;
            }
            set
            {
                this.persoonIdField = value;
                this.RaisePropertyChanged("PersoonId");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string Spelersnaam
        {
            get
            {
                return this.spelersnaamField;
            }
            set
            {
                this.spelersnaamField = value;
                this.RaisePropertyChanged("Spelersnaam");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string Spelersgeslacht
        {
            get
            {
                return this.spelersgeslachtField;
            }
            set
            {
                this.spelersgeslachtField = value;
                this.RaisePropertyChanged("Spelersgeslacht");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string SpeelsterkteEnkel
        {
            get
            {
                return this.speelsterkteEnkelField;
            }
            set
            {
                this.speelsterkteEnkelField = value;
                this.RaisePropertyChanged("SpeelsterkteEnkel");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string SpeelsterkteDubbel
        {
            get
            {
                return this.speelsterkteDubbelField;
            }
            set
            {
                this.speelsterkteDubbelField = value;
                this.RaisePropertyChanged("SpeelsterkteDubbel");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string RatingEnkel
        {
            get
            {
                return this.ratingEnkelField;
            }
            set
            {
                this.ratingEnkelField = value;
                this.RaisePropertyChanged("RatingEnkel");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string RatingDubbel
        {
            get
            {
                return this.ratingDubbelField;
            }
            set
            {
                this.ratingDubbelField = value;
                this.RaisePropertyChanged("RatingDubbel");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string EindejaarsratingEnkel
        {
            get
            {
                return this.eindejaarsratingEnkelField;
            }
            set
            {
                this.eindejaarsratingEnkelField = value;
                this.RaisePropertyChanged("EindejaarsratingEnkel");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string EindejaarsratingDubbel
        {
            get
            {
                return this.eindejaarsratingDubbelField;
            }
            set
            {
                this.eindejaarsratingDubbelField = value;
                this.RaisePropertyChanged("EindejaarsratingDubbel");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string Vereniging
        {
            get
            {
                return this.verenigingField;
            }
            set
            {
                this.verenigingField = value;
                this.RaisePropertyChanged("Vereniging");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string VerenigingsNummer
        {
            get
            {
                return this.verenigingsNummerField;
            }
            set
            {
                this.verenigingsNummerField = value;
                this.RaisePropertyChanged("VerenigingsNummer");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public string VerenigingsPlaats
        {
            get
            {
                return this.verenigingsPlaatsField;
            }
            set
            {
                this.verenigingsPlaatsField = value;
                this.RaisePropertyChanged("VerenigingsPlaats");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public System.DateTime GeboorteDatum
        {
            get
            {
                return this.geboorteDatumField;
            }
            set
            {
                this.geboorteDatumField = value;
                this.RaisePropertyChanged("GeboorteDatum");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public string JuniorSenior
        {
            get
            {
                return this.juniorSeniorField;
            }
            set
            {
                this.juniorSeniorField = value;
                this.RaisePropertyChanged("JuniorSenior");
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
