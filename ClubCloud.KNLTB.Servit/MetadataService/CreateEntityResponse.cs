using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.MetadataService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class CreateEntityResponse : MetadataServiceResponse
	{
		private Key entityIdField;
		private Key attributeIdField;
		public Key EntityId
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
		public Key AttributeId
		{
			get
			{
				return this.attributeIdField;
			}
			set
			{
				this.attributeIdField = value;
			}
		}
	}
}
