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
	public class SetStateSgt_arb_arbitragebehoefte_toernooi_per_dagRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_arb_arbitragebehoefte_toernooi_per_dagState sgt_arb_arbitragebehoefte_toernooi_per_dagStateField;

		private int sgt_arb_arbitragebehoefte_toernooi_per_dagStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_arb_arbitragebehoefte_toernooi_per_dagState Sgt_arb_arbitragebehoefte_toernooi_per_dagState
		{
			get
			{
				return this.sgt_arb_arbitragebehoefte_toernooi_per_dagStateField;
			}
			set
			{
				this.sgt_arb_arbitragebehoefte_toernooi_per_dagStateField = value;
				base.RaisePropertyChanged("Sgt_arb_arbitragebehoefte_toernooi_per_dagState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_arb_arbitragebehoefte_toernooi_per_dagStatus
		{
			get
			{
				return this.sgt_arb_arbitragebehoefte_toernooi_per_dagStatusField;
			}
			set
			{
				this.sgt_arb_arbitragebehoefte_toernooi_per_dagStatusField = value;
				base.RaisePropertyChanged("Sgt_arb_arbitragebehoefte_toernooi_per_dagStatus");
			}
		}

		public SetStateSgt_arb_arbitragebehoefte_toernooi_per_dagRequest()
		{
		}
	}
}