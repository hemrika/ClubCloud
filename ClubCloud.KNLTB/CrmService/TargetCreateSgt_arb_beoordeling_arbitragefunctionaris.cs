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
	public class TargetCreateSgt_arb_beoordeling_arbitragefunctionaris : TargetCreate
	{
		private sgt_arb_beoordeling_arbitragefunctionaris sgt_arb_beoordeling_arbitragefunctionarisField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_arb_beoordeling_arbitragefunctionaris Sgt_arb_beoordeling_arbitragefunctionaris
		{
			get
			{
				return this.sgt_arb_beoordeling_arbitragefunctionarisField;
			}
			set
			{
				this.sgt_arb_beoordeling_arbitragefunctionarisField = value;
				base.RaisePropertyChanged("Sgt_arb_beoordeling_arbitragefunctionaris");
			}
		}

		public TargetCreateSgt_arb_beoordeling_arbitragefunctionaris()
		{
		}
	}
}