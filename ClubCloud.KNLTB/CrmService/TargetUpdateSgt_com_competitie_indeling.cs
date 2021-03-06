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
	public class TargetUpdateSgt_com_competitie_indeling : TargetUpdate
	{
		private sgt_com_competitie_indeling sgt_com_competitie_indelingField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_com_competitie_indeling Sgt_com_competitie_indeling
		{
			get
			{
				return this.sgt_com_competitie_indelingField;
			}
			set
			{
				this.sgt_com_competitie_indelingField = value;
				base.RaisePropertyChanged("Sgt_com_competitie_indeling");
			}
		}

		public TargetUpdateSgt_com_competitie_indeling()
		{
		}
	}
}