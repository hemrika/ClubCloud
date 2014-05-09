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
		public ServiceAppointmentState ServiceAppointmentState
		{
			get
			{
				return this.serviceAppointmentStateField;
			}
			set
			{
				this.serviceAppointmentStateField = value;
				base.RaisePropertyChanged("ServiceAppointmentState");
			}
		}
		[XmlElement(Order = 2)]
		public int ServiceAppointmentStatus
		{
			get
			{
				return this.serviceAppointmentStatusField;
			}
			set
			{
				this.serviceAppointmentStatusField = value;
				base.RaisePropertyChanged("ServiceAppointmentStatus");
			}
		}
	}
}
