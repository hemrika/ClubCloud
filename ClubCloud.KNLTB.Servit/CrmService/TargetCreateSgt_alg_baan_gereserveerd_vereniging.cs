using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_alg_baan_gereserveerd_vereniging : TargetCreate
	{
		private sgt_alg_baan_gereserveerd_vereniging sgt_alg_baan_gereserveerd_verenigingField;
		public sgt_alg_baan_gereserveerd_vereniging Sgt_alg_baan_gereserveerd_vereniging
		{
			get
			{
				return this.sgt_alg_baan_gereserveerd_verenigingField;
			}
			set
			{
				this.sgt_alg_baan_gereserveerd_verenigingField = value;
			}
		}
	}
}