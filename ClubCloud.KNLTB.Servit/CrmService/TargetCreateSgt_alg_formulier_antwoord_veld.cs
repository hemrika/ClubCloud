using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_alg_formulier_antwoord_veld : TargetCreate
	{
		private sgt_alg_formulier_antwoord_veld sgt_alg_formulier_antwoord_veldField;
		public sgt_alg_formulier_antwoord_veld Sgt_alg_formulier_antwoord_veld
		{
			get
			{
				return this.sgt_alg_formulier_antwoord_veldField;
			}
			set
			{
				this.sgt_alg_formulier_antwoord_veldField = value;
			}
		}
	}
}
