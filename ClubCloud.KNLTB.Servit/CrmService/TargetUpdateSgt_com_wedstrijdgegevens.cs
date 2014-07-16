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
	public class TargetUpdateSgt_com_wedstrijdgegevens : TargetUpdate
	{
		private sgt_com_wedstrijdgegevens sgt_com_wedstrijdgegevensField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_com_wedstrijdgegevens Sgt_com_wedstrijdgegevens
		{
			get
			{
				return this.sgt_com_wedstrijdgegevensField;
			}
			set
			{
				this.sgt_com_wedstrijdgegevensField = value;
				base.RaisePropertyChanged("Sgt_com_wedstrijdgegevens");
			}
		}

		public TargetUpdateSgt_com_wedstrijdgegevens()
		{
		}
	}
}