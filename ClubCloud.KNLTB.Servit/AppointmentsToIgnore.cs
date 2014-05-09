using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2006/Scheduling")]
	[Serializable]
	public class AppointmentsToIgnore : INotifyPropertyChanged
	{
		private Guid[] appointmentsField;
		private Guid resourceIdField;
		public event PropertyChangedEventHandler PropertyChanged;
		[XmlArray(Order = 0)]
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
		[XmlElement(Order = 1)]
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
		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
