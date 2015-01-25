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
	public class TargetUpdateSgt_alg_ledenpas_lid : TargetUpdate
	{
		private sgt_alg_ledenpas_lid sgt_alg_ledenpas_lidField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_alg_ledenpas_lid Sgt_alg_ledenpas_lid
		{
			get
			{
				return this.sgt_alg_ledenpas_lidField;
			}
			set
			{
				this.sgt_alg_ledenpas_lidField = value;
				base.RaisePropertyChanged("Sgt_alg_ledenpas_lid");
			}
		}

		public TargetUpdateSgt_alg_ledenpas_lid()
		{
		}
	}
}