using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateWFProcessInstanceRequest : Request
	{
		private Guid entityIdField;
		private WFProcessInstanceState wFProcessInstanceStateField;
		private int wFProcessInstanceStatusField;
		public Guid EntityId
		{
			get
			{
				return this.entityIdField;
			}
			set
			{
				this.entityIdField = value;
			}
		}
		public WFProcessInstanceState WFProcessInstanceState
		{
			get
			{
				return this.wFProcessInstanceStateField;
			}
			set
			{
				this.wFProcessInstanceStateField = value;
			}
		}
		public int WFProcessInstanceStatus
		{
			get
			{
				return this.wFProcessInstanceStatusField;
			}
			set
			{
				this.wFProcessInstanceStatusField = value;
			}
		}
	}
}
