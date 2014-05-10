using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class FindParentResourceGroupRequest : Request
	{
		private Guid parentIdField;
		private Guid[] childrenIdsField;
		public Guid ParentId
		{
			get
			{
				return this.parentIdField;
			}
			set
			{
				this.parentIdField = value;
			}
		}
		public Guid[] ChildrenIds
		{
			get
			{
				return this.childrenIdsField;
			}
			set
			{
				this.childrenIdsField = value;
			}
		}
	}
}
