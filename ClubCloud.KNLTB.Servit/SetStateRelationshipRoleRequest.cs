using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateRelationshipRoleRequest : Request
	{
		private Guid entityIdField;
		private RelationshipRoleState relationshipRoleStateField;
		private int relationshipRoleStatusField;
		[XmlElement(Order = 0)]
		public Guid EntityId
		{
			get
			{
				return this.entityIdField;
			}
			set
			{
				this.entityIdField = value;
				base.RaisePropertyChanged("EntityId");
			}
		}
		[XmlElement(Order = 1)]
		public RelationshipRoleState RelationshipRoleState
		{
			get
			{
				return this.relationshipRoleStateField;
			}
			set
			{
				this.relationshipRoleStateField = value;
				base.RaisePropertyChanged("RelationshipRoleState");
			}
		}
		[XmlElement(Order = 2)]
		public int RelationshipRoleStatus
		{
			get
			{
				return this.relationshipRoleStatusField;
			}
			set
			{
				this.relationshipRoleStatusField = value;
				base.RaisePropertyChanged("RelationshipRoleStatus");
			}
		}
	}
}
