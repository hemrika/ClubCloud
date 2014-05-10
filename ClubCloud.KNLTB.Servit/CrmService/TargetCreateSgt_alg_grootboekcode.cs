using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_alg_grootboekcode : TargetCreate
	{
		private sgt_alg_grootboekcode sgt_alg_grootboekcodeField;
		public sgt_alg_grootboekcode Sgt_alg_grootboekcode
		{
			get
			{
				return this.sgt_alg_grootboekcodeField;
			}
			set
			{
				this.sgt_alg_grootboekcodeField = value;
			}
		}
	}
}
