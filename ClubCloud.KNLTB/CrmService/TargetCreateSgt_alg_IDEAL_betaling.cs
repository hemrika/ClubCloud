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
	public class TargetCreateSgt_alg_IDEAL_betaling : TargetCreate
	{
		private sgt_alg_ideal_betaling sgt_alg_IDEAL_betalingField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_alg_ideal_betaling Sgt_alg_IDEAL_betaling
		{
			get
			{
				return this.sgt_alg_IDEAL_betalingField;
			}
			set
			{
				this.sgt_alg_IDEAL_betalingField = value;
				base.RaisePropertyChanged("Sgt_alg_IDEAL_betaling");
			}
		}

		public TargetCreateSgt_alg_IDEAL_betaling()
		{
		}
	}
}