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
	public class TargetUpdateSgt_com_deelname_niet_knltb_lid : TargetUpdate
	{
		private sgt_com_deelname_niet_knltb_lid sgt_com_deelname_niet_knltb_lidField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_com_deelname_niet_knltb_lid Sgt_com_deelname_niet_knltb_lid
		{
			get
			{
				return this.sgt_com_deelname_niet_knltb_lidField;
			}
			set
			{
				this.sgt_com_deelname_niet_knltb_lidField = value;
				base.RaisePropertyChanged("Sgt_com_deelname_niet_knltb_lid");
			}
		}

		public TargetUpdateSgt_com_deelname_niet_knltb_lid()
		{
		}
	}
}