using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_alg_inschrijf_functie_gebeurtenistype : TargetCreate
	{
		private sgt_alg_inschrijf_functie_gebeurtenistype sgt_alg_inschrijf_functie_gebeurtenistypeField;
		public sgt_alg_inschrijf_functie_gebeurtenistype Sgt_alg_inschrijf_functie_gebeurtenistype
		{
			get
			{
				return this.sgt_alg_inschrijf_functie_gebeurtenistypeField;
			}
			set
			{
				this.sgt_alg_inschrijf_functie_gebeurtenistypeField = value;
			}
		}
	}
}
