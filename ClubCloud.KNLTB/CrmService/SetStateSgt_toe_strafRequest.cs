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
	public class SetStateSgt_toe_strafRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_strafState sgt_toe_strafStateField;

		private int sgt_toe_strafStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_strafState Sgt_toe_strafState
		{
			get
			{
				return this.sgt_toe_strafStateField;
			}
			set
			{
				this.sgt_toe_strafStateField = value;
				base.RaisePropertyChanged("Sgt_toe_strafState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_toe_strafStatus
		{
			get
			{
				return this.sgt_toe_strafStatusField;
			}
			set
			{
				this.sgt_toe_strafStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_strafStatus");
			}
		}

		public SetStateSgt_toe_strafRequest()
		{
		}
	}
}