using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_alg_formulier_antwoord : TargetUpdate
	{
		private sgt_alg_formulier_antwoord sgt_alg_formulier_antwoordField;
		[XmlElement(Order = 0)]
		public sgt_alg_formulier_antwoord Sgt_alg_formulier_antwoord
		{
			get
			{
				return this.sgt_alg_formulier_antwoordField;
			}
			set
			{
				this.sgt_alg_formulier_antwoordField = value;
				base.RaisePropertyChanged("Sgt_alg_formulier_antwoord");
			}
		}
	}
}
