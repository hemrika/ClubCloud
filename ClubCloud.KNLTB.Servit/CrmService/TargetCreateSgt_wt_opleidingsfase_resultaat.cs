using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_wt_opleidingsfase_resultaat : TargetCreate
	{
		private sgt_wt_opleidingsfase_resultaat sgt_wt_opleidingsfase_resultaatField;
		public sgt_wt_opleidingsfase_resultaat Sgt_wt_opleidingsfase_resultaat
		{
			get
			{
				return this.sgt_wt_opleidingsfase_resultaatField;
			}
			set
			{
				this.sgt_wt_opleidingsfase_resultaatField = value;
			}
		}
	}
}
