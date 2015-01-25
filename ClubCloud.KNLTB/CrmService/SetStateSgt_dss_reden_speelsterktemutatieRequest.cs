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
	public class SetStateSgt_dss_reden_speelsterktemutatieRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_dss_reden_speelsterktemutatieState sgt_dss_reden_speelsterktemutatieStateField;

		private int sgt_dss_reden_speelsterktemutatieStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_dss_reden_speelsterktemutatieState Sgt_dss_reden_speelsterktemutatieState
		{
			get
			{
				return this.sgt_dss_reden_speelsterktemutatieStateField;
			}
			set
			{
				this.sgt_dss_reden_speelsterktemutatieStateField = value;
				base.RaisePropertyChanged("Sgt_dss_reden_speelsterktemutatieState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_dss_reden_speelsterktemutatieStatus
		{
			get
			{
				return this.sgt_dss_reden_speelsterktemutatieStatusField;
			}
			set
			{
				this.sgt_dss_reden_speelsterktemutatieStatusField = value;
				base.RaisePropertyChanged("Sgt_dss_reden_speelsterktemutatieStatus");
			}
		}

		public SetStateSgt_dss_reden_speelsterktemutatieRequest()
		{
		}
	}
}