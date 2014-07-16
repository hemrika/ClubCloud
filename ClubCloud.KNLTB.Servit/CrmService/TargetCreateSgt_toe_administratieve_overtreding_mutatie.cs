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
	public class TargetCreateSgt_toe_administratieve_overtreding_mutatie : TargetCreate
	{
		private sgt_toe_administratieve_overtreding_mutatie sgt_toe_administratieve_overtreding_mutatieField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_toe_administratieve_overtreding_mutatie Sgt_toe_administratieve_overtreding_mutatie
		{
			get
			{
				return this.sgt_toe_administratieve_overtreding_mutatieField;
			}
			set
			{
				this.sgt_toe_administratieve_overtreding_mutatieField = value;
				base.RaisePropertyChanged("Sgt_toe_administratieve_overtreding_mutatie");
			}
		}

		public TargetCreateSgt_toe_administratieve_overtreding_mutatie()
		{
		}
	}
}