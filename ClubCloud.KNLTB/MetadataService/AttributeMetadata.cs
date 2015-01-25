using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.MetadataService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlInclude(typeof(MoneyAttributeMetadata)), XmlInclude(typeof(FloatAttributeMetadata)), XmlInclude(typeof(DateTimeAttributeMetadata)), XmlInclude(typeof(DecimalAttributeMetadata)), XmlInclude(typeof(MemoAttributeMetadata)), XmlInclude(typeof(StatusAttributeMetadata)), XmlInclude(typeof(PicklistAttributeMetadata)), XmlInclude(typeof(StringAttributeMetadata)), XmlInclude(typeof(BooleanAttributeMetadata)), XmlInclude(typeof(LookupAttributeMetadata)), XmlInclude(typeof(StateAttributeMetadata)), XmlInclude(typeof(IntegerAttributeMetadata)), XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class AttributeMetadata : CrmMetadata
	{
		private string schemaNameField;
		private string logicalNameField;
		private string entityLogicalNameField;
		private CrmAttributeType attributeTypeField;
		private CrmLabel displayNameField;
		private CrmLabel descriptionField;
		private CrmBoolean isCustomFieldField;
		private CrmAttributeRequiredLevel requiredLevelField;
		private object defaultValueField;
		private CrmBoolean validForCreateField;
		private CrmBoolean validForReadField;
		private CrmBoolean validForUpdateField;
		private CrmDisplayMasks displayMaskField;
		private string aggregateOfField;
		private string attributeOfField;
		private string yomiOfField;
		private string calculationOfField;
		public string SchemaName
		{
			get
			{
				return this.schemaNameField;
			}
			set
			{
				this.schemaNameField = value;
			}
		}
		public string LogicalName
		{
			get
			{
				return this.logicalNameField;
			}
			set
			{
				this.logicalNameField = value;
			}
		}
		public string EntityLogicalName
		{
			get
			{
				return this.entityLogicalNameField;
			}
			set
			{
				this.entityLogicalNameField = value;
			}
		}
		public CrmAttributeType AttributeType
		{
			get
			{
				return this.attributeTypeField;
			}
			set
			{
				this.attributeTypeField = value;
			}
		}
		public CrmLabel DisplayName
		{
			get
			{
				return this.displayNameField;
			}
			set
			{
				this.displayNameField = value;
			}
		}
		public CrmLabel Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
			}
		}
		public CrmBoolean IsCustomField
		{
			get
			{
				return this.isCustomFieldField;
			}
			set
			{
				this.isCustomFieldField = value;
			}
		}
		public CrmAttributeRequiredLevel RequiredLevel
		{
			get
			{
				return this.requiredLevelField;
			}
			set
			{
				this.requiredLevelField = value;
			}
		}
		public object DefaultValue
		{
			get
			{
				return this.defaultValueField;
			}
			set
			{
				this.defaultValueField = value;
			}
		}
		public CrmBoolean ValidForCreate
		{
			get
			{
				return this.validForCreateField;
			}
			set
			{
				this.validForCreateField = value;
			}
		}
		public CrmBoolean ValidForRead
		{
			get
			{
				return this.validForReadField;
			}
			set
			{
				this.validForReadField = value;
			}
		}
		public CrmBoolean ValidForUpdate
		{
			get
			{
				return this.validForUpdateField;
			}
			set
			{
				this.validForUpdateField = value;
			}
		}
		public CrmDisplayMasks DisplayMask
		{
			get
			{
				return this.displayMaskField;
			}
			set
			{
				this.displayMaskField = value;
			}
		}
		public string AggregateOf
		{
			get
			{
				return this.aggregateOfField;
			}
			set
			{
				this.aggregateOfField = value;
			}
		}
		public string AttributeOf
		{
			get
			{
				return this.attributeOfField;
			}
			set
			{
				this.attributeOfField = value;
			}
		}
		public string YomiOf
		{
			get
			{
				return this.yomiOfField;
			}
			set
			{
				this.yomiOfField = value;
			}
		}
		public string CalculationOf
		{
			get
			{
				return this.calculationOfField;
			}
			set
			{
				this.calculationOfField = value;
			}
		}
	}
}
