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
	public class SetStateSgt_alg_toplaagRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_toplaagState sgt_alg_toplaagStateField;

		private int sgt_alg_toplaagStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_toplaagState Sgt_alg_toplaagState
		{
			get
			{
				return this.sgt_alg_toplaagStateField;
			}
			set
			{
				this.sgt_alg_toplaagStateField = value;
				base.RaisePropertyChanged("Sgt_alg_toplaagState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_alg_toplaagStatus
		{
			get
			{
				return this.sgt_alg_toplaagStatusField;
			}
			set
			{
				this.sgt_alg_toplaagStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_toplaagStatus");
			}
		}

		public SetStateSgt_alg_toplaagRequest()
		{
		}
	}
}