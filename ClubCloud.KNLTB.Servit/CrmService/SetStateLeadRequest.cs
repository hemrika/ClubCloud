using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateLeadRequest : Request
	{
		private Guid entityIdField;
		private LeadState leadStateField;
		private int leadStatusField;
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
		public LeadState LeadState
		{
			get
			{
				return this.leadStateField;
			}
			set
			{
				this.leadStateField = value;
			}
		}
		public int LeadStatus
		{
			get
			{
				return this.leadStatusField;
			}
			set
			{
				this.leadStatusField = value;
			}
		}
	}
}
