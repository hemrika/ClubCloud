using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_alg_rechtsvorm : TargetCreate
	{
		private sgt_alg_rechtsvorm sgt_alg_rechtsvormField;
		public sgt_alg_rechtsvorm Sgt_alg_rechtsvorm
		{
			get
			{
				return this.sgt_alg_rechtsvormField;
			}
			set
			{
				this.sgt_alg_rechtsvormField = value;
			}
		}
	}
}