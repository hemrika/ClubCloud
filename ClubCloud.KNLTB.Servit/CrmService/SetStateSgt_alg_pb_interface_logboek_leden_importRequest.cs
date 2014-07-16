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
	public class SetStateSgt_alg_pb_interface_logboek_leden_importRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_pb_interface_logboek_leden_importState sgt_alg_pb_interface_logboek_leden_importStateField;

		private int sgt_alg_pb_interface_logboek_leden_importStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_pb_interface_logboek_leden_importState Sgt_alg_pb_interface_logboek_leden_importState
		{
			get
			{
				return this.sgt_alg_pb_interface_logboek_leden_importStateField;
			}
			set
			{
				this.sgt_alg_pb_interface_logboek_leden_importStateField = value;
				base.RaisePropertyChanged("Sgt_alg_pb_interface_logboek_leden_importState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_alg_pb_interface_logboek_leden_importStatus
		{
			get
			{
				return this.sgt_alg_pb_interface_logboek_leden_importStatusField;
			}
			set
			{
				this.sgt_alg_pb_interface_logboek_leden_importStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_pb_interface_logboek_leden_importStatus");
			}
		}

		public SetStateSgt_alg_pb_interface_logboek_leden_importRequest()
		{
		}
	}
}