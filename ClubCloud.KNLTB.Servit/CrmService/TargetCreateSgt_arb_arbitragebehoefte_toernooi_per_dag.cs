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
	public class TargetCreateSgt_arb_arbitragebehoefte_toernooi_per_dag : TargetCreate
	{
		private sgt_arb_arbitragebehoefte_toernooi_per_dag sgt_arb_arbitragebehoefte_toernooi_per_dagField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_arb_arbitragebehoefte_toernooi_per_dag Sgt_arb_arbitragebehoefte_toernooi_per_dag
		{
			get
			{
				return this.sgt_arb_arbitragebehoefte_toernooi_per_dagField;
			}
			set
			{
				this.sgt_arb_arbitragebehoefte_toernooi_per_dagField = value;
				base.RaisePropertyChanged("Sgt_arb_arbitragebehoefte_toernooi_per_dag");
			}
		}

		public TargetCreateSgt_arb_arbitragebehoefte_toernooi_per_dag()
		{
		}
	}
}