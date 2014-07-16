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
	public class TargetUpdateSgt_dss_eindejaarsrating : TargetUpdate
	{
		private sgt_dss_eindejaarsrating sgt_dss_eindejaarsratingField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_dss_eindejaarsrating Sgt_dss_eindejaarsrating
		{
			get
			{
				return this.sgt_dss_eindejaarsratingField;
			}
			set
			{
				this.sgt_dss_eindejaarsratingField = value;
				base.RaisePropertyChanged("Sgt_dss_eindejaarsrating");
			}
		}

		public TargetUpdateSgt_dss_eindejaarsrating()
		{
		}
	}
}