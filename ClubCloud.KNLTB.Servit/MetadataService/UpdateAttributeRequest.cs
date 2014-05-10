using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.MetadataService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class UpdateAttributeRequest : MetadataServiceRequest
	{
		private AttributeMetadata attributeField;
		private string entityNameField;
		private bool mergeLabelsField;
		public AttributeMetadata Attribute
		{
			get
			{
				return this.attributeField;
			}
			set
			{
				this.attributeField = value;
			}
		}
		public string EntityName
		{
			get
			{
				return this.entityNameField;
			}
			set
			{
				this.entityNameField = value;
			}
		}
		public bool MergeLabels
		{
			get
			{
				return this.mergeLabelsField;
			}
			set
			{
				this.mergeLabelsField = value;
			}
		}
	}
}
