using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_logboek_ecampus_resultaten_melding : TargetUpdate
	{
		private sgt_logboek_ecampus_resultaten_melding sgt_logboek_ecampus_resultaten_meldingField;
		public sgt_logboek_ecampus_resultaten_melding Sgt_logboek_ecampus_resultaten_melding
		{
			get
			{
				return this.sgt_logboek_ecampus_resultaten_meldingField;
			}
			set
			{
				this.sgt_logboek_ecampus_resultaten_meldingField = value;
			}
		}
	}
}
