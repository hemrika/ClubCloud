using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_alg_kvk_branche : TargetCreate
	{
		private sgt_alg_kvk_branche sgt_alg_kvk_brancheField;
		public sgt_alg_kvk_branche Sgt_alg_kvk_branche
		{
			get
			{
				return this.sgt_alg_kvk_brancheField;
			}
			set
			{
				this.sgt_alg_kvk_brancheField = value;
			}
		}
	}
}
