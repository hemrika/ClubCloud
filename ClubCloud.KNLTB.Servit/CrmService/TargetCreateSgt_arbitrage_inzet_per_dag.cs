using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_arbitrage_inzet_per_dag : TargetCreate
	{
		private sgt_arbitrage_inzet_per_dag sgt_arbitrage_inzet_per_dagField;
		public sgt_arbitrage_inzet_per_dag Sgt_arbitrage_inzet_per_dag
		{
			get
			{
				return this.sgt_arbitrage_inzet_per_dagField;
			}
			set
			{
				this.sgt_arbitrage_inzet_per_dagField = value;
			}
		}
	}
}
