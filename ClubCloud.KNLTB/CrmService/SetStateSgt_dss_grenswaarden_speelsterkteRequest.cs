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
	public class SetStateSgt_dss_grenswaarden_speelsterkteRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_dss_grenswaarden_speelsterkteState sgt_dss_grenswaarden_speelsterkteStateField;

		private int sgt_dss_grenswaarden_speelsterkteStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_dss_grenswaarden_speelsterkteState Sgt_dss_grenswaarden_speelsterkteState
		{
			get
			{
				return this.sgt_dss_grenswaarden_speelsterkteStateField;
			}
			set
			{
				this.sgt_dss_grenswaarden_speelsterkteStateField = value;
				base.RaisePropertyChanged("Sgt_dss_grenswaarden_speelsterkteState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_dss_grenswaarden_speelsterkteStatus
		{
			get
			{
				return this.sgt_dss_grenswaarden_speelsterkteStatusField;
			}
			set
			{
				this.sgt_dss_grenswaarden_speelsterkteStatusField = value;
				base.RaisePropertyChanged("Sgt_dss_grenswaarden_speelsterkteStatus");
			}
		}

		public SetStateSgt_dss_grenswaarden_speelsterkteRequest()
		{
		}
	}
}