using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ClubCloud.KNLTB.Servit.CRM.Core
{
    [XmlType(Namespace = "http://schemas.microsoft.com/crm/2006/WebServices")]
    [Serializable]
    public class CrmDateTime
    {
        private bool isNullField;
        private bool isNullFieldSpecified;
        private string dateField;
        private string timeField;
        private string valueField;
        [XmlAttribute]
        public bool IsNull
        {
            get
            {
                return this.isNullField;
            }
            set
            {
                this.isNullField = value;
            }
        }
        [XmlIgnore]
        public bool IsNullSpecified
        {
            get
            {
                return this.isNullFieldSpecified;
            }
            set
            {
                this.isNullFieldSpecified = value;
            }
        }
        [XmlAttribute]
        public string date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }
        [XmlAttribute]
        public string time
        {
            get
            {
                return this.timeField;
            }
            set
            {
                this.timeField = value;
            }
        }
        [XmlText]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
}
