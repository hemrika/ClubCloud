using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_smp_sitemap_toegang_knltb : TargetUpdate
	{
		private sgt_smp_sitemap_toegang_knltb sgt_smp_sitemap_toegang_knltbField;
		public sgt_smp_sitemap_toegang_knltb Sgt_smp_sitemap_toegang_knltb
		{
			get
			{
				return this.sgt_smp_sitemap_toegang_knltbField;
			}
			set
			{
				this.sgt_smp_sitemap_toegang_knltbField = value;
			}
		}
	}
}