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
	public class SetStateSgt_autorisatie_uitgifteRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_autorisatie_uitgifteState sgt_autorisatie_uitgifteStateField;

		private int sgt_autorisatie_uitgifteStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_autorisatie_uitgifteState Sgt_autorisatie_uitgifteState
		{
			get
			{
				return this.sgt_autorisatie_uitgifteStateField;
			}
			set
			{
				this.sgt_autorisatie_uitgifteStateField = value;
				base.RaisePropertyChanged("Sgt_autorisatie_uitgifteState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_autorisatie_uitgifteStatus
		{
			get
			{
				return this.sgt_autorisatie_uitgifteStatusField;
			}
			set
			{
				this.sgt_autorisatie_uitgifteStatusField = value;
				base.RaisePropertyChanged("Sgt_autorisatie_uitgifteStatus");
			}
		}

		public SetStateSgt_autorisatie_uitgifteRequest()
		{
		}
	}
}