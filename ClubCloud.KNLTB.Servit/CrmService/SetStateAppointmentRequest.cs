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
	public class SetStateAppointmentRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.AppointmentState appointmentStateField;

		private int appointmentStatusField;

		[XmlElement] //[XmlElement(Order=1)]
		public ClubCloud.KNLTB.ServIt.CrmService.AppointmentState AppointmentState
		{
			get
			{
				return this.appointmentStateField;
			}
			set
			{
				this.appointmentStateField = value;
				base.RaisePropertyChanged("AppointmentState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int AppointmentStatus
		{
			get
			{
				return this.appointmentStatusField;
			}
			set
			{
				this.appointmentStatusField = value;
				base.RaisePropertyChanged("AppointmentStatus");
			}
		}

		[XmlElement] //[XmlElement(Order=0)]
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

		public SetStateAppointmentRequest()
		{
		}
	}
}