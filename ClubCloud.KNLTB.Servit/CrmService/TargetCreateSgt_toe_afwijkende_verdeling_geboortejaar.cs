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
	public class TargetCreateSgt_toe_afwijkende_verdeling_geboortejaar : TargetCreate
	{
		private sgt_toe_afwijkende_verdeling_geboortejaar sgt_toe_afwijkende_verdeling_geboortejaarField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_toe_afwijkende_verdeling_geboortejaar Sgt_toe_afwijkende_verdeling_geboortejaar
		{
			get
			{
				return this.sgt_toe_afwijkende_verdeling_geboortejaarField;
			}
			set
			{
				this.sgt_toe_afwijkende_verdeling_geboortejaarField = value;
				base.RaisePropertyChanged("Sgt_toe_afwijkende_verdeling_geboortejaar");
			}
		}

		public TargetCreateSgt_toe_afwijkende_verdeling_geboortejaar()
		{
		}
	}
}