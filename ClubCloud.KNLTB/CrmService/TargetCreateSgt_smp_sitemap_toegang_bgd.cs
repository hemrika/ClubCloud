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
	public class TargetCreateSgt_smp_sitemap_toegang_bgd : TargetCreate
	{
		private sgt_smp_sitemap_toegang_bgd sgt_smp_sitemap_toegang_bgdField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_smp_sitemap_toegang_bgd Sgt_smp_sitemap_toegang_bgd
		{
			get
			{
				return this.sgt_smp_sitemap_toegang_bgdField;
			}
			set
			{
				this.sgt_smp_sitemap_toegang_bgdField = value;
				base.RaisePropertyChanged("Sgt_smp_sitemap_toegang_bgd");
			}
		}

		public TargetCreateSgt_smp_sitemap_toegang_bgd()
		{
		}
	}
}