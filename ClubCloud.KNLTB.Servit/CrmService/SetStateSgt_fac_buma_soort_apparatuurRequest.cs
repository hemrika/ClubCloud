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
	public class SetStateSgt_fac_buma_soort_apparatuurRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_fac_buma_soort_apparatuurState sgt_fac_buma_soort_apparatuurStateField;

		private int sgt_fac_buma_soort_apparatuurStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_fac_buma_soort_apparatuurState Sgt_fac_buma_soort_apparatuurState
		{
			get
			{
				return this.sgt_fac_buma_soort_apparatuurStateField;
			}
			set
			{
				this.sgt_fac_buma_soort_apparatuurStateField = value;
				base.RaisePropertyChanged("Sgt_fac_buma_soort_apparatuurState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_fac_buma_soort_apparatuurStatus
		{
			get
			{
				return this.sgt_fac_buma_soort_apparatuurStatusField;
			}
			set
			{
				this.sgt_fac_buma_soort_apparatuurStatusField = value;
				base.RaisePropertyChanged("Sgt_fac_buma_soort_apparatuurStatus");
			}
		}

		public SetStateSgt_fac_buma_soort_apparatuurRequest()
		{
		}
	}
}