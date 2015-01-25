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
	public class SetStateSgt_toe_toernooien_reglementaire_arbitrageRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_toernooien_reglementaire_arbitrageState sgt_toe_toernooien_reglementaire_arbitrageStateField;

		private int sgt_toe_toernooien_reglementaire_arbitrageStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_toernooien_reglementaire_arbitrageState Sgt_toe_toernooien_reglementaire_arbitrageState
		{
			get
			{
				return this.sgt_toe_toernooien_reglementaire_arbitrageStateField;
			}
			set
			{
				this.sgt_toe_toernooien_reglementaire_arbitrageStateField = value;
				base.RaisePropertyChanged("Sgt_toe_toernooien_reglementaire_arbitrageState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_toe_toernooien_reglementaire_arbitrageStatus
		{
			get
			{
				return this.sgt_toe_toernooien_reglementaire_arbitrageStatusField;
			}
			set
			{
				this.sgt_toe_toernooien_reglementaire_arbitrageStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_toernooien_reglementaire_arbitrageStatus");
			}
		}

		public SetStateSgt_toe_toernooien_reglementaire_arbitrageRequest()
		{
		}
	}
}