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
		[XmlElement(Order = 0)]
		public Moniker Moniker1
		{
			get
			{
				return this.moniker1Field;
			}
			set
			{
				this.moniker1Field = value;
				base.RaisePropertyChanged("Moniker1");
			}
		}
		[XmlElement(Order = 1)]
		public Moniker Moniker2
		{
			get
			{
				return this.moniker2Field;
			}
			set
			{
				this.moniker2Field = value;
				base.RaisePropertyChanged("Moniker2");
			}
		}
		[XmlElement(Order = 2)]
		public string RelationshipName
		{
			get
			{
				return this.relationshipNameField;
			}
			set
			{
				this.relationshipNameField = value;
				base.RaisePropertyChanged("RelationshipName");
			}
		}
	}
}
