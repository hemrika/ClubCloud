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
	public class SetStateSgt_toe_pb_interface_logboek_toernooi_foutRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_pb_interface_logboek_toernooi_foutState sgt_toe_pb_interface_logboek_toernooi_foutStateField;

		private int sgt_toe_pb_interface_logboek_toernooi_foutStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_pb_interface_logboek_toernooi_foutState Sgt_toe_pb_interface_logboek_toernooi_foutState
		{
			get
			{
				return this.sgt_toe_pb_interface_logboek_toernooi_foutStateField;
			}
			set
			{
				this.sgt_toe_pb_interface_logboek_toernooi_foutStateField = value;
				base.RaisePropertyChanged("Sgt_toe_pb_interface_logboek_toernooi_foutState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_toe_pb_interface_logboek_toernooi_foutStatus
		{
			get
			{
				return this.sgt_toe_pb_interface_logboek_toernooi_foutStatusField;
			}
			set
			{
				this.sgt_toe_pb_interface_logboek_toernooi_foutStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_pb_interface_logboek_toernooi_foutStatus");
			}
		}

		public SetStateSgt_toe_pb_interface_logboek_toernooi_foutRequest()
		{
		}
	}
}