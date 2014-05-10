using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_smp_sitemap_toegang_wl : TargetCreate
	{
		private sgt_smp_sitemap_toegang_wl sgt_smp_sitemap_toegang_wlField;
		public sgt_smp_sitemap_toegang_wl Sgt_smp_sitemap_toegang_wl
		{
			get
			{
				return this.sgt_smp_sitemap_toegang_wlField;
			}
			set
			{
				this.sgt_smp_sitemap_toegang_wlField = value;
			}
		}
	}
}
