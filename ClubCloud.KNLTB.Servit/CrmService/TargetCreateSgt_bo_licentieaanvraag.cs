using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_bo_licentieaanvraag : TargetCreate
	{
		private sgt_bo_licentieaanvraag sgt_bo_licentieaanvraagField;
		public sgt_bo_licentieaanvraag Sgt_bo_licentieaanvraag
		{
			get
			{
				return this.sgt_bo_licentieaanvraagField;
			}
			set
			{
				this.sgt_bo_licentieaanvraagField = value;
			}
		}
	}
}
