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
	public class SetStateSgt_toe_administratieve_overtr_beroep_mutRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_administratieve_overtr_beroep_mutState sgt_toe_administratieve_overtr_beroep_mutStateField;

		private int sgt_toe_administratieve_overtr_beroep_mutStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_administratieve_overtr_beroep_mutState Sgt_toe_administratieve_overtr_beroep_mutState
		{
			get
			{
				return this.sgt_toe_administratieve_overtr_beroep_mutStateField;
			}
			set
			{
				this.sgt_toe_administratieve_overtr_beroep_mutStateField = value;
				base.RaisePropertyChanged("Sgt_toe_administratieve_overtr_beroep_mutState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_toe_administratieve_overtr_beroep_mutStatus
		{
			get
			{
				return this.sgt_toe_administratieve_overtr_beroep_mutStatusField;
			}
			set
			{
				this.sgt_toe_administratieve_overtr_beroep_mutStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_administratieve_overtr_beroep_mutStatus");
			}
		}

		public SetStateSgt_toe_administratieve_overtr_beroep_mutRequest()
		{
		}
	}
}