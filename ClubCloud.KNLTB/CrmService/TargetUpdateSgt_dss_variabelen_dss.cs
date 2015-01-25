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
	public class TargetUpdateSgt_dss_variabelen_dss : TargetUpdate
	{
		private sgt_dss_variabelen_dss sgt_dss_variabelen_dssField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_dss_variabelen_dss Sgt_dss_variabelen_dss
		{
			get
			{
				return this.sgt_dss_variabelen_dssField;
			}
			set
			{
				this.sgt_dss_variabelen_dssField = value;
				base.RaisePropertyChanged("Sgt_dss_variabelen_dss");
			}
		}

		public TargetUpdateSgt_dss_variabelen_dss()
		{
		}
	}
}