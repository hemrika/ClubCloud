using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_com_ploegopgave : TargetUpdate
	{
		private sgt_com_ploegopgave sgt_com_ploegopgaveField;
		public sgt_com_ploegopgave Sgt_com_ploegopgave
		{
			get
			{
				return this.sgt_com_ploegopgaveField;
			}
			set
			{
				this.sgt_com_ploegopgaveField = value;
			}
		}
	}
}
