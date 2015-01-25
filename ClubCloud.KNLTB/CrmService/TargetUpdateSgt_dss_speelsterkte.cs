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
	public class TargetUpdateSgt_dss_speelsterkte : TargetUpdate
	{
		private sgt_dss_speelsterkte sgt_dss_speelsterkteField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_dss_speelsterkte Sgt_dss_speelsterkte
		{
			get
			{
				return this.sgt_dss_speelsterkteField;
			}
			set
			{
				this.sgt_dss_speelsterkteField = value;
				base.RaisePropertyChanged("Sgt_dss_speelsterkte");
			}
		}

		public TargetUpdateSgt_dss_speelsterkte()
		{
		}
	}
}