using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_smp_sitemap_toegang_vclRequest : Request
	{
		private Guid entityIdField;
		private Sgt_smp_sitemap_toegang_vclState sgt_smp_sitemap_toegang_vclStateField;
		private int sgt_smp_sitemap_toegang_vclStatusField;
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
		public Sgt_smp_sitemap_toegang_vclState Sgt_smp_sitemap_toegang_vclState
		{
			get
			{
				return this.sgt_smp_sitemap_toegang_vclStateField;
			}
			set
			{
				this.sgt_smp_sitemap_toegang_vclStateField = value;
			}
		}
		public int Sgt_smp_sitemap_toegang_vclStatus
		{
			get
			{
				return this.sgt_smp_sitemap_toegang_vclStatusField;
			}
			set
			{
				this.sgt_smp_sitemap_toegang_vclStatusField = value;
			}
		}
	}
}
