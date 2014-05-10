using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_smp_sitemap_toegang_vcl : TargetUpdate
	{
		private sgt_smp_sitemap_toegang_vcl sgt_smp_sitemap_toegang_vclField;
		public sgt_smp_sitemap_toegang_vcl Sgt_smp_sitemap_toegang_vcl
		{
			get
			{
				return this.sgt_smp_sitemap_toegang_vclField;
			}
			set
			{
				this.sgt_smp_sitemap_toegang_vclField = value;
			}
		}
	}
}
