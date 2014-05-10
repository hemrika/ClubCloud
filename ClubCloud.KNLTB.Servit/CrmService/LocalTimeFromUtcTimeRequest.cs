using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class LocalTimeFromUtcTimeRequest : Request
	{
		private int timeZoneCodeField;
		private CrmDateTime utcTimeField;
		public int TimeZoneCode
		{
			get
			{
				return this.timeZoneCodeField;
			}
			set
			{
				this.timeZoneCodeField = value;
			}
		}
		public CrmDateTime UtcTime
		{
			get
			{
				return this.utcTimeField;
			}
			set
			{
				this.utcTimeField = value;
			}
		}
	}
}
