using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_smp_sitemap_toegang_afRequest : Request
	{
		private Guid entityIdField;
		private Sgt_smp_sitemap_toegang_afState sgt_smp_sitemap_toegang_afStateField;
		private int sgt_smp_sitemap_toegang_afStatusField;
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
		public Sgt_smp_sitemap_toegang_afState Sgt_smp_sitemap_toegang_afState
		{
			get
			{
				return this.sgt_smp_sitemap_toegang_afStateField;
			}
			set
			{
				this.sgt_smp_sitemap_toegang_afStateField = value;
			}
		}
		public int Sgt_smp_sitemap_toegang_afStatus
		{
			get
			{
				return this.sgt_smp_sitemap_toegang_afStatusField;
			}
			set
			{
				this.sgt_smp_sitemap_toegang_afStatusField = value;
			}
		}
	}
}
