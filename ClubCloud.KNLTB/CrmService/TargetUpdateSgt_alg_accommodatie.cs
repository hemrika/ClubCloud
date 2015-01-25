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
	public class TargetUpdateSgt_alg_accommodatie : TargetUpdate
	{
		private sgt_alg_accommodatie sgt_alg_accommodatieField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_alg_accommodatie Sgt_alg_accommodatie
		{
			get
			{
				return this.sgt_alg_accommodatieField;
			}
			set
			{
				this.sgt_alg_accommodatieField = value;
				base.RaisePropertyChanged("Sgt_alg_accommodatie");
			}
		}

		public TargetUpdateSgt_alg_accommodatie()
		{
		}
	}
}