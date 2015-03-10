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
	public class SetStateSgt_alg_pb_interface_logboek_leden_exportRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_pb_interface_logboek_leden_exportState sgt_alg_pb_interface_logboek_leden_exportStateField;

		private int sgt_alg_pb_interface_logboek_leden_exportStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_pb_interface_logboek_leden_exportState Sgt_alg_pb_interface_logboek_leden_exportState
		{
			get
			{
				return this.sgt_alg_pb_interface_logboek_leden_exportStateField;
			}
			set
			{
				this.sgt_alg_pb_interface_logboek_leden_exportStateField = value;
				base.RaisePropertyChanged("Sgt_alg_pb_interface_logboek_leden_exportState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_alg_pb_interface_logboek_leden_exportStatus
		{
			get
			{
				return this.sgt_alg_pb_interface_logboek_leden_exportStatusField;
			}
			set
			{
				this.sgt_alg_pb_interface_logboek_leden_exportStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_pb_interface_logboek_leden_exportStatus");
			}
		}

		public SetStateSgt_alg_pb_interface_logboek_leden_exportRequest()
		{
		}
	}
}