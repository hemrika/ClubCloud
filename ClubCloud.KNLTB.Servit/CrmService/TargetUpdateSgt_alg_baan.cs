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
	public class TargetUpdateSgt_alg_baan : TargetUpdate
	{
		private sgt_alg_baan sgt_alg_baanField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_alg_baan Sgt_alg_baan
		{
			get
			{
				return this.sgt_alg_baanField;
			}
			set
			{
				this.sgt_alg_baanField = value;
				base.RaisePropertyChanged("Sgt_alg_baan");
			}
		}

		public TargetUpdateSgt_alg_baan()
		{
		}
	}
}