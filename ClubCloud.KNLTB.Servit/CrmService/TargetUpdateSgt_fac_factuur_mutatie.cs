using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_fac_factuur_mutatie : TargetUpdate
	{
		private sgt_fac_factuur_mutatie sgt_fac_factuur_mutatieField;
		public sgt_fac_factuur_mutatie Sgt_fac_factuur_mutatie
		{
			get
			{
				return this.sgt_fac_factuur_mutatieField;
			}
			set
			{
				this.sgt_fac_factuur_mutatieField = value;
			}
		}
	}
}