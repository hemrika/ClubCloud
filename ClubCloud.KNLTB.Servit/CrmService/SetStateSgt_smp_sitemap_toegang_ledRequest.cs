using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_smp_sitemap_toegang_ledRequest : Request
	{
		private Guid entityIdField;
		private Sgt_smp_sitemap_toegang_ledState sgt_smp_sitemap_toegang_ledStateField;
		private int sgt_smp_sitemap_toegang_ledStatusField;
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
		public Sgt_smp_sitemap_toegang_ledState Sgt_smp_sitemap_toegang_ledState
		{
			get
			{
				return this.sgt_smp_sitemap_toegang_ledStateField;
			}
			set
			{
				this.sgt_smp_sitemap_toegang_ledStateField = value;
			}
		}
		public int Sgt_smp_sitemap_toegang_ledStatus
		{
			get
			{
				return this.sgt_smp_sitemap_toegang_ledStatusField;
			}
			set
			{
				this.sgt_smp_sitemap_toegang_ledStatusField = value;
			}
		}
	}
}