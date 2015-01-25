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
	public class SetStateSgt_alg_functionele_logRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_functionele_logState sgt_alg_functionele_logStateField;

		private int sgt_alg_functionele_logStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_functionele_logState Sgt_alg_functionele_logState
		{
			get
			{
				return this.sgt_alg_functionele_logStateField;
			}
			set
			{
				this.sgt_alg_functionele_logStateField = value;
				base.RaisePropertyChanged("Sgt_alg_functionele_logState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_alg_functionele_logStatus
		{
			get
			{
				return this.sgt_alg_functionele_logStatusField;
			}
			set
			{
				this.sgt_alg_functionele_logStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_functionele_logStatus");
			}
		}

		public SetStateSgt_alg_functionele_logRequest()
		{
		}
	}
}