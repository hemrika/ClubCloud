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
	public class TargetUpdateSgt_smp_sitemap_toegang_led : TargetUpdate
	{
		private sgt_smp_sitemap_toegang_led sgt_smp_sitemap_toegang_ledField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_smp_sitemap_toegang_led Sgt_smp_sitemap_toegang_led
		{
			get
			{
				return this.sgt_smp_sitemap_toegang_ledField;
			}
			set
			{
				this.sgt_smp_sitemap_toegang_ledField = value;
				base.RaisePropertyChanged("Sgt_smp_sitemap_toegang_led");
			}
		}

		public TargetUpdateSgt_smp_sitemap_toegang_led()
		{
		}
	}
}