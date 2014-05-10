using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.MetadataService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class CreateManyToManyResponse : MetadataServiceResponse
	{
		private Key manyToManyRelationshipIdField;
		public Key ManyToManyRelationshipId
		{
			get
			{
				return this.manyToManyRelationshipIdField;
			}
			set
			{
				this.manyToManyRelationshipIdField = value;
			}
		}
	}
}
