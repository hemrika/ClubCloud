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
	public class SetStateSgt_smp_sitemap_toegang_bgdRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_smp_sitemap_toegang_bgdState sgt_smp_sitemap_toegang_bgdStateField;

		private int sgt_smp_sitemap_toegang_bgdStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_smp_sitemap_toegang_bgdState Sgt_smp_sitemap_toegang_bgdState
		{
			get
			{
				return this.sgt_smp_sitemap_toegang_bgdStateField;
			}
			set
			{
				this.sgt_smp_sitemap_toegang_bgdStateField = value;
				base.RaisePropertyChanged("Sgt_smp_sitemap_toegang_bgdState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_smp_sitemap_toegang_bgdStatus
		{
			get
			{
				return this.sgt_smp_sitemap_toegang_bgdStatusField;
			}
			set
			{
				this.sgt_smp_sitemap_toegang_bgdStatusField = value;
				base.RaisePropertyChanged("Sgt_smp_sitemap_toegang_bgdStatus");
			}
		}

		public SetStateSgt_smp_sitemap_toegang_bgdRequest()
		{
		}
	}
}