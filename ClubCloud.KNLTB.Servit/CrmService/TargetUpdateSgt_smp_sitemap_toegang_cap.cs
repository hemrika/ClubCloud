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
	public class TargetUpdateSgt_smp_sitemap_toegang_cap : TargetUpdate
	{
		private sgt_smp_sitemap_toegang_cap sgt_smp_sitemap_toegang_capField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_smp_sitemap_toegang_cap Sgt_smp_sitemap_toegang_cap
		{
			get
			{
				return this.sgt_smp_sitemap_toegang_capField;
			}
			set
			{
				this.sgt_smp_sitemap_toegang_capField = value;
				base.RaisePropertyChanged("Sgt_smp_sitemap_toegang_cap");
			}
		}

		public TargetUpdateSgt_smp_sitemap_toegang_cap()
		{
		}
	}
}