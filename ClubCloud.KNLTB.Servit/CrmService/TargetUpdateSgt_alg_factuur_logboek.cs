using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_alg_factuur_logboek : TargetUpdate
	{
		private sgt_alg_factuur_logboek sgt_alg_factuur_logboekField;
		public sgt_alg_factuur_logboek Sgt_alg_factuur_logboek
		{
			get
			{
				return this.sgt_alg_factuur_logboekField;
			}
			set
			{
				this.sgt_alg_factuur_logboekField = value;
			}
		}
	}
}
