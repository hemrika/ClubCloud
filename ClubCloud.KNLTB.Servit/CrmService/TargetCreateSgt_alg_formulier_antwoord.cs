using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_alg_formulier_antwoord : TargetCreate
	{
		private sgt_alg_formulier_antwoord sgt_alg_formulier_antwoordField;
		public sgt_alg_formulier_antwoord Sgt_alg_formulier_antwoord
		{
			get
			{
				return this.sgt_alg_formulier_antwoordField;
			}
			set
			{
				this.sgt_alg_formulier_antwoordField = value;
			}
		}
	}
}
