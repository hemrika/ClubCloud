using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_alg_ad_groep : TargetCreate
	{
		private sgt_alg_ad_groep sgt_alg_ad_groepField;
		public sgt_alg_ad_groep Sgt_alg_ad_groep
		{
			get
			{
				return this.sgt_alg_ad_groepField;
			}
			set
			{
				this.sgt_alg_ad_groepField = value;
			}
		}
	}
}
