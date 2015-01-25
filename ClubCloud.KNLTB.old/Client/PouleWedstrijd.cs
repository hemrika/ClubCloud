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
    public partial class PouleWedstrijd : Wedstrijd
    {

        private string teamThuisField;

        private string teamUitField;

        private string baanSoortField;

        private int dagNrField;

        private int uitslagThuisField;

        private int uitslagUitField;

        private int statusField;

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
        public int DagNr
        {
            get
            {
                return this.dagNrField;
            }
            set
            {
                this.dagNrField = value;
                this.RaisePropertyChanged("DagNr");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public int UitslagThuis
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
        public int UitslagUit
        {
            get
            {
                return this.uitslagUitField;
            }
            set
            {
                this.uitslagUitField = value;
                this.RaisePropertyChanged("UitslagUit");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public int Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
                this.RaisePropertyChanged("Status");
            }
        }
    }
}
