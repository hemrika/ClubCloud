using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateServiceAppointmentRequest : Request
	{
		private Guid entityIdField;
		private ServiceAppointmentState serviceAppointmentStateField;
		private int serviceAppointmentStatusField;
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
		public ServiceAppointmentState ServiceAppointmentState
		{
			get
			{
				return this.serviceAppointmentStateField;
			}
			set
			{
				this.serviceAppointmentStateField = value;
			}
		}
		public int ServiceAppointmentStatus
		{
			get
			{
				return this.serviceAppointmentStatusField;
			}
			set
			{
				this.serviceAppointmentStatusField = value;
			}
		}
	}
}
