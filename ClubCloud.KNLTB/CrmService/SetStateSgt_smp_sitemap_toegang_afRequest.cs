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
	public class SetStateSgt_smp_sitemap_toegang_afRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_smp_sitemap_toegang_afState sgt_smp_sitemap_toegang_afStateField;

		private int sgt_smp_sitemap_toegang_afStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_smp_sitemap_toegang_afState Sgt_smp_sitemap_toegang_afState
		{
			get
			{
				return this.sgt_smp_sitemap_toegang_afStateField;
			}
			set
			{
				this.sgt_smp_sitemap_toegang_afStateField = value;
				base.RaisePropertyChanged("Sgt_smp_sitemap_toegang_afState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_smp_sitemap_toegang_afStatus
		{
			get
			{
				return this.sgt_smp_sitemap_toegang_afStatusField;
			}
			set
			{
				this.sgt_smp_sitemap_toegang_afStatusField = value;
				base.RaisePropertyChanged("Sgt_smp_sitemap_toegang_afStatus");
			}
		}

		public SetStateSgt_smp_sitemap_toegang_afRequest()
		{
		}
	}
}