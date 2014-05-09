using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_logboek_ecampus_resultaten_melding : TargetCreate
	{
		private sgt_logboek_ecampus_resultaten_melding sgt_logboek_ecampus_resultaten_meldingField;
		[XmlElement(Order = 0)]
		public sgt_logboek_ecampus_resultaten_melding Sgt_logboek_ecampus_resultaten_melding
		{
			get
			{
				return this.sgt_logboek_ecampus_resultaten_meldingField;
			}
			set
			{
				this.sgt_logboek_ecampus_resultaten_meldingField = value;
				base.RaisePropertyChanged("Sgt_logboek_ecampus_resultaten_melding");
			}
		}
	}
}
