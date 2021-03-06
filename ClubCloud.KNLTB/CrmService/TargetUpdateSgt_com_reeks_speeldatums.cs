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
	public class TargetUpdateSgt_com_reeks_speeldatums : TargetUpdate
	{
		private sgt_com_reeks_speeldatums sgt_com_reeks_speeldatumsField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_com_reeks_speeldatums Sgt_com_reeks_speeldatums
		{
			get
			{
				return this.sgt_com_reeks_speeldatumsField;
			}
			set
			{
				this.sgt_com_reeks_speeldatumsField = value;
				base.RaisePropertyChanged("Sgt_com_reeks_speeldatums");
			}
		}

		public TargetUpdateSgt_com_reeks_speeldatums()
		{
		}
	}
}