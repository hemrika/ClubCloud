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
	public class TargetUpdateSgt_fac_factuurgroep_toernooisoort : TargetUpdate
	{
		private sgt_fac_factuurgroep_toernooisoort sgt_fac_factuurgroep_toernooisoortField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_fac_factuurgroep_toernooisoort Sgt_fac_factuurgroep_toernooisoort
		{
			get
			{
				return this.sgt_fac_factuurgroep_toernooisoortField;
			}
			set
			{
				this.sgt_fac_factuurgroep_toernooisoortField = value;
				base.RaisePropertyChanged("Sgt_fac_factuurgroep_toernooisoort");
			}
		}

		public TargetUpdateSgt_fac_factuurgroep_toernooisoort()
		{
		}
	}
}