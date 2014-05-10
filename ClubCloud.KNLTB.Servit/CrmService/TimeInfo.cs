using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2006/Scheduling")]
	[Serializable]
	public class TimeInfo
	{
		private CrmDateTime startField;
		private CrmDateTime endField;
		private TimeCode timeCodeField;
		private SubCode subCodeField;
		private Guid sourceIdField;
		private Guid calendarIdField;
		private int sourceTypeCodeField;
		private bool isActivityField;
		private int activityStatusCodeField;
		private double effortField;
		private string displayTextField;
		public CrmDateTime Start
		{
			get
			{
				return this.startField;
			}
			set
			{
				this.startField = value;
			}
		}
		public CrmDateTime End
		{
			get
			{
				return this.endField;
			}
			set
			{
				this.endField = value;
			}
		}
		public TimeCode TimeCode
		{
			get
			{
				return this.timeCodeField;
			}
			set
			{
				this.timeCodeField = value;
			}
		}
		public SubCode SubCode
		{
			get
			{
				return this.subCodeField;
			}
			set
			{
				this.subCodeField = value;
			}
		}
		public Guid SourceId
		{
			get
			{
				return this.sourceIdField;
			}
			set
			{
				this.sourceIdField = value;
			}
		}
		public Guid CalendarId
		{
			get
			{
				return this.calendarIdField;
			}
			set
			{
				this.calendarIdField = value;
			}
		}
		public int SourceTypeCode
		{
			get
			{
				return this.sourceTypeCodeField;
			}
			set
			{
				this.sourceTypeCodeField = value;
			}
		}
		public bool IsActivity
		{
			get
			{
				return this.isActivityField;
			}
			set
			{
				this.isActivityField = value;
			}
		}
		public int ActivityStatusCode
		{
			get
			{
				return this.activityStatusCodeField;
			}
			set
			{
				this.activityStatusCodeField = value;
			}
		}
		public double Effort
		{
			get
			{
				return this.effortField;
			}
			set
			{
				this.effortField = value;
			}
		}
		public string DisplayText
		{
			get
			{
				return this.displayTextField;
			}
			set
			{
				this.displayTextField = value;
			}
		}
	}
}
