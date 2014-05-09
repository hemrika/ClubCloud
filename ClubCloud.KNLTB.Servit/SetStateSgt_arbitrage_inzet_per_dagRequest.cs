using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_arbitrage_inzet_per_dagRequest : Request
	{
		private Guid entityIdField;
		private Sgt_arbitrage_inzet_per_dagState sgt_arbitrage_inzet_per_dagStateField;
		private int sgt_arbitrage_inzet_per_dagStatusField;
		[XmlElement(Order = 0)]
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
		[XmlElement(Order = 1)]
		public Sgt_arbitrage_inzet_per_dagState Sgt_arbitrage_inzet_per_dagState
		{
			get
			{
				return this.sgt_arbitrage_inzet_per_dagStateField;
			}
			set
			{
				this.sgt_arbitrage_inzet_per_dagStateField = value;
				base.RaisePropertyChanged("Sgt_arbitrage_inzet_per_dagState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_arbitrage_inzet_per_dagStatus
		{
			get
			{
				return this.sgt_arbitrage_inzet_per_dagStatusField;
			}
			set
			{
				this.sgt_arbitrage_inzet_per_dagStatusField = value;
				base.RaisePropertyChanged("Sgt_arbitrage_inzet_per_dagStatus");
			}
		}
	}
}
