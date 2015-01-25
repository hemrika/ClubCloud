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
	public class TargetUpdateSw_lookuplabels : TargetUpdate
	{
		private sw_lookuplabels sw_lookuplabelsField;

		[XmlElement] //[XmlElement(Order=0)]
		public sw_lookuplabels Sw_lookuplabels
		{
			get
			{
				return this.sw_lookuplabelsField;
			}
			set
			{
				this.sw_lookuplabelsField = value;
				base.RaisePropertyChanged("Sw_lookuplabels");
			}
		}

		public TargetUpdateSw_lookuplabels()
		{
		}
	}
}