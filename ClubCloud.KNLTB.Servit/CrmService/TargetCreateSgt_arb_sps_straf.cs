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
	public class TargetCreateSgt_arb_sps_straf : TargetCreate
	{
		private sgt_arb_sps_straf sgt_arb_sps_strafField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_arb_sps_straf Sgt_arb_sps_straf
		{
			get
			{
				return this.sgt_arb_sps_strafField;
			}
			set
			{
				this.sgt_arb_sps_strafField = value;
				base.RaisePropertyChanged("Sgt_arb_sps_straf");
			}
		}

		public TargetCreateSgt_arb_sps_straf()
		{
		}
	}
}