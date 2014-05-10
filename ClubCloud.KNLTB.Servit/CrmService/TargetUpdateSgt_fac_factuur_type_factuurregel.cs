using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_fac_factuur_type_factuurregel : TargetUpdate
	{
		private sgt_fac_factuur_type_factuurregel sgt_fac_factuur_type_factuurregelField;
		public sgt_fac_factuur_type_factuurregel Sgt_fac_factuur_type_factuurregel
		{
			get
			{
				return this.sgt_fac_factuur_type_factuurregelField;
			}
			set
			{
				this.sgt_fac_factuur_type_factuurregelField = value;
			}
		}
	}
}
