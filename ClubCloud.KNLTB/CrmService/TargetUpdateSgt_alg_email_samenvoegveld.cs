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
	public class TargetUpdateSgt_alg_email_samenvoegveld : TargetUpdate
	{
		private sgt_alg_email_samenvoegveld sgt_alg_email_samenvoegveldField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_alg_email_samenvoegveld Sgt_alg_email_samenvoegveld
		{
			get
			{
				return this.sgt_alg_email_samenvoegveldField;
			}
			set
			{
				this.sgt_alg_email_samenvoegveldField = value;
				base.RaisePropertyChanged("Sgt_alg_email_samenvoegveld");
			}
		}

		public TargetUpdateSgt_alg_email_samenvoegveld()
		{
		}
	}
}