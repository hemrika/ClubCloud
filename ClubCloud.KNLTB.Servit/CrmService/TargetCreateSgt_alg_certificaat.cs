using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_alg_certificaat : TargetCreate
	{
		private sgt_alg_certificaat sgt_alg_certificaatField;
		public sgt_alg_certificaat Sgt_alg_certificaat
		{
			get
			{
				return this.sgt_alg_certificaatField;
			}
			set
			{
				this.sgt_alg_certificaatField = value;
			}
		}
	}
}
