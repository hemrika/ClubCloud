using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.KNLTB.Client
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MKTeam))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Team : object, System.ComponentModel.INotifyPropertyChanged
    {

        private System.Guid teamIdField;

        private string naamField;

        private string klasseField;

        private int nummerField;

        private int captainPersoonIdField;

        private int organistatieIdField;

        private int klasseGroepIdField;

        private System.Guid pouleIdField;

        private int piramideIdField;

        private string teamNrInPouleField;

        private int standNummerField;

        private double ploegGemiddeldeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public System.Guid TeamId
        {
            get
            {
                return this.teamIdField;
            }
            set
            {
                this.teamIdField = value;
                this.RaisePropertyChanged("TeamId");
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
        public string Klasse
        {
            get
            {
                return this.klasseField;
            }
            set
            {
                this.klasseField = value;
                this.RaisePropertyChanged("Klasse");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public int Nummer
        {
            get
            {
                return this.nummerField;
            }
            set
            {
                this.nummerField = value;
                this.RaisePropertyChanged("Nummer");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public int CaptainPersoonId
        {
            get
            {
                return this.captainPersoonIdField;
            }
            set
            {
                this.captainPersoonIdField = value;
                this.RaisePropertyChanged("CaptainPersoonId");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public int OrganistatieId
        {
            get
            {
                return this.organistatieIdField;
            }
            set
            {
                this.organistatieIdField = value;
                this.RaisePropertyChanged("OrganistatieId");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public int KlasseGroepId
        {
            get
            {
                return this.klasseGroepIdField;
            }
            set
            {
                this.klasseGroepIdField = value;
                this.RaisePropertyChanged("KlasseGroepId");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public System.Guid PouleId
        {
            get
            {
                return this.pouleIdField;
            }
            set
            {
                this.pouleIdField = value;
                this.RaisePropertyChanged("PouleId");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public int PiramideId
        {
            get
            {
                return this.piramideIdField;
            }
            set
            {
                this.piramideIdField = value;
                this.RaisePropertyChanged("PiramideId");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string TeamNrInPoule
        {
            get
            {
                return this.teamNrInPouleField;
            }
            set
            {
                this.teamNrInPouleField = value;
                this.RaisePropertyChanged("TeamNrInPoule");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public int StandNummer
        {
            get
            {
                return this.standNummerField;
            }
            set
            {
                this.standNummerField = value;
                this.RaisePropertyChanged("StandNummer");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public double PloegGemiddelde
        {
            get
            {
                return this.ploegGemiddeldeField;
            }
            set
            {
                this.ploegGemiddeldeField = value;
                this.RaisePropertyChanged("PloegGemiddelde");
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
