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
	public class SetStateSgt_toe_zwaarteRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_zwaarteState sgt_toe_zwaarteStateField;

		private int sgt_toe_zwaarteStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_zwaarteState Sgt_toe_zwaarteState
		{
			get
			{
				return this.sgt_toe_zwaarteStateField;
			}
			set
			{
				this.sgt_toe_zwaarteStateField = value;
				base.RaisePropertyChanged("Sgt_toe_zwaarteState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_toe_zwaarteStatus
		{
			get
			{
				return this.sgt_toe_zwaarteStatusField;
			}
			set
			{
				this.sgt_toe_zwaarteStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_zwaarteStatus");
			}
		}

		public SetStateSgt_toe_zwaarteRequest()
		{
		}
	}
}