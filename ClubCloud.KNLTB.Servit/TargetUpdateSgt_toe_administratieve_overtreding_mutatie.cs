using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_toe_administratieve_overtreding_mutatie : TargetUpdate
	{
		private sgt_toe_administratieve_overtreding_mutatie sgt_toe_administratieve_overtreding_mutatieField;
		[XmlElement(Order = 0)]
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
	}
}
