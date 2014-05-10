using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateTaskRequest : Request
	{
		private Guid entityIdField;
		private TaskState taskStateField;
		private int taskStatusField;
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
		public TaskState TaskState
		{
			get
			{
				return this.taskStateField;
			}
			set
			{
				this.taskStateField = value;
			}
		}
		public int TaskStatus
		{
			get
			{
				return this.taskStatusField;
			}
			set
			{
				this.taskStatusField = value;
			}
		}
	}
}
