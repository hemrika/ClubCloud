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
	public class TargetCreateSgt_fac_factuur_type_factuurregel : TargetCreate
	{
		private sgt_fac_factuur_type_factuurregel sgt_fac_factuur_type_factuurregelField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_fac_factuur_type_factuurregel Sgt_fac_factuur_type_factuurregel
		{
			get
			{
				return this.sgt_fac_factuur_type_factuurregelField;
			}
			set
			{
				this.sgt_fac_factuur_type_factuurregelField = value;
				base.RaisePropertyChanged("Sgt_fac_factuur_type_factuurregel");
			}
		}

		public TargetCreateSgt_fac_factuur_type_factuurregel()
		{
		}
	}
}