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
	public class TargetUpdateSgt_toe_inschrijf_functie_toernooisoort : TargetUpdate
	{
		private sgt_toe_inschrijf_functie_toernooisoort sgt_toe_inschrijf_functie_toernooisoortField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_toe_inschrijf_functie_toernooisoort Sgt_toe_inschrijf_functie_toernooisoort
		{
			get
			{
				return this.sgt_toe_inschrijf_functie_toernooisoortField;
			}
			set
			{
				this.sgt_toe_inschrijf_functie_toernooisoortField = value;
				base.RaisePropertyChanged("Sgt_toe_inschrijf_functie_toernooisoort");
			}
		}

		public TargetUpdateSgt_toe_inschrijf_functie_toernooisoort()
		{
		}
	}
}