using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_toe_toernooien_reglementaire_arbitrage : TargetUpdate
	{
		private sgt_toe_toernooien_reglementaire_arbitrage sgt_toe_toernooien_reglementaire_arbitrageField;
		public sgt_toe_toernooien_reglementaire_arbitrage Sgt_toe_toernooien_reglementaire_arbitrage
		{
			get
			{
				return this.sgt_toe_toernooien_reglementaire_arbitrageField;
			}
			set
			{
				this.sgt_toe_toernooien_reglementaire_arbitrageField = value;
			}
		}
	}
}
