using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_alg_formulier_met_ideal : TargetUpdate
	{
		private sgt_alg_formulier_met_ideal sgt_alg_formulier_met_idealField;
		public sgt_alg_formulier_met_ideal Sgt_alg_formulier_met_ideal
		{
			get
			{
				return this.sgt_alg_formulier_met_idealField;
			}
			set
			{
				this.sgt_alg_formulier_met_idealField = value;
			}
		}
	}
}
