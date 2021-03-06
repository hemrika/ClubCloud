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
	public class SetStateSgt_toe_administratieve_overtr_strafbepalngRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_administratieve_overtr_strafbepalngState sgt_toe_administratieve_overtr_strafbepalngStateField;

		private int sgt_toe_administratieve_overtr_strafbepalngStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_administratieve_overtr_strafbepalngState Sgt_toe_administratieve_overtr_strafbepalngState
		{
			get
			{
				return this.sgt_toe_administratieve_overtr_strafbepalngStateField;
			}
			set
			{
				this.sgt_toe_administratieve_overtr_strafbepalngStateField = value;
				base.RaisePropertyChanged("Sgt_toe_administratieve_overtr_strafbepalngState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_toe_administratieve_overtr_strafbepalngStatus
		{
			get
			{
				return this.sgt_toe_administratieve_overtr_strafbepalngStatusField;
			}
			set
			{
				this.sgt_toe_administratieve_overtr_strafbepalngStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_administratieve_overtr_strafbepalngStatus");
			}
		}

		public SetStateSgt_toe_administratieve_overtr_strafbepalngRequest()
		{
		}
	}
}