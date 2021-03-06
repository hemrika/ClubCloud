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
	public class SetStateSgt_smp_sitemap_toegang_wlRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_smp_sitemap_toegang_wlState sgt_smp_sitemap_toegang_wlStateField;

		private int sgt_smp_sitemap_toegang_wlStatusField;

		[XmlElement] //[XmlElement(Order=0)]
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

		[XmlElement] //[XmlElement(Order=1)]
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_smp_sitemap_toegang_wlState Sgt_smp_sitemap_toegang_wlState
		{
			get
			{
				return this.sgt_smp_sitemap_toegang_wlStateField;
			}
			set
			{
				this.sgt_smp_sitemap_toegang_wlStateField = value;
				base.RaisePropertyChanged("Sgt_smp_sitemap_toegang_wlState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_smp_sitemap_toegang_wlStatus
		{
			get
			{
				return this.sgt_smp_sitemap_toegang_wlStatusField;
			}
			set
			{
				this.sgt_smp_sitemap_toegang_wlStatusField = value;
				base.RaisePropertyChanged("Sgt_smp_sitemap_toegang_wlStatus");
			}
		}

		public SetStateSgt_smp_sitemap_toegang_wlRequest()
		{
		}
	}
}