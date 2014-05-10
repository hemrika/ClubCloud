using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_smp_sitemap_toegang_capRequest : Request
	{
		private Guid entityIdField;
		private Sgt_smp_sitemap_toegang_capState sgt_smp_sitemap_toegang_capStateField;
		private int sgt_smp_sitemap_toegang_capStatusField;
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
		public Sgt_smp_sitemap_toegang_capState Sgt_smp_sitemap_toegang_capState
		{
			get
			{
				return this.sgt_smp_sitemap_toegang_capStateField;
			}
			set
			{
				this.sgt_smp_sitemap_toegang_capStateField = value;
			}
		}
		public int Sgt_smp_sitemap_toegang_capStatus
		{
			get
			{
				return this.sgt_smp_sitemap_toegang_capStatusField;
			}
			set
			{
				this.sgt_smp_sitemap_toegang_capStatusField = value;
			}
		}
	}
}
