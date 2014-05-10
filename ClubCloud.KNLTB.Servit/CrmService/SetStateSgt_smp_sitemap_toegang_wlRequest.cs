using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_smp_sitemap_toegang_wlRequest : Request
	{
		private Guid entityIdField;
		private Sgt_smp_sitemap_toegang_wlState sgt_smp_sitemap_toegang_wlStateField;
		private int sgt_smp_sitemap_toegang_wlStatusField;
		public Guid EntityId
		{
			get
			{
				return this.entityIdField;
			}
			set
			{
				this.entityIdField = value;
			}
		}
		public Sgt_smp_sitemap_toegang_wlState Sgt_smp_sitemap_toegang_wlState
		{
			get
			{
				return this.sgt_smp_sitemap_toegang_wlStateField;
			}
			set
			{
				this.sgt_smp_sitemap_toegang_wlStateField = value;
			}
		}
		public int Sgt_smp_sitemap_toegang_wlStatus
		{
			get
			{
				return this.sgt_smp_sitemap_toegang_wlStatusField;
			}
			set
			{
				this.sgt_smp_sitemap_toegang_wlStatusField = value;
			}
		}
	}
}
