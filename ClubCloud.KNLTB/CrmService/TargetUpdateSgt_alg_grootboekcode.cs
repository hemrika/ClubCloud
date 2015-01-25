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
	public class TargetUpdateSgt_alg_grootboekcode : TargetUpdate
	{
		private sgt_alg_grootboekcode sgt_alg_grootboekcodeField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_alg_grootboekcode Sgt_alg_grootboekcode
		{
			get
			{
				return this.sgt_alg_grootboekcodeField;
			}
			set
			{
				this.sgt_alg_grootboekcodeField = value;
				base.RaisePropertyChanged("Sgt_alg_grootboekcode");
			}
		}

		public TargetUpdateSgt_alg_grootboekcode()
		{
		}
	}
}