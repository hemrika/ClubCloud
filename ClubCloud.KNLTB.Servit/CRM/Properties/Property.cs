using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ClubCloud.KNLTB.Servit.CRM.Properties
{
    [XmlInclude(typeof(CrmBooleanProperty)), XmlInclude(typeof(CrmDateTimeProperty)), XmlInclude(typeof(UniqueIdentifierProperty)), XmlInclude(typeof(StringProperty)), XmlInclude(typeof(StatusProperty)), XmlInclude(typeof(StateProperty)), XmlInclude(typeof(PicklistProperty)), XmlInclude(typeof(OwnerProperty)), XmlInclude(typeof(LookupProperty)), XmlInclude(typeof(KeyProperty)), XmlInclude(typeof(EntityNameReferenceProperty)), XmlInclude(typeof(DynamicEntityArrayProperty)), XmlInclude(typeof(CustomerProperty)), XmlInclude(typeof(CrmNumberProperty)), XmlInclude(typeof(CrmMoneyProperty)), XmlInclude(typeof(CrmFloatProperty)), XmlInclude(typeof(CrmDecimalProperty)), XmlType(Namespace = "http://schemas.microsoft.com/crm/2006/WebServices")]
    [Serializable]
    public abstract class Property
    {
        private string nameField;
        [XmlAttribute]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }
}
