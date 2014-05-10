using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_smp_sitemap_toegang_bgd : TargetUpdate
	{
		private sgt_smp_sitemap_toegang_bgd sgt_smp_sitemap_toegang_bgdField;
		public sgt_smp_sitemap_toegang_bgd Sgt_smp_sitemap_toegang_bgd
		{
			get
			{
				return this.sgt_smp_sitemap_toegang_bgdField;
			}
			set
			{
				this.sgt_smp_sitemap_toegang_bgdField = value;
			}
		}
	}
}
