using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2006/Scheduling")]
	[Serializable]
	public class AppointmentRequest
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
		public Guid ServiceId
		{
			get
			{
				return this.serviceIdField;
			}
			set
			{
				this.serviceIdField = value;
			}
		}
		public int AnchorOffset
		{
			get
			{
				return this.anchorOffsetField;
			}
			set
			{
				this.anchorOffsetField = value;
			}
		}
		public int UserTimeZoneCode
		{
			get
			{
				return this.userTimeZoneCodeField;
			}
			set
			{
				this.userTimeZoneCodeField = value;
			}
		}
		public int RecurrenceDuration
		{
			get
			{
				return this.recurrenceDurationField;
			}
			set
			{
				this.recurrenceDurationField = value;
			}
		}
		public int RecurrenceTimeZoneCode
		{
			get
			{
				return this.recurrenceTimeZoneCodeField;
			}
			set
			{
				this.recurrenceTimeZoneCodeField = value;
			}
		}
		public AppointmentsToIgnore[] AppointmentsToIgnore
		{
			get
			{
				return this.appointmentsToIgnoreField;
			}
			set
			{
				this.appointmentsToIgnoreField = value;
			}
		}
		public RequiredResource[] RequiredResources
		{
			get
			{
				return this.requiredResourcesField;
			}
			set
			{
				this.requiredResourcesField = value;
			}
		}
		public CrmDateTime SearchWindowStart
		{
			get
			{
				return this.searchWindowStartField;
			}
			set
			{
				this.searchWindowStartField = value;
			}
		}
		public CrmDateTime SearchWindowEnd
		{
			get
			{
				return this.searchWindowEndField;
			}
			set
			{
				this.searchWindowEndField = value;
			}
		}
		public CrmDateTime SearchRecurrenceStart
		{
			get
			{
				return this.searchRecurrenceStartField;
			}
			set
			{
				this.searchRecurrenceStartField = value;
			}
		}
		public string SearchRecurrenceRule
		{
			get
			{
				return this.searchRecurrenceRuleField;
			}
			set
			{
				this.searchRecurrenceRuleField = value;
			}
		}
		public int Duration
		{
			get
			{
				return this.durationField;
			}
			set
			{
				this.durationField = value;
			}
		}
		public ConstraintRelation[] Constraints
		{
			get
			{
				return this.constraintsField;
			}
			set
			{
				this.constraintsField = value;
			}
		}
		public ObjectiveRelation[] Objectives
		{
			get
			{
				return this.objectivesField;
			}
			set
			{
				this.objectivesField = value;
			}
		}
		public SearchDirection Direction
		{
			get
			{
				return this.directionField;
			}
			set
			{
				this.directionField = value;
			}
		}
		public int NumberOfResults
		{
			get
			{
				return this.numberOfResultsField;
			}
			set
			{
				this.numberOfResultsField = value;
			}
		}
		public Guid[] Sites
		{
			get
			{
				return this.sitesField;
			}
			set
			{
				this.sitesField = value;
			}
		}
	}
}
