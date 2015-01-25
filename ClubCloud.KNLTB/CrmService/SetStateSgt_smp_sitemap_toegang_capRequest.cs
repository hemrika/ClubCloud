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
	public class SetStateSgt_smp_sitemap_toegang_capRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_smp_sitemap_toegang_capState sgt_smp_sitemap_toegang_capStateField;

		private int sgt_smp_sitemap_toegang_capStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_smp_sitemap_toegang_capState Sgt_smp_sitemap_toegang_capState
		{
			get
			{
				return this.sgt_smp_sitemap_toegang_capStateField;
			}
			set
			{
				this.sgt_smp_sitemap_toegang_capStateField = value;
				base.RaisePropertyChanged("Sgt_smp_sitemap_toegang_capState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_smp_sitemap_toegang_capStatus
		{
			get
			{
				return this.sgt_smp_sitemap_toegang_capStatusField;
			}
			set
			{
				this.sgt_smp_sitemap_toegang_capStatusField = value;
				base.RaisePropertyChanged("Sgt_smp_sitemap_toegang_capStatus");
			}
		}

		public SetStateSgt_smp_sitemap_toegang_capRequest()
		{
		}
	}
}