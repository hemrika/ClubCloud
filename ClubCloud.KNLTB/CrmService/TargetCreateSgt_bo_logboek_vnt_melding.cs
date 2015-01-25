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
	public class TargetCreateSgt_bo_logboek_vnt_melding : TargetCreate
	{
		private sgt_bo_logboek_vnt_melding sgt_bo_logboek_vnt_meldingField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_bo_logboek_vnt_melding Sgt_bo_logboek_vnt_melding
		{
			get
			{
				return this.sgt_bo_logboek_vnt_meldingField;
			}
			set
			{
				this.sgt_bo_logboek_vnt_meldingField = value;
				base.RaisePropertyChanged("Sgt_bo_logboek_vnt_melding");
			}
		}

		public TargetCreateSgt_bo_logboek_vnt_melding()
		{
		}
	}
}