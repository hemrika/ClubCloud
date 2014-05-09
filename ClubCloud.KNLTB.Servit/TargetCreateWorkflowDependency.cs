using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateWorkflowDependency : TargetCreate
	{
		private workflowdependency workflowDependencyField;
		[XmlElement(Order = 0)]
		public workflowdependency WorkflowDependency
		{
			get
			{
				return this.workflowDependencyField;
			}
			set
			{
				this.workflowDependencyField = value;
				base.RaisePropertyChanged("WorkflowDependency");
			}
		}
	}
}
