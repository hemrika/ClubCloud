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
	public class SetStateSgt_alg_baan_gereserveerd_verenigingRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_baan_gereserveerd_verenigingState sgt_alg_baan_gereserveerd_verenigingStateField;

		private int sgt_alg_baan_gereserveerd_verenigingStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_baan_gereserveerd_verenigingState Sgt_alg_baan_gereserveerd_verenigingState
		{
			get
			{
				return this.sgt_alg_baan_gereserveerd_verenigingStateField;
			}
			set
			{
				this.sgt_alg_baan_gereserveerd_verenigingStateField = value;
				base.RaisePropertyChanged("Sgt_alg_baan_gereserveerd_verenigingState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_alg_baan_gereserveerd_verenigingStatus
		{
			get
			{
				return this.sgt_alg_baan_gereserveerd_verenigingStatusField;
			}
			set
			{
				this.sgt_alg_baan_gereserveerd_verenigingStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_baan_gereserveerd_verenigingStatus");
			}
		}

		public SetStateSgt_alg_baan_gereserveerd_verenigingRequest()
		{
		}
	}
}