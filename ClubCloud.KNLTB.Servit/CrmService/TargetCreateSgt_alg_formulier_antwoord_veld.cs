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
	public class TargetCreateSgt_alg_formulier_antwoord_veld : TargetCreate
	{
		private sgt_alg_formulier_antwoord_veld sgt_alg_formulier_antwoord_veldField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_alg_formulier_antwoord_veld Sgt_alg_formulier_antwoord_veld
		{
			get
			{
				return this.sgt_alg_formulier_antwoord_veldField;
			}
			set
			{
				this.sgt_alg_formulier_antwoord_veldField = value;
				base.RaisePropertyChanged("Sgt_alg_formulier_antwoord_veld");
			}
		}

		public TargetCreateSgt_alg_formulier_antwoord_veld()
		{
		}
	}
}