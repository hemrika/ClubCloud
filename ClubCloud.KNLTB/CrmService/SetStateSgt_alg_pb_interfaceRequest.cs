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
	public class SetStateSgt_alg_pb_interfaceRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_pb_interfaceState sgt_alg_pb_interfaceStateField;

		private int sgt_alg_pb_interfaceStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_pb_interfaceState Sgt_alg_pb_interfaceState
		{
			get
			{
				return this.sgt_alg_pb_interfaceStateField;
			}
			set
			{
				this.sgt_alg_pb_interfaceStateField = value;
				base.RaisePropertyChanged("Sgt_alg_pb_interfaceState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_alg_pb_interfaceStatus
		{
			get
			{
				return this.sgt_alg_pb_interfaceStatusField;
			}
			set
			{
				this.sgt_alg_pb_interfaceStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_pb_interfaceStatus");
			}
		}

		public SetStateSgt_alg_pb_interfaceRequest()
		{
		}
	}
}