using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_bo_soort_examen : TargetCreate
	{
		private sgt_bo_soort_examen sgt_bo_soort_examenField;
		public sgt_bo_soort_examen Sgt_bo_soort_examen
		{
			get
			{
				return this.sgt_bo_soort_examenField;
			}
			set
			{
				this.sgt_bo_soort_examenField = value;
			}
		}
	}
}
