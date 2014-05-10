using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_com_baan_gereserveerd_competitie : TargetCreate
	{
		private sgt_com_baan_gereserveerd_competitie sgt_com_baan_gereserveerd_competitieField;
		public sgt_com_baan_gereserveerd_competitie Sgt_com_baan_gereserveerd_competitie
		{
			get
			{
				return this.sgt_com_baan_gereserveerd_competitieField;
			}
			set
			{
				this.sgt_com_baan_gereserveerd_competitieField = value;
			}
		}
	}
}
