using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_alg_competentie : TargetCreate
	{
		private sgt_alg_competentie sgt_alg_competentieField;
		public sgt_alg_competentie Sgt_alg_competentie
		{
			get
			{
				return this.sgt_alg_competentieField;
			}
			set
			{
				this.sgt_alg_competentieField = value;
			}
		}
	}
}
