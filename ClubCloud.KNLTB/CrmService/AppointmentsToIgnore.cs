using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Xml.Serialization;

namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[GeneratedCode("System.Xml", "4.0.30319.33440")]
	[Serializable]
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2006/Scheduling")]
	public class AppointmentsToIgnore : INotifyPropertyChanged
	{
		private Guid[] appointmentsField;

		private Guid resourceIdField;

		[XmlArray] //[XmlArray(Order=0)]
		public Guid[] Appointments
		{
			get
			{
				return this.appointmentsField;
			}
			set
			{
				this.appointmentsField = value;
				this.RaisePropertyChanged("Appointments");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public Guid ResourceId
		{
			get
			{
				return this.resourceIdField;
			}
			set
			{
				this.resourceIdField = value;
				this.RaisePropertyChanged("ResourceId");
			}
		}

		public AppointmentsToIgnore()
		{
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;
	}
}