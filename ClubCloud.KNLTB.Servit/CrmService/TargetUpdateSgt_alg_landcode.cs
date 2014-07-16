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
	public class TargetUpdateSgt_alg_landcode : TargetUpdate
	{
		private sgt_alg_landcode sgt_alg_landcodeField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_alg_landcode Sgt_alg_landcode
		{
			get
			{
				return this.sgt_alg_landcodeField;
			}
			set
			{
				this.sgt_alg_landcodeField = value;
				base.RaisePropertyChanged("Sgt_alg_landcode");
			}
		}

		public TargetUpdateSgt_alg_landcode()
		{
		}
	}
}