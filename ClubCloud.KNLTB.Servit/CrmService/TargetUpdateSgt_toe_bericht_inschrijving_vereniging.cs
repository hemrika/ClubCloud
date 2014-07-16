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
	public class TargetUpdateSgt_toe_bericht_inschrijving_vereniging : TargetUpdate
	{
		private sgt_toe_bericht_inschrijving_vereniging sgt_toe_bericht_inschrijving_verenigingField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_toe_bericht_inschrijving_vereniging Sgt_toe_bericht_inschrijving_vereniging
		{
			get
			{
				return this.sgt_toe_bericht_inschrijving_verenigingField;
			}
			set
			{
				this.sgt_toe_bericht_inschrijving_verenigingField = value;
				base.RaisePropertyChanged("Sgt_toe_bericht_inschrijving_vereniging");
			}
		}

		public TargetUpdateSgt_toe_bericht_inschrijving_vereniging()
		{
		}
	}
}