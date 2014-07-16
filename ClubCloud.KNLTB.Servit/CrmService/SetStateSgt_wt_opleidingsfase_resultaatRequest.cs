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
	public class SetStateSgt_wt_opleidingsfase_resultaatRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_wt_opleidingsfase_resultaatState sgt_wt_opleidingsfase_resultaatStateField;

		private int sgt_wt_opleidingsfase_resultaatStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_wt_opleidingsfase_resultaatState Sgt_wt_opleidingsfase_resultaatState
		{
			get
			{
				return this.sgt_wt_opleidingsfase_resultaatStateField;
			}
			set
			{
				this.sgt_wt_opleidingsfase_resultaatStateField = value;
				base.RaisePropertyChanged("Sgt_wt_opleidingsfase_resultaatState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_wt_opleidingsfase_resultaatStatus
		{
			get
			{
				return this.sgt_wt_opleidingsfase_resultaatStatusField;
			}
			set
			{
				this.sgt_wt_opleidingsfase_resultaatStatusField = value;
				base.RaisePropertyChanged("Sgt_wt_opleidingsfase_resultaatStatus");
			}
		}

		public SetStateSgt_wt_opleidingsfase_resultaatRequest()
		{
		}
	}
}