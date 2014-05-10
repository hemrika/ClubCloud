using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_alg_kvk_plaats : TargetCreate
	{
		private sgt_alg_kvk_plaats sgt_alg_kvk_plaatsField;
		public sgt_alg_kvk_plaats Sgt_alg_kvk_plaats
		{
			get
			{
				return this.sgt_alg_kvk_plaatsField;
			}
			set
			{
				this.sgt_alg_kvk_plaatsField = value;
			}
		}
	}
}
