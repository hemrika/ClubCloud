using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_arb_arbitragebehoefte_toernooi_per_dag : TargetUpdate
	{
		private sgt_arb_arbitragebehoefte_toernooi_per_dag sgt_arb_arbitragebehoefte_toernooi_per_dagField;
		public sgt_arb_arbitragebehoefte_toernooi_per_dag Sgt_arb_arbitragebehoefte_toernooi_per_dag
		{
			get
			{
				return this.sgt_arb_arbitragebehoefte_toernooi_per_dagField;
			}
			set
			{
				this.sgt_arb_arbitragebehoefte_toernooi_per_dagField = value;
			}
		}
	}
}
