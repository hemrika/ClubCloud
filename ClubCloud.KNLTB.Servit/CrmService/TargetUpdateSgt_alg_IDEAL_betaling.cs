using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_alg_IDEAL_betaling : TargetUpdate
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
