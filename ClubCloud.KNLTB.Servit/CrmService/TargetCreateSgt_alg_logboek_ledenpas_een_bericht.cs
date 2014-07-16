using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[GeneratedCode("System.Xml", "4.0.30319.33440")]
	[Serializable]
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2007/WebServices")]
	public class TargetCreateSgt_alg_logboek_ledenpas_een_bericht : TargetCreate
	{
		private sgt_alg_logboek_ledenpas_een_bericht sgt_alg_logboek_ledenpas_een_berichtField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_alg_logboek_ledenpas_een_bericht Sgt_alg_logboek_ledenpas_een_bericht
		{
			get
			{
				return this.sgt_alg_logboek_ledenpas_een_berichtField;
			}
			set
			{
				this.sgt_alg_logboek_ledenpas_een_berichtField = value;
				base.RaisePropertyChanged("Sgt_alg_logboek_ledenpas_een_bericht");
			}
		}

		public TargetCreateSgt_alg_logboek_ledenpas_een_bericht()
		{
		}
	}
}