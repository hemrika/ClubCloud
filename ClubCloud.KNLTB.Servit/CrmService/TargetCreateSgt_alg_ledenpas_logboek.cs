using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_alg_ledenpas_logboek : TargetCreate
	{
		private sgt_alg_ledenpas_logboek sgt_alg_ledenpas_logboekField;
		public sgt_alg_ledenpas_logboek Sgt_alg_ledenpas_logboek
		{
			get
			{
				return this.sgt_alg_ledenpas_logboekField;
			}
			set
			{
				this.sgt_alg_ledenpas_logboekField = value;
			}
		}
	}
}
