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
	public class TargetUpdateSgt_alg_logboek_ledenpas_retour : TargetUpdate
	{
		private sgt_alg_logboek_ledenpas_retour sgt_alg_logboek_ledenpas_retourField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_alg_logboek_ledenpas_retour Sgt_alg_logboek_ledenpas_retour
		{
			get
			{
				return this.sgt_alg_logboek_ledenpas_retourField;
			}
			set
			{
				this.sgt_alg_logboek_ledenpas_retourField = value;
				base.RaisePropertyChanged("Sgt_alg_logboek_ledenpas_retour");
			}
		}

		public TargetUpdateSgt_alg_logboek_ledenpas_retour()
		{
		}
	}
}