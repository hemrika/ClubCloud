using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_com_competitie_afsluiting : TargetCreate
	{
		private sgt_com_competitie_afsluiting sgt_com_competitie_afsluitingField;
		public sgt_com_competitie_afsluiting Sgt_com_competitie_afsluiting
		{
			get
			{
				return this.sgt_com_competitie_afsluitingField;
			}
			set
			{
				this.sgt_com_competitie_afsluitingField = value;
			}
		}
	}
}
