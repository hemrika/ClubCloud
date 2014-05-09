using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_pb_interfaceRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_pb_interfaceState sgt_alg_pb_interfaceStateField;
		private int sgt_alg_pb_interfaceStatusField;
		[XmlElement(Order = 0)]
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
		[XmlElement(Order = 1)]
		public Sgt_alg_pb_interfaceState Sgt_alg_pb_interfaceState
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
		[XmlElement(Order = 2)]
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
	}
}
