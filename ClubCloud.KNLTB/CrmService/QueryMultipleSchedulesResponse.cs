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
	public class QueryMultipleSchedulesResponse : Response
	{
		private TimeInfo[][] timeInfosField;

		[XmlArray] //[XmlArray(Order=0)]
		[XmlArrayItem(NestingLevel=1)]
		[XmlArrayItem("ArrayOfTimeInfo")]
		public TimeInfo[][] TimeInfos
		{
			get
			{
				return this.timeInfosField;
			}
			set
			{
				this.timeInfosField = value;
				base.RaisePropertyChanged("TimeInfos");
			}
		}

		public QueryMultipleSchedulesResponse()
		{
		}
	}
}