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
	public class TargetCreateSgt_smp_sitemap_toegang_af : TargetCreate
	{
		private sgt_smp_sitemap_toegang_af sgt_smp_sitemap_toegang_afField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_smp_sitemap_toegang_af Sgt_smp_sitemap_toegang_af
		{
			get
			{
				return this.sgt_smp_sitemap_toegang_afField;
			}
			set
			{
				this.sgt_smp_sitemap_toegang_afField = value;
				base.RaisePropertyChanged("Sgt_smp_sitemap_toegang_af");
			}
		}

		public TargetCreateSgt_smp_sitemap_toegang_af()
		{
		}
	}
}