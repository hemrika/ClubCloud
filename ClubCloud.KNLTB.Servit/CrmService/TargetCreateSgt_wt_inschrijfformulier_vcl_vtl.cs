using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_wt_inschrijfformulier_vcl_vtl : TargetCreate
	{
		private sgt_wt_inschrijfformulier_vcl_vtl sgt_wt_inschrijfformulier_vcl_vtlField;
		public sgt_wt_inschrijfformulier_vcl_vtl Sgt_wt_inschrijfformulier_vcl_vtl
		{
			get
			{
				return this.sgt_wt_inschrijfformulier_vcl_vtlField;
			}
			set
			{
				this.sgt_wt_inschrijfformulier_vcl_vtlField = value;
			}
		}
	}
}
