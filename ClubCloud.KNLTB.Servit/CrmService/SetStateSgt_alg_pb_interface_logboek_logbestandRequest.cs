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
	public class SetStateSgt_alg_pb_interface_logboek_logbestandRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_pb_interface_logboek_logbestandState sgt_alg_pb_interface_logboek_logbestandStateField;

		private int sgt_alg_pb_interface_logboek_logbestandStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_pb_interface_logboek_logbestandState Sgt_alg_pb_interface_logboek_logbestandState
		{
			get
			{
				return this.sgt_alg_pb_interface_logboek_logbestandStateField;
			}
			set
			{
				this.sgt_alg_pb_interface_logboek_logbestandStateField = value;
				base.RaisePropertyChanged("Sgt_alg_pb_interface_logboek_logbestandState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_alg_pb_interface_logboek_logbestandStatus
		{
			get
			{
				return this.sgt_alg_pb_interface_logboek_logbestandStatusField;
			}
			set
			{
				this.sgt_alg_pb_interface_logboek_logbestandStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_pb_interface_logboek_logbestandStatus");
			}
		}

		public SetStateSgt_alg_pb_interface_logboek_logbestandRequest()
		{
		}
	}
}