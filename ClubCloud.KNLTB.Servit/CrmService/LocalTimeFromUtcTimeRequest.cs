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
	public class LocalTimeFromUtcTimeRequest : Request
	{
		private int timeZoneCodeField;

		private CrmDateTime utcTimeField;

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

		[XmlElement] //[XmlElement(Order=1)]
		public CrmDateTime UtcTime
		{
			get
			{
				return this.utcTimeField;
			}
			set
			{
				this.utcTimeField = value;
				base.RaisePropertyChanged("UtcTime");
			}
		}

		public LocalTimeFromUtcTimeRequest()
		{
		}
	}
}