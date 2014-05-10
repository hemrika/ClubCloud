using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateAppointmentRequest : Request
	{
		private Guid entityIdField;
		private AppointmentState appointmentStateField;
		private int appointmentStatusField;
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
		public AppointmentState AppointmentState
		{
			get
			{
				return this.appointmentStateField;
			}
			set
			{
				this.appointmentStateField = value;
			}
		}
		public int AppointmentStatus
		{
			get
			{
				return this.appointmentStatusField;
			}
			set
			{
				this.appointmentStatusField = value;
			}
		}
	}
}
