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
	public class SetStateSw_retrievemultiplequeryRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sw_retrievemultiplequeryState sw_retrievemultiplequeryStateField;

		private int sw_retrievemultiplequeryStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sw_retrievemultiplequeryState Sw_retrievemultiplequeryState
		{
			get
			{
				return this.sw_retrievemultiplequeryStateField;
			}
			set
			{
				this.sw_retrievemultiplequeryStateField = value;
				base.RaisePropertyChanged("Sw_retrievemultiplequeryState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sw_retrievemultiplequeryStatus
		{
			get
			{
				return this.sw_retrievemultiplequeryStatusField;
			}
			set
			{
				this.sw_retrievemultiplequeryStatusField = value;
				base.RaisePropertyChanged("Sw_retrievemultiplequeryStatus");
			}
		}

		public SetStateSw_retrievemultiplequeryRequest()
		{
		}
	}
}