using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_com_competitie_districtsselectie : TargetCreate
	{
		private sgt_com_competitie_districtsselectie sgt_com_competitie_districtsselectieField;
		public sgt_com_competitie_districtsselectie Sgt_com_competitie_districtsselectie
		{
			get
			{
				return this.sgt_com_competitie_districtsselectieField;
			}
			set
			{
				this.sgt_com_competitie_districtsselectieField = value;
			}
		}
	}
}
