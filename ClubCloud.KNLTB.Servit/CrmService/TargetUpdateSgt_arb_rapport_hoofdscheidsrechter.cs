using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_arb_rapport_hoofdscheidsrechter : TargetUpdate
	{
		private sgt_arb_rapport_hoofdscheidsrechter sgt_arb_rapport_hoofdscheidsrechterField;
		public sgt_arb_rapport_hoofdscheidsrechter Sgt_arb_rapport_hoofdscheidsrechter
		{
			get
			{
				return this.sgt_arb_rapport_hoofdscheidsrechterField;
			}
			set
			{
				this.sgt_arb_rapport_hoofdscheidsrechterField = value;
			}
		}
	}
}
