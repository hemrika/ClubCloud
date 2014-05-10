using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_toe_afwijkende_verdeling_geboortejaar : TargetUpdate
	{
		private sgt_toe_afwijkende_verdeling_geboortejaar sgt_toe_afwijkende_verdeling_geboortejaarField;
		public sgt_toe_afwijkende_verdeling_geboortejaar Sgt_toe_afwijkende_verdeling_geboortejaar
		{
			get
			{
				return this.sgt_toe_afwijkende_verdeling_geboortejaarField;
			}
			set
			{
				this.sgt_toe_afwijkende_verdeling_geboortejaarField = value;
			}
		}
	}
}
