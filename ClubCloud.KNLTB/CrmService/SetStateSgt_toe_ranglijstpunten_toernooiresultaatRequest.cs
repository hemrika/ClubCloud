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
	public class SetStateSgt_toe_ranglijstpunten_toernooiresultaatRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_ranglijstpunten_toernooiresultaatState sgt_toe_ranglijstpunten_toernooiresultaatStateField;

		private int sgt_toe_ranglijstpunten_toernooiresultaatStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_ranglijstpunten_toernooiresultaatState Sgt_toe_ranglijstpunten_toernooiresultaatState
		{
			get
			{
				return this.sgt_toe_ranglijstpunten_toernooiresultaatStateField;
			}
			set
			{
				this.sgt_toe_ranglijstpunten_toernooiresultaatStateField = value;
				base.RaisePropertyChanged("Sgt_toe_ranglijstpunten_toernooiresultaatState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_toe_ranglijstpunten_toernooiresultaatStatus
		{
			get
			{
				return this.sgt_toe_ranglijstpunten_toernooiresultaatStatusField;
			}
			set
			{
				this.sgt_toe_ranglijstpunten_toernooiresultaatStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_ranglijstpunten_toernooiresultaatStatus");
			}
		}

		public SetStateSgt_toe_ranglijstpunten_toernooiresultaatRequest()
		{
		}
	}
}