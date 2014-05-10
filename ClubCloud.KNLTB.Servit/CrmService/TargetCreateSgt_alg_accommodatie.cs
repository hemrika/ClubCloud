using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_alg_accommodatie : TargetCreate
	{
		private sgt_alg_accommodatie sgt_alg_accommodatieField;
		public sgt_alg_accommodatie Sgt_alg_accommodatie
		{
			get
			{
				return this.sgt_alg_accommodatieField;
			}
			set
			{
				this.sgt_alg_accommodatieField = value;
			}
		}
	}
}
