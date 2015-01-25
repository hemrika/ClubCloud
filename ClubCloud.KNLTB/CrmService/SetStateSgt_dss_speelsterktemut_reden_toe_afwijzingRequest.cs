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
	public class SetStateSgt_dss_speelsterktemut_reden_toe_afwijzingRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_dss_speelsterktemut_reden_toe_afwijzingState sgt_dss_speelsterktemut_reden_toe_afwijzingStateField;

		private int sgt_dss_speelsterktemut_reden_toe_afwijzingStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_dss_speelsterktemut_reden_toe_afwijzingState Sgt_dss_speelsterktemut_reden_toe_afwijzingState
		{
			get
			{
				return this.sgt_dss_speelsterktemut_reden_toe_afwijzingStateField;
			}
			set
			{
				this.sgt_dss_speelsterktemut_reden_toe_afwijzingStateField = value;
				base.RaisePropertyChanged("Sgt_dss_speelsterktemut_reden_toe_afwijzingState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_dss_speelsterktemut_reden_toe_afwijzingStatus
		{
			get
			{
				return this.sgt_dss_speelsterktemut_reden_toe_afwijzingStatusField;
			}
			set
			{
				this.sgt_dss_speelsterktemut_reden_toe_afwijzingStatusField = value;
				base.RaisePropertyChanged("Sgt_dss_speelsterktemut_reden_toe_afwijzingStatus");
			}
		}

		public SetStateSgt_dss_speelsterktemut_reden_toe_afwijzingRequest()
		{
		}
	}
}