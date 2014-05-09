using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_smp_sitemap_toegang_knltbRequest : Request
	{
		private Guid entityIdField;
		private Sgt_smp_sitemap_toegang_knltbState sgt_smp_sitemap_toegang_knltbStateField;
		private int sgt_smp_sitemap_toegang_knltbStatusField;
		[XmlElement(Order = 0)]
		public Guid EntityId
		{
			get
			{
				return this.entityIdField;
			}
			set
			{
				this.entityIdField = value;
				base.RaisePropertyChanged("EntityId");
			}
		}
		[XmlElement(Order = 1)]
		public Sgt_smp_sitemap_toegang_knltbState Sgt_smp_sitemap_toegang_knltbState
		{
			get
			{
				return this.sgt_smp_sitemap_toegang_knltbStateField;
			}
			set
			{
				this.sgt_smp_sitemap_toegang_knltbStateField = value;
				base.RaisePropertyChanged("Sgt_smp_sitemap_toegang_knltbState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_smp_sitemap_toegang_knltbStatus
		{
			get
			{
				return this.sgt_smp_sitemap_toegang_knltbStatusField;
			}
			set
			{
				this.sgt_smp_sitemap_toegang_knltbStatusField = value;
				base.RaisePropertyChanged("Sgt_smp_sitemap_toegang_knltbStatus");
			}
		}
	}
}
