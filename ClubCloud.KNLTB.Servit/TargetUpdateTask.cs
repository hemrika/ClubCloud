using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateTask : TargetUpdate
	{
		private task taskField;
		[XmlElement(Order = 0)]
		public task Task
		{
			get
			{
				return this.taskField;
			}
			set
			{
				this.taskField = value;
				base.RaisePropertyChanged("Task");
			}
		}
	}
}
