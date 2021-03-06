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
	public class TargetUpdateSgt_alg_custom_config : TargetUpdate
	{
		private sgt_alg_custom_config sgt_alg_custom_configField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_alg_custom_config Sgt_alg_custom_config
		{
			get
			{
				return this.sgt_alg_custom_configField;
			}
			set
			{
				this.sgt_alg_custom_configField = value;
				base.RaisePropertyChanged("Sgt_alg_custom_config");
			}
		}

		public TargetUpdateSgt_alg_custom_config()
		{
		}
	}
}