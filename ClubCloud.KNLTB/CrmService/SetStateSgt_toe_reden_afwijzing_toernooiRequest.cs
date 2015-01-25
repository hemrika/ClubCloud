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
	public class SetStateSgt_toe_reden_afwijzing_toernooiRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_reden_afwijzing_toernooiState sgt_toe_reden_afwijzing_toernooiStateField;

		private int sgt_toe_reden_afwijzing_toernooiStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_reden_afwijzing_toernooiState Sgt_toe_reden_afwijzing_toernooiState
		{
			get
			{
				return this.sgt_toe_reden_afwijzing_toernooiStateField;
			}
			set
			{
				this.sgt_toe_reden_afwijzing_toernooiStateField = value;
				base.RaisePropertyChanged("Sgt_toe_reden_afwijzing_toernooiState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_toe_reden_afwijzing_toernooiStatus
		{
			get
			{
				return this.sgt_toe_reden_afwijzing_toernooiStatusField;
			}
			set
			{
				this.sgt_toe_reden_afwijzing_toernooiStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_reden_afwijzing_toernooiStatus");
			}
		}

		public SetStateSgt_toe_reden_afwijzing_toernooiRequest()
		{
		}
	}
}