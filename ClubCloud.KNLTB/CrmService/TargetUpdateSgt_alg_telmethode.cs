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
	public class TargetUpdateSgt_alg_telmethode : TargetUpdate
	{
		private sgt_alg_telmethode sgt_alg_telmethodeField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_alg_telmethode Sgt_alg_telmethode
		{
			get
			{
				return this.sgt_alg_telmethodeField;
			}
			set
			{
				this.sgt_alg_telmethodeField = value;
				base.RaisePropertyChanged("Sgt_alg_telmethode");
			}
		}

		public TargetUpdateSgt_alg_telmethode()
		{
		}
	}
}