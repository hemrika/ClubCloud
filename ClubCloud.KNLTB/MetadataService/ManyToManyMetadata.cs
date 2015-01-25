using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.MetadataService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class ManyToManyMetadata : RelationshipMetadata
	{
		private string entity1LogicalNameField;
		private string entity2LogicalNameField;
		private string intersectEntityNameField;
		private string entity1IntersectAttributeField;
		private string entity2IntersectAttributeField;
		private CrmAssociatedMenuBehavior entity1AssociatedMenuBehaviorField;
		private CrmLabel entity1AssociatedMenuLabelField;
		private CrmAssociatedMenuBehavior entity2AssociatedMenuBehaviorField;
		private CrmLabel entity2AssociatedMenuLabelField;
		private CrmAssociatedMenuGroup entity1AssociatedMenuGroupField;
		private CrmAssociatedMenuGroup entity2AssociatedMenuGroupField;
		private CrmNumber entity1AssociatedMenuOrderField;
		private CrmNumber entity2AssociatedMenuOrderField;
		public string Entity1LogicalName
		{
			get
			{
				return this.entity1LogicalNameField;
			}
			set
			{
				this.entity1LogicalNameField = value;
			}
		}
		public string Entity2LogicalName
		{
			get
			{
				return this.entity2LogicalNameField;
			}
			set
			{
				this.entity2LogicalNameField = value;
			}
		}
		public string IntersectEntityName
		{
			get
			{
				return this.intersectEntityNameField;
			}
			set
			{
				this.intersectEntityNameField = value;
			}
		}
		public string Entity1IntersectAttribute
		{
			get
			{
				return this.entity1IntersectAttributeField;
			}
			set
			{
				this.entity1IntersectAttributeField = value;
			}
		}
		public string Entity2IntersectAttribute
		{
			get
			{
				return this.entity2IntersectAttributeField;
			}
			set
			{
				this.entity2IntersectAttributeField = value;
			}
		}
		public CrmAssociatedMenuBehavior Entity1AssociatedMenuBehavior
		{
			get
			{
				return this.entity1AssociatedMenuBehaviorField;
			}
			set
			{
				this.entity1AssociatedMenuBehaviorField = value;
			}
		}
		public CrmLabel Entity1AssociatedMenuLabel
		{
			get
			{
				return this.entity1AssociatedMenuLabelField;
			}
			set
			{
				this.entity1AssociatedMenuLabelField = value;
			}
		}
		public CrmAssociatedMenuBehavior Entity2AssociatedMenuBehavior
		{
			get
			{
				return this.entity2AssociatedMenuBehaviorField;
			}
			set
			{
				this.entity2AssociatedMenuBehaviorField = value;
			}
		}
		public CrmLabel Entity2AssociatedMenuLabel
		{
			get
			{
				return this.entity2AssociatedMenuLabelField;
			}
			set
			{
				this.entity2AssociatedMenuLabelField = value;
			}
		}
		public CrmAssociatedMenuGroup Entity1AssociatedMenuGroup
		{
			get
			{
				return this.entity1AssociatedMenuGroupField;
			}
			set
			{
				this.entity1AssociatedMenuGroupField = value;
			}
		}
		public CrmAssociatedMenuGroup Entity2AssociatedMenuGroup
		{
			get
			{
				return this.entity2AssociatedMenuGroupField;
			}
			set
			{
				this.entity2AssociatedMenuGroupField = value;
			}
		}
		public CrmNumber Entity1AssociatedMenuOrder
		{
			get
			{
				return this.entity1AssociatedMenuOrderField;
			}
			set
			{
				this.entity1AssociatedMenuOrderField = value;
			}
		}
		public CrmNumber Entity2AssociatedMenuOrder
		{
			get
			{
				return this.entity2AssociatedMenuOrderField;
			}
			set
			{
				this.entity2AssociatedMenuOrderField = value;
			}
		}
	}
}
