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
	public class ValidationResult : INotifyPropertyChanged
	{
		private bool validationSuccessField;

		private ClubCloud.KNLTB.ServIt.CrmService.TraceInfo traceInfoField;

		private Guid activityIdField;

		[XmlElement] //[XmlElement(Order=2)]
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

		[XmlElement] //[XmlElement(Order=1)]
		public ClubCloud.KNLTB.ServIt.CrmService.TraceInfo TraceInfo
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

		[XmlElement] //[XmlElement(Order=0)]
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

		public ValidationResult()
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