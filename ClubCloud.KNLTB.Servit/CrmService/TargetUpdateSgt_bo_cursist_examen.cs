using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_bo_cursist_examen : TargetUpdate
	{
		private sgt_bo_cursist_examen sgt_bo_cursist_examenField;
		public sgt_bo_cursist_examen Sgt_bo_cursist_examen
		{
			get
			{
				return this.sgt_bo_cursist_examenField;
			}
			set
			{
				this.sgt_bo_cursist_examenField = value;
			}
		}
	}
}
