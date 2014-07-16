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
	public class SetStateSw_lookuptemplateRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sw_lookuptemplateState sw_lookuptemplateStateField;

		private int sw_lookuptemplateStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sw_lookuptemplateState Sw_lookuptemplateState
		{
			get
			{
				return this.sw_lookuptemplateStateField;
			}
			set
			{
				this.sw_lookuptemplateStateField = value;
				base.RaisePropertyChanged("Sw_lookuptemplateState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sw_lookuptemplateStatus
		{
			get
			{
				return this.sw_lookuptemplateStatusField;
			}
			set
			{
				this.sw_lookuptemplateStatusField = value;
				base.RaisePropertyChanged("Sw_lookuptemplateStatus");
			}
		}

		public SetStateSw_lookuptemplateRequest()
		{
		}
	}
}