using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.MetadataService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlInclude(typeof(ManyToManyMetadata)), XmlInclude(typeof(OneToManyMetadata)), XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class RelationshipMetadata : CrmMetadata
	{
		private string schemaNameField;
		private CrmBoolean isCustomRelationshipField;
		private EntityRelationshipType relationshipTypeField;
		private CrmBoolean isValidForAdvancedFindField;
		private SecurityTypes securityTypeField;
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
		public CrmBoolean IsCustomRelationship
		{
			get
			{
				return this.isCustomRelationshipField;
			}
			set
			{
				this.isCustomRelationshipField = value;
			}
		}
		public EntityRelationshipType RelationshipType
		{
			get
			{
				return this.relationshipTypeField;
			}
			set
			{
				this.relationshipTypeField = value;
			}
		}
		public CrmBoolean IsValidForAdvancedFind
		{
			get
			{
				return this.isValidForAdvancedFindField;
			}
			set
			{
				this.isValidForAdvancedFindField = value;
			}
		}
		public SecurityTypes SecurityType
		{
			get
			{
				return this.securityTypeField;
			}
			set
			{
				this.securityTypeField = value;
			}
		}
	}
}
