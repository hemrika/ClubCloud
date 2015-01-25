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
	public class SetStateSgt_fac_factuur_type_factuurregelRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_fac_factuur_type_factuurregelState sgt_fac_factuur_type_factuurregelStateField;

		private int sgt_fac_factuur_type_factuurregelStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_fac_factuur_type_factuurregelState Sgt_fac_factuur_type_factuurregelState
		{
			get
			{
				return this.sgt_fac_factuur_type_factuurregelStateField;
			}
			set
			{
				this.sgt_fac_factuur_type_factuurregelStateField = value;
				base.RaisePropertyChanged("Sgt_fac_factuur_type_factuurregelState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_fac_factuur_type_factuurregelStatus
		{
			get
			{
				return this.sgt_fac_factuur_type_factuurregelStatusField;
			}
			set
			{
				this.sgt_fac_factuur_type_factuurregelStatusField = value;
				base.RaisePropertyChanged("Sgt_fac_factuur_type_factuurregelStatus");
			}
		}

		public SetStateSgt_fac_factuur_type_factuurregelRequest()
		{
		}
	}
}