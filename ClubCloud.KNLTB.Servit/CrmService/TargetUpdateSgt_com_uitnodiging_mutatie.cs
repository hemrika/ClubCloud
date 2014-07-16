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
	public class TargetUpdateSgt_com_uitnodiging_mutatie : TargetUpdate
	{
		private sgt_com_uitnodiging_mutatie sgt_com_uitnodiging_mutatieField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_com_uitnodiging_mutatie Sgt_com_uitnodiging_mutatie
		{
			get
			{
				return this.sgt_com_uitnodiging_mutatieField;
			}
			set
			{
				this.sgt_com_uitnodiging_mutatieField = value;
				base.RaisePropertyChanged("Sgt_com_uitnodiging_mutatie");
			}
		}

		public TargetUpdateSgt_com_uitnodiging_mutatie()
		{
		}
	}
}