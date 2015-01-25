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
	public class SetStateSgt_toe_dagtoernooiRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_dagtoernooiState sgt_toe_dagtoernooiStateField;

		private int sgt_toe_dagtoernooiStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_dagtoernooiState Sgt_toe_dagtoernooiState
		{
			get
			{
				return this.sgt_toe_dagtoernooiStateField;
			}
			set
			{
				this.sgt_toe_dagtoernooiStateField = value;
				base.RaisePropertyChanged("Sgt_toe_dagtoernooiState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_toe_dagtoernooiStatus
		{
			get
			{
				return this.sgt_toe_dagtoernooiStatusField;
			}
			set
			{
				this.sgt_toe_dagtoernooiStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_dagtoernooiStatus");
			}
		}

		public SetStateSgt_toe_dagtoernooiRequest()
		{
		}
	}
}