using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateContactRequest : Request
	{
		private Guid entityIdField;
		private ContactState contactStateField;
		private int contactStatusField;
		public Guid EntityId
		{
			get
			{
				return this.entityIdField;
			}
			set
			{
				this.entityIdField = value;
			}
		}
		public ContactState ContactState
		{
			get
			{
				return this.contactStateField;
			}
			set
			{
				this.contactStateField = value;
			}
		}
		public int ContactStatus
		{
			get
			{
				return this.contactStatusField;
			}
			set
			{
				this.contactStatusField = value;
			}
		}
	}
}
