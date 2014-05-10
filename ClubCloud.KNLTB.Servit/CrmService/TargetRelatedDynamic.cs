using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetRelatedDynamic : TargetRelated
	{
		private string entity1NameField;
		private Guid entity1IdField;
		private string entity2NameField;
		private Guid entity2IdField;
		public string Entity1Name
		{
			get
			{
				return this.entity1NameField;
			}
			set
			{
				this.entity1NameField = value;
			}
		}
		public Guid Entity1Id
		{
			get
			{
				return this.entity1IdField;
			}
			set
			{
				this.entity1IdField = value;
			}
		}
		public string Entity2Name
		{
			get
			{
				return this.entity2NameField;
			}
			set
			{
				this.entity2NameField = value;
			}
		}
		public Guid Entity2Id
		{
			get
			{
				return this.entity2IdField;
			}
			set
			{
				this.entity2IdField = value;
			}
		}
	}
}
