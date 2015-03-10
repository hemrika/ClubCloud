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
	public class TargetUpdateSgt_alg_lookupcontrol_filter : TargetUpdate
	{
		private sgt_alg_lookupcontrol_filter sgt_alg_lookupcontrol_filterField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_alg_lookupcontrol_filter Sgt_alg_lookupcontrol_filter
		{
			get
			{
				return this.sgt_alg_lookupcontrol_filterField;
			}
			set
			{
				this.sgt_alg_lookupcontrol_filterField = value;
				base.RaisePropertyChanged("Sgt_alg_lookupcontrol_filter");
			}
		}

		public TargetUpdateSgt_alg_lookupcontrol_filter()
		{
		}
	}
}