using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_alg_type_bestuursorgaan : TargetCreate
	{
		private sgt_alg_type_bestuursorgaan sgt_alg_type_bestuursorgaanField;
		public sgt_alg_type_bestuursorgaan Sgt_alg_type_bestuursorgaan
		{
			get
			{
				return this.sgt_alg_type_bestuursorgaanField;
			}
			set
			{
				this.sgt_alg_type_bestuursorgaanField = value;
			}
		}
	}
}
