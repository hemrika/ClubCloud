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
	public class TargetUpdateSgt_alg_ledenpas_vereniging : TargetUpdate
	{
		private sgt_alg_ledenpas_vereniging sgt_alg_ledenpas_verenigingField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_alg_ledenpas_vereniging Sgt_alg_ledenpas_vereniging
		{
			get
			{
				return this.sgt_alg_ledenpas_verenigingField;
			}
			set
			{
				this.sgt_alg_ledenpas_verenigingField = value;
				base.RaisePropertyChanged("Sgt_alg_ledenpas_vereniging");
			}
		}

		public TargetUpdateSgt_alg_ledenpas_vereniging()
		{
		}
	}
}