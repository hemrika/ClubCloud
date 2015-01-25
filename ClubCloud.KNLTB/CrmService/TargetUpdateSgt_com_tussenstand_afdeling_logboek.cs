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
	public class TargetUpdateSgt_com_tussenstand_afdeling_logboek : TargetUpdate
	{
		private sgt_com_tussenstand_afdeling_logboek sgt_com_tussenstand_afdeling_logboekField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_com_tussenstand_afdeling_logboek Sgt_com_tussenstand_afdeling_logboek
		{
			get
			{
				return this.sgt_com_tussenstand_afdeling_logboekField;
			}
			set
			{
				this.sgt_com_tussenstand_afdeling_logboekField = value;
				base.RaisePropertyChanged("Sgt_com_tussenstand_afdeling_logboek");
			}
		}

		public TargetUpdateSgt_com_tussenstand_afdeling_logboek()
		{
		}
	}
}