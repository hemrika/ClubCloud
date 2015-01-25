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
	public class TargetUpdateSgt_alg_bestuursorgaan : TargetUpdate
	{
		private sgt_alg_bestuursorgaan sgt_alg_bestuursorgaanField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_alg_bestuursorgaan Sgt_alg_bestuursorgaan
		{
			get
			{
				return this.sgt_alg_bestuursorgaanField;
			}
			set
			{
				this.sgt_alg_bestuursorgaanField = value;
				base.RaisePropertyChanged("Sgt_alg_bestuursorgaan");
			}
		}

		public TargetUpdateSgt_alg_bestuursorgaan()
		{
		}
	}
}