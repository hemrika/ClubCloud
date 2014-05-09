using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_ideal_betaling_gebeurtenisRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_ideal_betaling_gebeurtenisState sgt_alg_ideal_betaling_gebeurtenisStateField;
		private int sgt_alg_ideal_betaling_gebeurtenisStatusField;
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
		public Sgt_alg_ideal_betaling_gebeurtenisState Sgt_alg_ideal_betaling_gebeurtenisState
		{
			get
			{
				return this.sgt_alg_ideal_betaling_gebeurtenisStateField;
			}
			set
			{
				this.sgt_alg_ideal_betaling_gebeurtenisStateField = value;
				base.RaisePropertyChanged("Sgt_alg_ideal_betaling_gebeurtenisState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_alg_ideal_betaling_gebeurtenisStatus
		{
			get
			{
				return this.sgt_alg_ideal_betaling_gebeurtenisStatusField;
			}
			set
			{
				this.sgt_alg_ideal_betaling_gebeurtenisStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_ideal_betaling_gebeurtenisStatus");
			}
		}
	}
}
