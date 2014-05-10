using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class DisassociateEntitiesRequest : Request
	{
		private Moniker moniker1Field;
		private Moniker moniker2Field;
		private string relationshipNameField;
		public Moniker Moniker1
		{
			get
			{
				return this.moniker1Field;
			}
			set
			{
				this.moniker1Field = value;
			}
		}
		public Moniker Moniker2
		{
			get
			{
				return this.moniker2Field;
			}
			set
			{
				this.moniker2Field = value;
			}
		}
		public string RelationshipName
		{
			get
			{
				return this.relationshipNameField;
			}
			set
			{
				this.relationshipNameField = value;
			}
		}
	}
}
