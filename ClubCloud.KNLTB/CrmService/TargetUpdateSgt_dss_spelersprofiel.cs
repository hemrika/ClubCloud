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
	public class TargetUpdateSgt_dss_spelersprofiel : TargetUpdate
	{
		private sgt_dss_spelersprofiel sgt_dss_spelersprofielField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_dss_spelersprofiel Sgt_dss_spelersprofiel
		{
			get
			{
				return this.sgt_dss_spelersprofielField;
			}
			set
			{
				this.sgt_dss_spelersprofielField = value;
				base.RaisePropertyChanged("Sgt_dss_spelersprofiel");
			}
		}

		public TargetUpdateSgt_dss_spelersprofiel()
		{
		}
	}
}