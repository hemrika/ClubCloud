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
    public partial class PouleStanden : object, System.ComponentModel.INotifyPropertyChanged
    {

        private int positieField;

        private Team teamField;

        private int gespeeldField;

        private int winstField;

        private int gelijkField;

        private int verlorenField;

        private int puntenField;

        private int puntenVoorField;

        private int puntenTegenField;

        private bool metRglUitslagField;

        private bool nietKomenOpdagenField;

        private bool nietUitgespeeldField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public int Positie
        {
            get
            {
                return this.positieField;
            }
            set
            {
                this.positieField = value;
                this.RaisePropertyChanged("Positie");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public Team Team
        {
            get
            {
                return this.teamField;
            }
            set
            {
                this.teamField = value;
                this.RaisePropertyChanged("Team");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public int Gespeeld
        {
            get
            {
                return this.gespeeldField;
            }
            set
            {
                this.gespeeldField = value;
                this.RaisePropertyChanged("Gespeeld");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public int Winst
        {
            get
            {
                return this.winstField;
            }
            set
            {
                this.winstField = value;
                this.RaisePropertyChanged("Winst");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public int Gelijk
        {
            get
            {
                return this.gelijkField;
            }
            set
            {
                this.gelijkField = value;
                this.RaisePropertyChanged("Gelijk");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public int Verloren
        {
            get
            {
                return this.verlorenField;
            }
            set
            {
                this.verlorenField = value;
                this.RaisePropertyChanged("Verloren");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public int Punten
        {
            get
            {
                return this.puntenField;
            }
            set
            {
                this.puntenField = value;
                this.RaisePropertyChanged("Punten");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public int PuntenVoor
        {
            get
            {
                return this.puntenVoorField;
            }
            set
            {
                this.puntenVoorField = value;
                this.RaisePropertyChanged("PuntenVoor");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public int PuntenTegen
        {
            get
            {
                return this.puntenTegenField;
            }
            set
            {
                this.puntenTegenField = value;
                this.RaisePropertyChanged("PuntenTegen");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public bool MetRglUitslag
        {
            get
            {
                return this.metRglUitslagField;
            }
            set
            {
                this.metRglUitslagField = value;
                this.RaisePropertyChanged("MetRglUitslag");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public bool NietKomenOpdagen
        {
            get
            {
                return this.nietKomenOpdagenField;
            }
            set
            {
                this.nietKomenOpdagenField = value;
                this.RaisePropertyChanged("NietKomenOpdagen");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public bool NietUitgespeeld
        {
            get
            {
                return this.nietUitgespeeldField;
            }
            set
            {
                this.nietUitgespeeldField = value;
                this.RaisePropertyChanged("NietUitgespeeld");
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
