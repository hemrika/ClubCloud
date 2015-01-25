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
	public class TargetCreateSgt_smp_sitemap_toegang_vcl : TargetCreate
	{
		private sgt_smp_sitemap_toegang_vcl sgt_smp_sitemap_toegang_vclField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_smp_sitemap_toegang_vcl Sgt_smp_sitemap_toegang_vcl
		{
			get
			{
				return this.sgt_smp_sitemap_toegang_vclField;
			}
			set
			{
				this.sgt_smp_sitemap_toegang_vclField = value;
				base.RaisePropertyChanged("Sgt_smp_sitemap_toegang_vcl");
			}
		}

		public TargetCreateSgt_smp_sitemap_toegang_vcl()
		{
		}
	}
}