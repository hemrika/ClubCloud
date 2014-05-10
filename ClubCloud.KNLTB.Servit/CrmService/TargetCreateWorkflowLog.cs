using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateWorkflowLog : TargetCreate
	{
		private workflowlog workflowLogField;
		public workflowlog WorkflowLog
		{
			get
			{
				return this.workflowLogField;
			}
			set
			{
				this.workflowLogField = value;
			}
		}
	}
}
