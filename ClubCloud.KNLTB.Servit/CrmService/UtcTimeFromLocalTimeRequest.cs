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
	public class UtcTimeFromLocalTimeRequest : Request
	{
		private int timeZoneCodeField;

		private CrmDateTime localTimeField;

		[XmlElement] //[XmlElement(Order=1)]
		public CrmDateTime LocalTime
		{
			get
			{
				return this.localTimeField;
			}
			set
			{
				this.localTimeField = value;
				base.RaisePropertyChanged("LocalTime");
			}
		}

		[XmlElement] //[XmlElement(Order=0)]
		public int TimeZoneCode
		{
			get
			{
				return this.timeZoneCodeField;
			}
			set
			{
				this.timeZoneCodeField = value;
				base.RaisePropertyChanged("TimeZoneCode");
			}
		}

		public UtcTimeFromLocalTimeRequest()
		{
		}
	}
}