using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_alg_rol_pers_relatie : TargetCreate
	{
		private sgt_alg_rol_pers_relatie sgt_alg_rol_pers_relatieField;
		public sgt_alg_rol_pers_relatie Sgt_alg_rol_pers_relatie
		{
			get
			{
				return this.sgt_alg_rol_pers_relatieField;
			}
			set
			{
				this.sgt_alg_rol_pers_relatieField = value;
			}
		}
	}
}
