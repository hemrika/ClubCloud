using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[GeneratedCode("System.Xml", "4.0.30319.33440")]
	[Serializable]
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2007/WebServices")]
	public class TargetUpdateWorkflowDependency : TargetUpdate
	{
		private workflowdependency workflowDependencyField;

		[XmlElement] //[XmlElement(Order=0)]
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

		public TargetUpdateWorkflowDependency()
		{
		}
	}
}