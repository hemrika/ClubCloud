using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_wt_opleidingsgroep_docent : TargetCreate
	{
		private sgt_wt_opleidingsgroep_docent sgt_wt_opleidingsgroep_docentField;
		public sgt_wt_opleidingsgroep_docent Sgt_wt_opleidingsgroep_docent
		{
			get
			{
				return this.sgt_wt_opleidingsgroep_docentField;
			}
			set
			{
				this.sgt_wt_opleidingsgroep_docentField = value;
			}
		}
	}
}
