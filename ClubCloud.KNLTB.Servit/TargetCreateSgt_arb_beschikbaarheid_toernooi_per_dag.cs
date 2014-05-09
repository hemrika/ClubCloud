using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_arb_beschikbaarheid_toernooi_per_dag : TargetCreate
	{
		private sgt_arb_beschikbaarheid_toernooi_per_dag sgt_arb_beschikbaarheid_toernooi_per_dagField;
		[XmlElement(Order = 0)]
		public sgt_arb_beschikbaarheid_toernooi_per_dag Sgt_arb_beschikbaarheid_toernooi_per_dag
		{
			get
			{
				return this.sgt_arb_beschikbaarheid_toernooi_per_dagField;
			}
			set
			{
				this.sgt_arb_beschikbaarheid_toernooi_per_dagField = value;
				base.RaisePropertyChanged("Sgt_arb_beschikbaarheid_toernooi_per_dag");
			}
		}
	}
}
