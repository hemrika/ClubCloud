using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class ExpandCalendarRequest : Request
	{
		private Guid calendarIdField;
		private CrmDateTime startField;
		private CrmDateTime endField;
		[XmlElement(Order = 0)]
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
		[XmlElement(Order = 1)]
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
		[XmlElement(Order = 2)]
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
	}
}
