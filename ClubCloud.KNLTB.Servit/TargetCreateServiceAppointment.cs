using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateServiceAppointment : TargetCreate
	{
		private serviceappointment serviceAppointmentField;
		[XmlElement(Order = 0)]
		public serviceappointment ServiceAppointment
		{
			get
			{
				return this.serviceAppointmentField;
			}
			set
			{
				this.serviceAppointmentField = value;
				base.RaisePropertyChanged("ServiceAppointment");
			}
		}
	}
}
