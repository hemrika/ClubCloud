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
	public class SetStateSgt_fac_factuurgroep_toernooisoortRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_fac_factuurgroep_toernooisoortState sgt_fac_factuurgroep_toernooisoortStateField;

		private int sgt_fac_factuurgroep_toernooisoortStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_fac_factuurgroep_toernooisoortState Sgt_fac_factuurgroep_toernooisoortState
		{
			get
			{
				return this.sgt_fac_factuurgroep_toernooisoortStateField;
			}
			set
			{
				this.sgt_fac_factuurgroep_toernooisoortStateField = value;
				base.RaisePropertyChanged("Sgt_fac_factuurgroep_toernooisoortState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_fac_factuurgroep_toernooisoortStatus
		{
			get
			{
				return this.sgt_fac_factuurgroep_toernooisoortStatusField;
			}
			set
			{
				this.sgt_fac_factuurgroep_toernooisoortStatusField = value;
				base.RaisePropertyChanged("Sgt_fac_factuurgroep_toernooisoortStatus");
			}
		}

		public SetStateSgt_fac_factuurgroep_toernooisoortRequest()
		{
		}
	}
}