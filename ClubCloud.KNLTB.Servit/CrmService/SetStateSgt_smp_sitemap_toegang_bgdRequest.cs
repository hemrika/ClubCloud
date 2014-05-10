using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_smp_sitemap_toegang_bgdRequest : Request
	{
		private Guid entityIdField;
		private Sgt_smp_sitemap_toegang_bgdState sgt_smp_sitemap_toegang_bgdStateField;
		private int sgt_smp_sitemap_toegang_bgdStatusField;
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
		public Sgt_smp_sitemap_toegang_bgdState Sgt_smp_sitemap_toegang_bgdState
		{
			get
			{
				return this.sgt_smp_sitemap_toegang_bgdStateField;
			}
			set
			{
				this.sgt_smp_sitemap_toegang_bgdStateField = value;
			}
		}
		public int Sgt_smp_sitemap_toegang_bgdStatus
		{
			get
			{
				return this.sgt_smp_sitemap_toegang_bgdStatusField;
			}
			set
			{
				this.sgt_smp_sitemap_toegang_bgdStatusField = value;
			}
		}
	}
}
