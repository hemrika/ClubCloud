using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_betalingsvoorwaardeRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_betalingsvoorwaardeState sgt_alg_betalingsvoorwaardeStateField;
		private int sgt_alg_betalingsvoorwaardeStatusField;
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
		public Sgt_alg_betalingsvoorwaardeState Sgt_alg_betalingsvoorwaardeState
		{
			get
			{
				return this.sgt_alg_betalingsvoorwaardeStateField;
			}
			set
			{
				this.sgt_alg_betalingsvoorwaardeStateField = value;
				base.RaisePropertyChanged("Sgt_alg_betalingsvoorwaardeState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_alg_betalingsvoorwaardeStatus
		{
			get
			{
				return this.sgt_alg_betalingsvoorwaardeStatusField;
			}
			set
			{
				this.sgt_alg_betalingsvoorwaardeStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_betalingsvoorwaardeStatus");
			}
		}
	}
}
