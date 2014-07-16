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
	public class SetStateSw_tracelogRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sw_tracelogState sw_tracelogStateField;

		private int sw_tracelogStatusField;

		[XmlElement] //[XmlElement(Order=0)]
		public Guid EntityId
		{
			get
			{
				return this.entityIdField;
			}
			set
			{
				this.entityIdField = value;
				base.RaisePropertyChanged("EntityId");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public ClubCloud.KNLTB.ServIt.CrmService.Sw_tracelogState Sw_tracelogState
		{
			get
			{
				return this.sw_tracelogStateField;
			}
			set
			{
				this.sw_tracelogStateField = value;
				base.RaisePropertyChanged("Sw_tracelogState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sw_tracelogStatus
		{
			get
			{
				return this.sw_tracelogStatusField;
			}
			set
			{
				this.sw_tracelogStatusField = value;
				base.RaisePropertyChanged("Sw_tracelogStatus");
			}
		}

		public SetStateSw_tracelogRequest()
		{
		}
	}
}