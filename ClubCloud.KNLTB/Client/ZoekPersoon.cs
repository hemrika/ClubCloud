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
    public partial class ZoekPersoon : Persoon
    {

        private string organisatieNaamField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string OrganisatieNaam
        {
            get
            {
                return this.organisatieNaamField;
            }
            set
            {
                this.organisatieNaamField = value;
                this.RaisePropertyChanged("OrganisatieNaam");
            }
        }
    }
}
