using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_alg_abonnee : TargetCreate
	{
		private sgt_alg_abonnee sgt_alg_abonneeField;
		public sgt_alg_abonnee Sgt_alg_abonnee
		{
			get
			{
				return this.sgt_alg_abonneeField;
			}
			set
			{
				this.sgt_alg_abonneeField = value;
			}
		}
	}
}
