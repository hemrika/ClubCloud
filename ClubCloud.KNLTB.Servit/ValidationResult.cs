using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2006/Scheduling")]
	[Serializable]
	public class ValidationResult : INotifyPropertyChanged
	{
		private bool validationSuccessField;
		private TraceInfo traceInfoField;
		private Guid activityIdField;
		public event PropertyChangedEventHandler PropertyChanged;
		[XmlElement(Order = 0)]
		public bool ValidationSuccess
		{
			get
			{
				return this.validationSuccessField;
			}
			set
			{
				this.validationSuccessField = value;
				this.RaisePropertyChanged("ValidationSuccess");
			}
		}
		[XmlElement(Order = 1)]
		public TraceInfo TraceInfo
		{
			get
			{
				return this.traceInfoField;
			}
			set
			{
				this.traceInfoField = value;
				this.RaisePropertyChanged("TraceInfo");
			}
		}
		[XmlElement(Order = 2)]
		public Guid ActivityId
		{
			get
			{
				return this.activityIdField;
			}
			set
			{
				this.activityIdField = value;
				this.RaisePropertyChanged("ActivityId");
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
