using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_alg_servit1_contacthistorie : TargetCreate
	{
		private sgt_alg_servit1_contacthistorie sgt_alg_servit1_contacthistorieField;
		public sgt_alg_servit1_contacthistorie Sgt_alg_servit1_contacthistorie
		{
			get
			{
				return this.sgt_alg_servit1_contacthistorieField;
			}
			set
			{
				this.sgt_alg_servit1_contacthistorieField = value;
			}
		}
	}
}
