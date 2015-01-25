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
	public class SetStateSgt_dss_speelsterktemutatie_afhandelingRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_dss_speelsterktemutatie_afhandelingState sgt_dss_speelsterktemutatie_afhandelingStateField;

		private int sgt_dss_speelsterktemutatie_afhandelingStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_dss_speelsterktemutatie_afhandelingState Sgt_dss_speelsterktemutatie_afhandelingState
		{
			get
			{
				return this.sgt_dss_speelsterktemutatie_afhandelingStateField;
			}
			set
			{
				this.sgt_dss_speelsterktemutatie_afhandelingStateField = value;
				base.RaisePropertyChanged("Sgt_dss_speelsterktemutatie_afhandelingState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_dss_speelsterktemutatie_afhandelingStatus
		{
			get
			{
				return this.sgt_dss_speelsterktemutatie_afhandelingStatusField;
			}
			set
			{
				this.sgt_dss_speelsterktemutatie_afhandelingStatusField = value;
				base.RaisePropertyChanged("Sgt_dss_speelsterktemutatie_afhandelingStatus");
			}
		}

		public SetStateSgt_dss_speelsterktemutatie_afhandelingRequest()
		{
		}
	}
}