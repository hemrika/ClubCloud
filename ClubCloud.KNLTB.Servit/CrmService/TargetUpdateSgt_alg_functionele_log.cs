using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_alg_functionele_log : TargetUpdate
	{
		private sgt_alg_functionele_log sgt_alg_functionele_logField;
		public sgt_alg_functionele_log Sgt_alg_functionele_log
		{
			get
			{
				return this.sgt_alg_functionele_logField;
			}
			set
			{
				this.sgt_alg_functionele_logField = value;
			}
		}
	}
}
