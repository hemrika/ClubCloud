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
	public class TargetUpdateSgt_alg_functie : TargetUpdate
	{
		private sgt_alg_functie sgt_alg_functieField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_alg_functie Sgt_alg_functie
		{
			get
			{
				return this.sgt_alg_functieField;
			}
			set
			{
				this.sgt_alg_functieField = value;
				base.RaisePropertyChanged("Sgt_alg_functie");
			}
		}

		public TargetUpdateSgt_alg_functie()
		{
		}
	}
}