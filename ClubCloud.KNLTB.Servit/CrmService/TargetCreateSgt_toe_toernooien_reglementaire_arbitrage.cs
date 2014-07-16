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
	public class TargetCreateSgt_toe_toernooien_reglementaire_arbitrage : TargetCreate
	{
		private sgt_toe_toernooien_reglementaire_arbitrage sgt_toe_toernooien_reglementaire_arbitrageField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_toe_toernooien_reglementaire_arbitrage Sgt_toe_toernooien_reglementaire_arbitrage
		{
			get
			{
				return this.sgt_toe_toernooien_reglementaire_arbitrageField;
			}
			set
			{
				this.sgt_toe_toernooien_reglementaire_arbitrageField = value;
				base.RaisePropertyChanged("Sgt_toe_toernooien_reglementaire_arbitrage");
			}
		}

		public TargetCreateSgt_toe_toernooien_reglementaire_arbitrage()
		{
		}
	}
}