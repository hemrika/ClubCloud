using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_com_competitie_indeling : TargetCreate
	{
		private sgt_com_competitie_indeling sgt_com_competitie_indelingField;
		public sgt_com_competitie_indeling Sgt_com_competitie_indeling
		{
			get
			{
				return this.sgt_com_competitie_indelingField;
			}
			set
			{
				this.sgt_com_competitie_indelingField = value;
			}
		}
	}
}
