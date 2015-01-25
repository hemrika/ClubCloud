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
	public class TargetCreateSgt_wt_opleidingsgroep_docent : TargetCreate
	{
		private sgt_wt_opleidingsgroep_docent sgt_wt_opleidingsgroep_docentField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_wt_opleidingsgroep_docent Sgt_wt_opleidingsgroep_docent
		{
			get
			{
				return this.sgt_wt_opleidingsgroep_docentField;
			}
			set
			{
				this.sgt_wt_opleidingsgroep_docentField = value;
				base.RaisePropertyChanged("Sgt_wt_opleidingsgroep_docent");
			}
		}

		public TargetCreateSgt_wt_opleidingsgroep_docent()
		{
		}
	}
}