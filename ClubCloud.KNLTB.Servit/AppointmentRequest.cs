using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2006/Scheduling")]
	[Serializable]
	public class AppointmentRequest : INotifyPropertyChanged
	{
		private Guid serviceIdField;
		private int anchorOffsetField;
		private int userTimeZoneCodeField;
		private int recurrenceDurationField;
		private int recurrenceTimeZoneCodeField;
		private AppointmentsToIgnore[] appointmentsToIgnoreField;
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
		public event PropertyChangedEventHandler PropertyChanged;
		[XmlElement(Order = 0)]
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
		[XmlElement(Order = 1)]
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
		[XmlElement(Order = 2)]
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
		[XmlElement(Order = 3)]
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
		[XmlElement(Order = 4)]
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
		[XmlArray(Order = 5)]
		public AppointmentsToIgnore[] AppointmentsToIgnore
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
		[XmlArray(Order = 6)]
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
		[XmlElement(Order = 7)]
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
		[XmlElement(Order = 8)]
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
		[XmlElement(Order = 9)]
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
		[XmlElement(Order = 10)]
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
		[XmlElement(Order = 11)]
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
		[XmlArray(Order = 12)]
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
		[XmlArray(Order = 13)]
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
		[XmlElement(Order = 14)]
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
		[XmlElement(Order = 15)]
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
		[XmlArray(Order = 16)]
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
