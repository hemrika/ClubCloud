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
	public class AppointmentRequest : INotifyPropertyChanged
	{
		private Guid serviceIdField;

		private int anchorOffsetField;

		private int userTimeZoneCodeField;

		private int recurrenceDurationField;

		private int recurrenceTimeZoneCodeField;

		private ClubCloud.KNLTB.ServIt.CrmService.AppointmentsToIgnore[] appointmentsToIgnoreField;

		private RequiredResource[] requiredResourcesField;

		private CrmDateTime searchWindowStartField;

		private CrmDateTime searchWindowEndField;

		private CrmDateTime searchRecurrenceStartField;

		private string searchRecurrenceRuleField;

		private int durationField;

		private ConstraintRelation[] constraintsField;

		private ObjectiveRelation[] objectivesField;

		private SearchDirection directionField;

		private int numberOfResultsField;

		private Guid[] sitesField;

		[XmlElement] //[XmlElement(Order=1)]
		public int AnchorOffset
		{
			get
			{
				return this.anchorOffsetField;
			}
			set
			{
				this.anchorOffsetField = value;
				this.RaisePropertyChanged("AnchorOffset");
			}
		}

		[XmlArray] //[XmlArray(Order=5)]
		public ClubCloud.KNLTB.ServIt.CrmService.AppointmentsToIgnore[] AppointmentsToIgnore
		{
			get
			{
				return this.appointmentsToIgnoreField;
			}
			set
			{
				this.appointmentsToIgnoreField = value;
				this.RaisePropertyChanged("AppointmentsToIgnore");
			}
		}

		[XmlArray] //[XmlArray(Order=12)]
		public ConstraintRelation[] Constraints
		{
			get
			{
				return this.constraintsField;
			}
			set
			{
				this.constraintsField = value;
				this.RaisePropertyChanged("Constraints");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public SearchDirection Direction
		{
			get
			{
				return this.directionField;
			}
			set
			{
				this.directionField = value;
				this.RaisePropertyChanged("Direction");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public int Duration
		{
			get
			{
				return this.durationField;
			}
			set
			{
				this.durationField = value;
				this.RaisePropertyChanged("Duration");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public int NumberOfResults
		{
			get
			{
				return this.numberOfResultsField;
			}
			set
			{
				this.numberOfResultsField = value;
				this.RaisePropertyChanged("NumberOfResults");
			}
		}

		[XmlArray] //[XmlArray(Order=13)]
		public ObjectiveRelation[] Objectives
		{
			get
			{
				return this.objectivesField;
			}
			set
			{
				this.objectivesField = value;
				this.RaisePropertyChanged("Objectives");
			}
		}

		[XmlElement] //[XmlElement(Order=3)]
		public int RecurrenceDuration
		{
			get
			{
				return this.recurrenceDurationField;
			}
			set
			{
				this.recurrenceDurationField = value;
				this.RaisePropertyChanged("RecurrenceDuration");
			}
		}

		[XmlElement] //[XmlElement(Order=4)]
		public int RecurrenceTimeZoneCode
		{
			get
			{
				return this.recurrenceTimeZoneCodeField;
			}
			set
			{
				this.recurrenceTimeZoneCodeField = value;
				this.RaisePropertyChanged("RecurrenceTimeZoneCode");
			}
		}

		[XmlArray] //[XmlArray(Order=6)]
		public RequiredResource[] RequiredResources
		{
			get
			{
				return this.requiredResourcesField;
			}
			set
			{
				this.requiredResourcesField = value;
				this.RaisePropertyChanged("RequiredResources");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public string SearchRecurrenceRule
		{
			get
			{
				return this.searchRecurrenceRuleField;
			}
			set
			{
				this.searchRecurrenceRuleField = value;
				this.RaisePropertyChanged("SearchRecurrenceRule");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public CrmDateTime SearchRecurrenceStart
		{
			get
			{
				return this.searchRecurrenceStartField;
			}
			set
			{
				this.searchRecurrenceStartField = value;
				this.RaisePropertyChanged("SearchRecurrenceStart");
			}
		}

		[XmlElement] //[XmlElement(Order=8)]
		public CrmDateTime SearchWindowEnd
		{
			get
			{
				return this.searchWindowEndField;
			}
			set
			{
				this.searchWindowEndField = value;
				this.RaisePropertyChanged("SearchWindowEnd");
			}
		}

		[XmlElement] //[XmlElement(Order=7)]
		public CrmDateTime SearchWindowStart
		{
			get
			{
				return this.searchWindowStartField;
			}
			set
			{
				this.searchWindowStartField = value;
				this.RaisePropertyChanged("SearchWindowStart");
			}
		}

		[XmlElement] //[XmlElement(Order=0)]
		public Guid ServiceId
		{
			get
			{
				return this.serviceIdField;
			}
			set
			{
				this.serviceIdField = value;
				this.RaisePropertyChanged("ServiceId");
			}
		}

		[XmlArray] //[XmlArray(Order=16)]
		public Guid[] Sites
		{
			get
			{
				return this.sitesField;
			}
			set
			{
				this.sitesField = value;
				this.RaisePropertyChanged("Sites");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int UserTimeZoneCode
		{
			get
			{
				return this.userTimeZoneCodeField;
			}
			set
			{
				this.userTimeZoneCodeField = value;
				this.RaisePropertyChanged("UserTimeZoneCode");
			}
		}

		public AppointmentRequest()
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