using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_com_bezoek_consul : TargetCreate
	{
		private sgt_com_bezoek_consul sgt_com_bezoek_consulField;
		[XmlElement(Order = 0)]
		public sgt_com_bezoek_consul Sgt_com_bezoek_consul
		{
			get
			{
				return this.sgt_com_bezoek_consulField;
			}
			set
			{
				this.sgt_com_bezoek_consulField = value;
				base.RaisePropertyChanged("Sgt_com_bezoek_consul");
			}
		}
	}
}
