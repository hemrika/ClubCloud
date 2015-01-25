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
	public class SetStateSgt_wt_opleidingsfaseRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_wt_opleidingsfaseState sgt_wt_opleidingsfaseStateField;

		private int sgt_wt_opleidingsfaseStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_wt_opleidingsfaseState Sgt_wt_opleidingsfaseState
		{
			get
			{
				return this.sgt_wt_opleidingsfaseStateField;
			}
			set
			{
				this.sgt_wt_opleidingsfaseStateField = value;
				base.RaisePropertyChanged("Sgt_wt_opleidingsfaseState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_wt_opleidingsfaseStatus
		{
			get
			{
				return this.sgt_wt_opleidingsfaseStatusField;
			}
			set
			{
				this.sgt_wt_opleidingsfaseStatusField = value;
				base.RaisePropertyChanged("Sgt_wt_opleidingsfaseStatus");
			}
		}

		public SetStateSgt_wt_opleidingsfaseRequest()
		{
		}
	}
}