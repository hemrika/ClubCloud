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
	public class TargetUpdateSgt_wt_inschrijfformulier_vcl_vtl : TargetUpdate
	{
		private sgt_wt_inschrijfformulier_vcl_vtl sgt_wt_inschrijfformulier_vcl_vtlField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_wt_inschrijfformulier_vcl_vtl Sgt_wt_inschrijfformulier_vcl_vtl
		{
			get
			{
				return this.sgt_wt_inschrijfformulier_vcl_vtlField;
			}
			set
			{
				this.sgt_wt_inschrijfformulier_vcl_vtlField = value;
				base.RaisePropertyChanged("Sgt_wt_inschrijfformulier_vcl_vtl");
			}
		}

		public TargetUpdateSgt_wt_inschrijfformulier_vcl_vtl()
		{
		}
	}
}