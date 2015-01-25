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
	public class TargetUpdateSgt_alg_verzendwijze : TargetUpdate
	{
		private sgt_alg_verzendwijze sgt_alg_verzendwijzeField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_alg_verzendwijze Sgt_alg_verzendwijze
		{
			get
			{
				return this.sgt_alg_verzendwijzeField;
			}
			set
			{
				this.sgt_alg_verzendwijzeField = value;
				base.RaisePropertyChanged("Sgt_alg_verzendwijze");
			}
		}

		public TargetUpdateSgt_alg_verzendwijze()
		{
		}
	}
}