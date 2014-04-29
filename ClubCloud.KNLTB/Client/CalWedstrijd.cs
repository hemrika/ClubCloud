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
    public partial class CalWedstrijd : Wedstrijd
    {

        private string teamThuisField;

        private string teamUitField;

        private string baanSoortField;

        private string aanvoerderField;

        private string aanvoerderTelefoonField;

        private string plaatsField;

        private string straatField;

        private string huisnummerField;

        private string postcodeField;

        private string competitieField;

        private string klasseOmschrijvingField;

        private string roosterDagField;

        private string competitieSoortField;

        private bool followHomeTeamField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string TeamThuis
        {
            get
            {
                return this.teamThuisField;
            }
            set
            {
                this.teamThuisField = value;
                this.RaisePropertyChanged("TeamThuis");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string TeamUit
        {
            get
            {
                return this.teamUitField;
            }
            set
            {
                this.teamUitField = value;
                this.RaisePropertyChanged("TeamUit");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string BaanSoort
        {
            get
            {
                return this.baanSoortField;
            }
            set
            {
                this.baanSoortField = value;
                this.RaisePropertyChanged("BaanSoort");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string Aanvoerder
        {
            get
            {
                return this.aanvoerderField;
            }
            set
            {
                this.aanvoerderField = value;
                this.RaisePropertyChanged("Aanvoerder");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string AanvoerderTelefoon
        {
            get
            {
                return this.aanvoerderTelefoonField;
            }
            set
            {
                this.aanvoerderTelefoonField = value;
                this.RaisePropertyChanged("AanvoerderTelefoon");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string Straat
        {
            get
            {
                return this.straatField;
            }
            set
            {
                this.straatField = value;
                this.RaisePropertyChanged("Straat");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string Huisnummer
        {
            get
            {
                return this.huisnummerField;
            }
            set
            {
                this.huisnummerField = value;
                this.RaisePropertyChanged("Huisnummer");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string Postcode
        {
            get
            {
                return this.postcodeField;
            }
            set
            {
                this.postcodeField = value;
                this.RaisePropertyChanged("Postcode");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string Competitie
        {
            get
            {
                return this.competitieField;
            }
            set
            {
                this.competitieField = value;
                this.RaisePropertyChanged("Competitie");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string KlasseOmschrijving
        {
            get
            {
                return this.klasseOmschrijvingField;
            }
            set
            {
                this.klasseOmschrijvingField = value;
                this.RaisePropertyChanged("KlasseOmschrijving");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string RoosterDag
        {
            get
            {
                return this.roosterDagField;
            }
            set
            {
                this.roosterDagField = value;
                this.RaisePropertyChanged("RoosterDag");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public string CompetitieSoort
        {
            get
            {
                return this.competitieSoortField;
            }
            set
            {
                this.competitieSoortField = value;
                this.RaisePropertyChanged("CompetitieSoort");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public bool FollowHomeTeam
        {
            get
            {
                return this.followHomeTeamField;
            }
            set
            {
                this.followHomeTeamField = value;
                this.RaisePropertyChanged("FollowHomeTeam");
            }
        }
    }
}
