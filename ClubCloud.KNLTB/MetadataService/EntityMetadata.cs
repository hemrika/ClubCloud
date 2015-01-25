using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.MetadataService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class EntityMetadata : CrmMetadata
	{
		private string schemaNameField;
		private string logicalNameField;
		private CrmNumber objectTypeCodeField;
		private CrmLabel displayNameField;
		private CrmLabel displayCollectionNameField;
		private CrmLabel descriptionField;
		private CrmBoolean isCustomEntityField;
		private CrmBoolean isCustomizableField;
		private CrmBoolean isAvailableOfflineField;
		private CrmBoolean isIntersectField;
		private CrmBoolean canTriggerWorkflowField;
		private CrmNumber workflowSupportField;
		private CrmBoolean duplicateDetectionField;
		private CrmBoolean isMailMergeEnabledField;
		private CrmBoolean isImportableField;
		private CrmBoolean isChildEntityField;
		private string reportViewNameField;
		private string primaryFieldField;
		private string primaryKeyField;
		private CrmOwnershipTypes ownershipTypeField;
		private AttributeMetadata[] attributesField;
		private OneToManyMetadata[] manyToOneRelationshipsField;
		private OneToManyMetadata[] oneToManyRelationshipsField;
		private SecurityPrivilegeMetadata[] privilegesField;
		private ManyToManyMetadata[] manyToManyRelationshipsField;
		private CrmBoolean isActivityField;
		private CrmBoolean isValidForAdvancedFindField;
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
		public CrmNumber ObjectTypeCode
		{
			get
			{
				return this.objectTypeCodeField;
			}
			set
			{
				this.objectTypeCodeField = value;
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
		public CrmLabel DisplayCollectionName
		{
			get
			{
				return this.displayCollectionNameField;
			}
			set
			{
				this.displayCollectionNameField = value;
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
		public CrmBoolean IsCustomEntity
		{
			get
			{
				return this.isCustomEntityField;
			}
			set
			{
				this.isCustomEntityField = value;
			}
		}
		public CrmBoolean IsCustomizable
		{
			get
			{
				return this.isCustomizableField;
			}
			set
			{
				this.isCustomizableField = value;
			}
		}
		public CrmBoolean IsAvailableOffline
		{
			get
			{
				return this.isAvailableOfflineField;
			}
			set
			{
				this.isAvailableOfflineField = value;
			}
		}
		public CrmBoolean IsIntersect
		{
			get
			{
				return this.isIntersectField;
			}
			set
			{
				this.isIntersectField = value;
			}
		}
		public CrmBoolean CanTriggerWorkflow
		{
			get
			{
				return this.canTriggerWorkflowField;
			}
			set
			{
				this.canTriggerWorkflowField = value;
			}
		}
		public CrmNumber WorkflowSupport
		{
			get
			{
				return this.workflowSupportField;
			}
			set
			{
				this.workflowSupportField = value;
			}
		}
		public CrmBoolean DuplicateDetection
		{
			get
			{
				return this.duplicateDetectionField;
			}
			set
			{
				this.duplicateDetectionField = value;
			}
		}
		public CrmBoolean IsMailMergeEnabled
		{
			get
			{
				return this.isMailMergeEnabledField;
			}
			set
			{
				this.isMailMergeEnabledField = value;
			}
		}
		public CrmBoolean IsImportable
		{
			get
			{
				return this.isImportableField;
			}
			set
			{
				this.isImportableField = value;
			}
		}
		public CrmBoolean IsChildEntity
		{
			get
			{
				return this.isChildEntityField;
			}
			set
			{
				this.isChildEntityField = value;
			}
		}
		public string ReportViewName
		{
			get
			{
				return this.reportViewNameField;
			}
			set
			{
				this.reportViewNameField = value;
			}
		}
		public string PrimaryField
		{
			get
			{
				return this.primaryFieldField;
			}
			set
			{
				this.primaryFieldField = value;
			}
		}
		public string PrimaryKey
		{
			get
			{
				return this.primaryKeyField;
			}
			set
			{
				this.primaryKeyField = value;
			}
		}
		public CrmOwnershipTypes OwnershipType
		{
			get
			{
				return this.ownershipTypeField;
			}
			set
			{
				this.ownershipTypeField = value;
			}
		}
		[XmlArrayItem("Attribute", IsNullable = false)]
		public AttributeMetadata[] Attributes
		{
			get
			{
				return this.attributesField;
			}
			set
			{
				this.attributesField = value;
			}
		}
		[XmlArrayItem("From", IsNullable = false)]
		public OneToManyMetadata[] ManyToOneRelationships
		{
			get
			{
				return this.manyToOneRelationshipsField;
			}
			set
			{
				this.manyToOneRelationshipsField = value;
			}
		}
		[XmlArrayItem("To", IsNullable = false)]
		public OneToManyMetadata[] OneToManyRelationships
		{
			get
			{
				return this.oneToManyRelationshipsField;
			}
			set
			{
				this.oneToManyRelationshipsField = value;
			}
		}
		[XmlArrayItem("Privilege", IsNullable = false)]
		public SecurityPrivilegeMetadata[] Privileges
		{
			get
			{
				return this.privilegesField;
			}
			set
			{
				this.privilegesField = value;
			}
		}
		[XmlArrayItem("Intersect", IsNullable = false)]
		public ManyToManyMetadata[] ManyToManyRelationships
		{
			get
			{
				return this.manyToManyRelationshipsField;
			}
			set
			{
				this.manyToManyRelationshipsField = value;
			}
		}
		public CrmBoolean IsActivity
		{
			get
			{
				return this.isActivityField;
			}
			set
			{
				this.isActivityField = value;
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
	}
}
