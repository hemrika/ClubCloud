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
	public class SetStateSgt_wt_opleidingsgroep_docentRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_wt_opleidingsgroep_docentState sgt_wt_opleidingsgroep_docentStateField;

		private int sgt_wt_opleidingsgroep_docentStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_wt_opleidingsgroep_docentState Sgt_wt_opleidingsgroep_docentState
		{
			get
			{
				return this.sgt_wt_opleidingsgroep_docentStateField;
			}
			set
			{
				this.sgt_wt_opleidingsgroep_docentStateField = value;
				base.RaisePropertyChanged("Sgt_wt_opleidingsgroep_docentState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_wt_opleidingsgroep_docentStatus
		{
			get
			{
				return this.sgt_wt_opleidingsgroep_docentStatusField;
			}
			set
			{
				this.sgt_wt_opleidingsgroep_docentStatusField = value;
				base.RaisePropertyChanged("Sgt_wt_opleidingsgroep_docentStatus");
			}
		}

		public SetStateSgt_wt_opleidingsgroep_docentRequest()
		{
		}
	}
}