using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateAnnualFiscalCalendar : TargetUpdate
	{
		private annualfiscalcalendar annualFiscalCalendarField;
		[XmlElement(Order = 0)]
		public annualfiscalcalendar AnnualFiscalCalendar
		{
			get
			{
				return this.annualFiscalCalendarField;
			}
			set
			{
				this.annualFiscalCalendarField = value;
				base.RaisePropertyChanged("AnnualFiscalCalendar");
			}
		}
	}
}
