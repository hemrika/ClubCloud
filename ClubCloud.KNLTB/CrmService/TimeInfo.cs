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
	public class TimeInfo : INotifyPropertyChanged
	{
		private CrmDateTime startField;

		private CrmDateTime endField;

		private ClubCloud.KNLTB.ServIt.CrmService.TimeCode timeCodeField;

		private ClubCloud.KNLTB.ServIt.CrmService.SubCode subCodeField;

		private Guid sourceIdField;

		private Guid calendarIdField;

		private int sourceTypeCodeField;

		private bool isActivityField;

		private int activityStatusCodeField;

		private double effortField;

		private string displayTextField;

		[XmlElement] //[XmlElement(Order=8)]
		public int ActivityStatusCode
		{
			get
			{
				return this.activityStatusCodeField;
			}
			set
			{
				this.activityStatusCodeField = value;
				this.RaisePropertyChanged("ActivityStatusCode");
			}
		}

		[XmlElement] //[XmlElement(Order=5)]
		public Guid CalendarId
		{
			get
			{
				return this.calendarIdField;
			}
			set
			{
				this.calendarIdField = value;
				this.RaisePropertyChanged("CalendarId");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public string DisplayText
		{
			get
			{
				return this.displayTextField;
			}
			set
			{
				this.displayTextField = value;
				this.RaisePropertyChanged("DisplayText");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public double Effort
		{
			get
			{
				return this.effortField;
			}
			set
			{
				this.effortField = value;
				this.RaisePropertyChanged("Effort");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public CrmDateTime End
		{
			get
			{
				return this.endField;
			}
			set
			{
				this.endField = value;
				this.RaisePropertyChanged("End");
			}
		}

		[XmlElement] //[XmlElement(Order=7)]
		public bool IsActivity
		{
			get
			{
				return this.isActivityField;
			}
			set
			{
				this.isActivityField = value;
				this.RaisePropertyChanged("IsActivity");
			}
		}

		[XmlElement] //[XmlElement(Order=4)]
		public Guid SourceId
		{
			get
			{
				return this.sourceIdField;
			}
			set
			{
				this.sourceIdField = value;
				this.RaisePropertyChanged("SourceId");
			}
		}

		[XmlElement] //[XmlElement(Order=6)]
		public int SourceTypeCode
		{
			get
			{
				return this.sourceTypeCodeField;
			}
			set
			{
				this.sourceTypeCodeField = value;
				this.RaisePropertyChanged("SourceTypeCode");
			}
		}

		[XmlElement] //[XmlElement(Order=0)]
		public CrmDateTime Start
		{
			get
			{
				return this.startField;
			}
			set
			{
				this.startField = value;
				this.RaisePropertyChanged("Start");
			}
		}

		[XmlElement] //[XmlElement(Order=3)]
		public ClubCloud.KNLTB.ServIt.CrmService.SubCode SubCode
		{
			get
			{
				return this.subCodeField;
			}
			set
			{
				this.subCodeField = value;
				this.RaisePropertyChanged("SubCode");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public ClubCloud.KNLTB.ServIt.CrmService.TimeCode TimeCode
		{
			get
			{
				return this.timeCodeField;
			}
			set
			{
				this.timeCodeField = value;
				this.RaisePropertyChanged("TimeCode");
			}
		}

		public TimeInfo()
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