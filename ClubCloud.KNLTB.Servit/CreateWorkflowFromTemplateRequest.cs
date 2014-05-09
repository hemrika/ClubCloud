using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class CreateWorkflowFromTemplateRequest : Request
	{
		private string workflowNameField;
		private Guid workflowTemplateIdField;
		[XmlElement(Order = 0)]
		public string WorkflowName
		{
			get
			{
				return this.workflowNameField;
			}
			set
			{
				this.workflowNameField = value;
				base.RaisePropertyChanged("WorkflowName");
			}
		}
		[XmlElement(Order = 1)]
		public Guid WorkflowTemplateId
		{
			get
			{
				return this.workflowTemplateIdField;
			}
			set
			{
				this.workflowTemplateIdField = value;
				base.RaisePropertyChanged("WorkflowTemplateId");
			}
		}
	}
}
