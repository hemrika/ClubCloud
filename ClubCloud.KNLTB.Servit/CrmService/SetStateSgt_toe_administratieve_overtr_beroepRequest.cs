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
	public class SetStateSgt_toe_administratieve_overtr_beroepRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_administratieve_overtr_beroepState sgt_toe_administratieve_overtr_beroepStateField;

		private int sgt_toe_administratieve_overtr_beroepStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_administratieve_overtr_beroepState Sgt_toe_administratieve_overtr_beroepState
		{
			get
			{
				return this.sgt_toe_administratieve_overtr_beroepStateField;
			}
			set
			{
				this.sgt_toe_administratieve_overtr_beroepStateField = value;
				base.RaisePropertyChanged("Sgt_toe_administratieve_overtr_beroepState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_toe_administratieve_overtr_beroepStatus
		{
			get
			{
				return this.sgt_toe_administratieve_overtr_beroepStatusField;
			}
			set
			{
				this.sgt_toe_administratieve_overtr_beroepStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_administratieve_overtr_beroepStatus");
			}
		}

		public SetStateSgt_toe_administratieve_overtr_beroepRequest()
		{
		}
	}
}