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
	public class TargetUpdateSgt_top_groepsevenement_begeleiding : TargetUpdate
	{
		private sgt_top_groepsevenement_begeleiding sgt_top_groepsevenement_begeleidingField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_top_groepsevenement_begeleiding Sgt_top_groepsevenement_begeleiding
		{
			get
			{
				return this.sgt_top_groepsevenement_begeleidingField;
			}
			set
			{
				this.sgt_top_groepsevenement_begeleidingField = value;
				base.RaisePropertyChanged("Sgt_top_groepsevenement_begeleiding");
			}
		}

		public TargetUpdateSgt_top_groepsevenement_begeleiding()
		{
		}
	}
}