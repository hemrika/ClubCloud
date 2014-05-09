using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class ExecuteWorkflowRequest : Request
	{
		private Guid entityIdField;
		private Guid workflowIdField;
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
		public Guid WorkflowId
		{
			get
			{
				return this.workflowIdField;
			}
			set
			{
				this.workflowIdField = value;
				base.RaisePropertyChanged("WorkflowId");
			}
		}
	}
}
