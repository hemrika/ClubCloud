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
	public class SetStateSgt_toe_baansoort_toernooiRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_baansoort_toernooiState sgt_toe_baansoort_toernooiStateField;

		private int sgt_toe_baansoort_toernooiStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_baansoort_toernooiState Sgt_toe_baansoort_toernooiState
		{
			get
			{
				return this.sgt_toe_baansoort_toernooiStateField;
			}
			set
			{
				this.sgt_toe_baansoort_toernooiStateField = value;
				base.RaisePropertyChanged("Sgt_toe_baansoort_toernooiState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_toe_baansoort_toernooiStatus
		{
			get
			{
				return this.sgt_toe_baansoort_toernooiStatusField;
			}
			set
			{
				this.sgt_toe_baansoort_toernooiStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_baansoort_toernooiStatus");
			}
		}

		public SetStateSgt_toe_baansoort_toernooiRequest()
		{
		}
	}
}