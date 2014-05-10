using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_bo_voorkeur_opleidingsgroep : TargetCreate
	{
		private sgt_bo_voorkeur_opleidingsgroep sgt_bo_voorkeur_opleidingsgroepField;
		public sgt_bo_voorkeur_opleidingsgroep Sgt_bo_voorkeur_opleidingsgroep
		{
			get
			{
				return this.sgt_bo_voorkeur_opleidingsgroepField;
			}
			set
			{
				this.sgt_bo_voorkeur_opleidingsgroepField = value;
			}
		}
	}
}
