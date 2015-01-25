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
	public class SetStateSgt_dss_eindejaarsratingRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_dss_eindejaarsratingState sgt_dss_eindejaarsratingStateField;

		private int sgt_dss_eindejaarsratingStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_dss_eindejaarsratingState Sgt_dss_eindejaarsratingState
		{
			get
			{
				return this.sgt_dss_eindejaarsratingStateField;
			}
			set
			{
				this.sgt_dss_eindejaarsratingStateField = value;
				base.RaisePropertyChanged("Sgt_dss_eindejaarsratingState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_dss_eindejaarsratingStatus
		{
			get
			{
				return this.sgt_dss_eindejaarsratingStatusField;
			}
			set
			{
				this.sgt_dss_eindejaarsratingStatusField = value;
				base.RaisePropertyChanged("Sgt_dss_eindejaarsratingStatus");
			}
		}

		public SetStateSgt_dss_eindejaarsratingRequest()
		{
		}
	}
}