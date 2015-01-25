using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.MetadataService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class OneToManyMetadata : RelationshipMetadata
	{
		private CrmCascadeType cascadeAssignField;
		private CrmCascadeType cascadeDeleteField;
		private CrmCascadeType cascadeMergeField;
		private CrmCascadeType cascadeReparentField;
		private CrmCascadeType cascadeShareField;
		private CrmCascadeType cascadeUnshareField;
		private string referencedAttributeField;
		private string referencedEntityField;
		private string referencingAttributeField;
		private string referencingEntityField;
		private CrmAssociatedMenuBehavior associatedMenuBehaviorField;
		private CrmAssociatedMenuGroup associatedMenuGroupField;
		private CrmNumber associatedMenuOrderField;
		private CrmLabel associatedMenuLabelField;
		public CrmCascadeType CascadeAssign
		{
			get
			{
				return this.cascadeAssignField;
			}
			set
			{
				this.cascadeAssignField = value;
			}
		}
		public CrmCascadeType CascadeDelete
		{
			get
			{
				return this.cascadeDeleteField;
			}
			set
			{
				this.cascadeDeleteField = value;
			}
		}
		public CrmCascadeType CascadeMerge
		{
			get
			{
				return this.cascadeMergeField;
			}
			set
			{
				this.cascadeMergeField = value;
			}
		}
		public CrmCascadeType CascadeReparent
		{
			get
			{
				return this.cascadeReparentField;
			}
			set
			{
				this.cascadeReparentField = value;
			}
		}
		public CrmCascadeType CascadeShare
		{
			get
			{
				return this.cascadeShareField;
			}
			set
			{
				this.cascadeShareField = value;
			}
		}
		public CrmCascadeType CascadeUnshare
		{
			get
			{
				return this.cascadeUnshareField;
			}
			set
			{
				this.cascadeUnshareField = value;
			}
		}
		public string ReferencedAttribute
		{
			get
			{
				return this.referencedAttributeField;
			}
			set
			{
				this.referencedAttributeField = value;
			}
		}
		public string ReferencedEntity
		{
			get
			{
				return this.referencedEntityField;
			}
			set
			{
				this.referencedEntityField = value;
			}
		}
		public string ReferencingAttribute
		{
			get
			{
				return this.referencingAttributeField;
			}
			set
			{
				this.referencingAttributeField = value;
			}
		}
		public string ReferencingEntity
		{
			get
			{
				return this.referencingEntityField;
			}
			set
			{
				this.referencingEntityField = value;
			}
		}
		public CrmAssociatedMenuBehavior AssociatedMenuBehavior
		{
			get
			{
				return this.associatedMenuBehaviorField;
			}
			set
			{
				this.associatedMenuBehaviorField = value;
			}
		}
		public CrmAssociatedMenuGroup AssociatedMenuGroup
		{
			get
			{
				return this.associatedMenuGroupField;
			}
			set
			{
				this.associatedMenuGroupField = value;
			}
		}
		public CrmNumber AssociatedMenuOrder
		{
			get
			{
				return this.associatedMenuOrderField;
			}
			set
			{
				this.associatedMenuOrderField = value;
			}
		}
		public CrmLabel AssociatedMenuLabel
		{
			get
			{
				return this.associatedMenuLabelField;
			}
			set
			{
				this.associatedMenuLabelField = value;
			}
		}
	}
}
