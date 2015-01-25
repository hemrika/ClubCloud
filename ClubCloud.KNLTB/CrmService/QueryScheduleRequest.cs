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
	public class QueryScheduleRequest : Request
	{
		private Guid resourceIdField;

		private CrmDateTime startField;

		private CrmDateTime endField;

		private TimeCode[] timeCodesField;

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

		[XmlElement] //[XmlElement(Order=0)]
		public Guid ResourceId
		{
			get
			{
				return this.resourceIdField;
			}
			set
			{
				this.resourceIdField = value;
				base.RaisePropertyChanged("ResourceId");
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

		[XmlArray] //[XmlArray(Order=3)]
		public TimeCode[] TimeCodes
		{
			get
			{
				return this.timeCodesField;
			}
			set
			{
				this.timeCodesField = value;
				base.RaisePropertyChanged("TimeCodes");
			}
		}

		public QueryScheduleRequest()
		{
		}
	}
}