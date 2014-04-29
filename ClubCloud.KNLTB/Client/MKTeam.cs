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
    public partial class MKTeam : Team
    {

        private string competitieField;

        private string klasseOmschrijvingField;

        private string roosterDagField;

        private string competitieSoortField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
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
    }
}
