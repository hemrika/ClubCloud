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
	public class SetStateSgt_alg_workflow_timestampRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_workflow_timestampState sgt_alg_workflow_timestampStateField;

		private int sgt_alg_workflow_timestampStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_workflow_timestampState Sgt_alg_workflow_timestampState
		{
			get
			{
				return this.sgt_alg_workflow_timestampStateField;
			}
			set
			{
				this.sgt_alg_workflow_timestampStateField = value;
				base.RaisePropertyChanged("Sgt_alg_workflow_timestampState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_alg_workflow_timestampStatus
		{
			get
			{
				return this.sgt_alg_workflow_timestampStatusField;
			}
			set
			{
				this.sgt_alg_workflow_timestampStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_workflow_timestampStatus");
			}
		}

		public SetStateSgt_alg_workflow_timestampRequest()
		{
		}
	}
}