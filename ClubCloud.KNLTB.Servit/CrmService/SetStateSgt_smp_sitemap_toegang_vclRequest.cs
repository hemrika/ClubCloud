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
	public class SetStateSgt_smp_sitemap_toegang_vclRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_smp_sitemap_toegang_vclState sgt_smp_sitemap_toegang_vclStateField;

		private int sgt_smp_sitemap_toegang_vclStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_smp_sitemap_toegang_vclState Sgt_smp_sitemap_toegang_vclState
		{
			get
			{
				return this.sgt_smp_sitemap_toegang_vclStateField;
			}
			set
			{
				this.sgt_smp_sitemap_toegang_vclStateField = value;
				base.RaisePropertyChanged("Sgt_smp_sitemap_toegang_vclState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_smp_sitemap_toegang_vclStatus
		{
			get
			{
				return this.sgt_smp_sitemap_toegang_vclStatusField;
			}
			set
			{
				this.sgt_smp_sitemap_toegang_vclStatusField = value;
				base.RaisePropertyChanged("Sgt_smp_sitemap_toegang_vclStatus");
			}
		}

		public SetStateSgt_smp_sitemap_toegang_vclRequest()
		{
		}
	}
}