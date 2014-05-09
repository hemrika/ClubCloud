using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateTaskRequest : Request
	{
		private Guid entityIdField;
		private TaskState taskStateField;
		private int taskStatusField;
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
		public TaskState TaskState
		{
			get
			{
				return this.taskStateField;
			}
			set
			{
				this.taskStateField = value;
				base.RaisePropertyChanged("TaskState");
			}
		}
		[XmlElement(Order = 2)]
		public int TaskStatus
		{
			get
			{
				return this.taskStatusField;
			}
			set
			{
				this.taskStatusField = value;
				base.RaisePropertyChanged("TaskStatus");
			}
		}
	}
}
