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
	public class SetStateSw_retrievequeryRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sw_retrievequeryState sw_retrievequeryStateField;

		private int sw_retrievequeryStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sw_retrievequeryState Sw_retrievequeryState
		{
			get
			{
				return this.sw_retrievequeryStateField;
			}
			set
			{
				this.sw_retrievequeryStateField = value;
				base.RaisePropertyChanged("Sw_retrievequeryState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sw_retrievequeryStatus
		{
			get
			{
				return this.sw_retrievequeryStatusField;
			}
			set
			{
				this.sw_retrievequeryStatusField = value;
				base.RaisePropertyChanged("Sw_retrievequeryStatus");
			}
		}

		public SetStateSw_retrievequeryRequest()
		{
		}
	}
}