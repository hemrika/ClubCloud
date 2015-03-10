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
	public class TargetUpdateSgt_alg_baanblok_werkzaamheid : TargetUpdate
	{
		private sgt_alg_baanblok_werkzaamheid sgt_alg_baanblok_werkzaamheidField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_alg_baanblok_werkzaamheid Sgt_alg_baanblok_werkzaamheid
		{
			get
			{
				return this.sgt_alg_baanblok_werkzaamheidField;
			}
			set
			{
				this.sgt_alg_baanblok_werkzaamheidField = value;
				base.RaisePropertyChanged("Sgt_alg_baanblok_werkzaamheid");
			}
		}

		public TargetUpdateSgt_alg_baanblok_werkzaamheid()
		{
		}
	}
}