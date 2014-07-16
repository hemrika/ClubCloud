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
	public class SetStateSgt_alg_record_lockRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_record_lockState sgt_alg_record_lockStateField;

		private int sgt_alg_record_lockStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_record_lockState Sgt_alg_record_lockState
		{
			get
			{
				return this.sgt_alg_record_lockStateField;
			}
			set
			{
				this.sgt_alg_record_lockStateField = value;
				base.RaisePropertyChanged("Sgt_alg_record_lockState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_alg_record_lockStatus
		{
			get
			{
				return this.sgt_alg_record_lockStatusField;
			}
			set
			{
				this.sgt_alg_record_lockStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_record_lockStatus");
			}
		}

		public SetStateSgt_alg_record_lockRequest()
		{
		}
	}
}