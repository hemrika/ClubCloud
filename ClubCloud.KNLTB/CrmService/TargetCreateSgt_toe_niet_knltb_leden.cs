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
	public class TargetCreateSgt_toe_niet_knltb_leden : TargetCreate
	{
		private sgt_toe_niet_knltb_leden sgt_toe_niet_knltb_ledenField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_toe_niet_knltb_leden Sgt_toe_niet_knltb_leden
		{
			get
			{
				return this.sgt_toe_niet_knltb_ledenField;
			}
			set
			{
				this.sgt_toe_niet_knltb_ledenField = value;
				base.RaisePropertyChanged("Sgt_toe_niet_knltb_leden");
			}
		}

		public TargetCreateSgt_toe_niet_knltb_leden()
		{
		}
	}
}