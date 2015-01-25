using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.MetadataService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class CreateOneToManyRequest : MetadataServiceRequest
	{
		private OneToManyMetadata oneToManyRelationshipField;
		private LookupAttributeMetadata lookupField;
		public OneToManyMetadata OneToManyRelationship
		{
			get
			{
				return this.oneToManyRelationshipField;
			}
			set
			{
				this.oneToManyRelationshipField = value;
			}
		}
		public LookupAttributeMetadata Lookup
		{
			get
			{
				return this.lookupField;
			}
			set
			{
				this.lookupField = value;
			}
		}
	}
}
