using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlInclude(typeof(PicklistProperty)), XmlInclude(typeof(StringProperty)), XmlInclude(typeof(StatusProperty)), XmlInclude(typeof(StateProperty)), XmlInclude(typeof(UniqueIdentifierProperty)), XmlInclude(typeof(OwnerProperty)), XmlInclude(typeof(LookupProperty)), XmlInclude(typeof(KeyProperty)), XmlInclude(typeof(EntityNameReferenceProperty)), XmlInclude(typeof(DynamicEntityArrayProperty)), XmlInclude(typeof(CustomerProperty)), XmlInclude(typeof(CrmNumberProperty)), XmlInclude(typeof(CrmMoneyProperty)), XmlInclude(typeof(CrmFloatProperty)), XmlInclude(typeof(CrmDecimalProperty)), XmlInclude(typeof(CrmDateTimeProperty)), XmlInclude(typeof(CrmBooleanProperty)), XmlType(Namespace = "http://schemas.microsoft.com/crm/2006/WebServices")]
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
