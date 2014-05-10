using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_alg_speciale_baan : TargetUpdate
	{
		private sgt_alg_speciale_baan sgt_alg_speciale_baanField;
		public sgt_alg_speciale_baan Sgt_alg_speciale_baan
		{
			get
			{
				return this.sgt_alg_speciale_baanField;
			}
			set
			{
				this.sgt_alg_speciale_baanField = value;
			}
		}
	}
}
