using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_alg_IDEAL_betaling : TargetCreate
	{
		private sgt_alg_ideal_betaling sgt_alg_IDEAL_betalingField;
		public sgt_alg_ideal_betaling Sgt_alg_IDEAL_betaling
		{
			get
			{
				return this.sgt_alg_IDEAL_betalingField;
			}
			set
			{
				this.sgt_alg_IDEAL_betalingField = value;
			}
		}
	}
}
