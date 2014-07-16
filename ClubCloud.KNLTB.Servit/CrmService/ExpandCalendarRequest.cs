using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[GeneratedCode("System.Xml", "4.0.30319.33440")]
	[Serializable]
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2007/WebServices")]
	public class ExpandCalendarRequest : Request
	{
		private Guid calendarIdField;

		private CrmDateTime startField;

		private CrmDateTime endField;

		[XmlElement] //[XmlElement(Order=0)]
		public Guid CalendarId
		{
			get
			{
				return this.calendarIdField;
			}
			set
			{
				this.calendarIdField = value;
				base.RaisePropertyChanged("CalendarId");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public CrmDateTime End
		{
			get
			{
				return this.endField;
			}
			set
			{
				this.endField = value;
				base.RaisePropertyChanged("End");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public CrmDateTime Start
		{
			get
			{
				return this.startField;
			}
			set
			{
				this.startField = value;
				base.RaisePropertyChanged("Start");
			}
		}

		public ExpandCalendarRequest()
		{
		}
	}
}