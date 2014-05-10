using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_com_competitietype : TargetCreate
	{
		private sgt_com_competitietype sgt_com_competitietypeField;
		public sgt_com_competitietype Sgt_com_competitietype
		{
			get
			{
				return this.sgt_com_competitietypeField;
			}
			set
			{
				this.sgt_com_competitietypeField = value;
			}
		}
	}
}
