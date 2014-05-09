using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_inschrijf_functie_gebeurtenistypeRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_inschrijf_functie_gebeurtenistypeState sgt_alg_inschrijf_functie_gebeurtenistypeStateField;
		private int sgt_alg_inschrijf_functie_gebeurtenistypeStatusField;
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
		public Sgt_alg_inschrijf_functie_gebeurtenistypeState Sgt_alg_inschrijf_functie_gebeurtenistypeState
		{
			get
			{
				return this.sgt_alg_inschrijf_functie_gebeurtenistypeStateField;
			}
			set
			{
				this.sgt_alg_inschrijf_functie_gebeurtenistypeStateField = value;
				base.RaisePropertyChanged("Sgt_alg_inschrijf_functie_gebeurtenistypeState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_alg_inschrijf_functie_gebeurtenistypeStatus
		{
			get
			{
				return this.sgt_alg_inschrijf_functie_gebeurtenistypeStatusField;
			}
			set
			{
				this.sgt_alg_inschrijf_functie_gebeurtenistypeStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_inschrijf_functie_gebeurtenistypeStatus");
			}
		}
	}
}
