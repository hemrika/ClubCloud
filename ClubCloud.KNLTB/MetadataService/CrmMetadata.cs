using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.MetadataService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlInclude(typeof(RelationshipMetadata)), XmlInclude(typeof(FloatAttributeMetadata)), XmlInclude(typeof(StateAttributeMetadata)), XmlInclude(typeof(EntityMetadata)), XmlInclude(typeof(ManyToManyMetadata)), XmlInclude(typeof(OneToManyMetadata)), XmlInclude(typeof(IntegerAttributeMetadata)), XmlInclude(typeof(MoneyAttributeMetadata)), XmlInclude(typeof(DecimalAttributeMetadata)), XmlInclude(typeof(AttributeMetadata)), XmlInclude(typeof(DateTimeAttributeMetadata)), XmlInclude(typeof(MemoAttributeMetadata)), XmlInclude(typeof(StatusAttributeMetadata)), XmlInclude(typeof(PicklistAttributeMetadata)), XmlInclude(typeof(StringAttributeMetadata)), XmlInclude(typeof(BooleanAttributeMetadata)), XmlInclude(typeof(LookupAttributeMetadata)), XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public abstract class CrmMetadata
	{
		private Key metadataIdField;
		public Key MetadataId
		{
			get
			{
				return this.metadataIdField;
			}
			set
			{
				this.metadataIdField = value;
			}
		}
	}
}
