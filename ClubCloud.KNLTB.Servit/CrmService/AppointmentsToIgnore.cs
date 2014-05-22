using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2006/Scheduling")]
	[Serializable]
	public class AppointmentsToIgnore
	{
		private Guid[] appointmentsField;
		private Guid resourceIdField;
		public Guid[] Appointments
		{
			get
			{
				return this.appointmentsField;
			}
			set
			{
				this.appointmentsField = value;
			}
		}
		public Guid ResourceId
		{
			get
			{
				return this.resourceIdField;
			}
			set
			{
				this.resourceIdField = value;
			}
		}
	}
}