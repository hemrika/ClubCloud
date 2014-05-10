using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_fac_factuurgroep_toernooisoort : TargetUpdate
	{
		private sgt_fac_factuurgroep_toernooisoort sgt_fac_factuurgroep_toernooisoortField;
		public sgt_fac_factuurgroep_toernooisoort Sgt_fac_factuurgroep_toernooisoort
		{
			get
			{
				return this.sgt_fac_factuurgroep_toernooisoortField;
			}
			set
			{
				this.sgt_fac_factuurgroep_toernooisoortField = value;
			}
		}
	}
}
