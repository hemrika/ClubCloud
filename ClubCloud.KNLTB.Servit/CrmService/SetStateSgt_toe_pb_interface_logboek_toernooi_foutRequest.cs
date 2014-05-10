using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_pb_interface_logboek_toernooi_foutRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_pb_interface_logboek_toernooi_foutState sgt_toe_pb_interface_logboek_toernooi_foutStateField;
		private int sgt_toe_pb_interface_logboek_toernooi_foutStatusField;
		public Guid EntityId
		{
			get
			{
				return this.entityIdField;
			}
			set
			{
				this.entityIdField = value;
			}
		}
		public Sgt_toe_pb_interface_logboek_toernooi_foutState Sgt_toe_pb_interface_logboek_toernooi_foutState
		{
			get
			{
				return this.sgt_toe_pb_interface_logboek_toernooi_foutStateField;
			}
			set
			{
				this.sgt_toe_pb_interface_logboek_toernooi_foutStateField = value;
			}
		}
		public int Sgt_toe_pb_interface_logboek_toernooi_foutStatus
		{
			get
			{
				return this.sgt_toe_pb_interface_logboek_toernooi_foutStatusField;
			}
			set
			{
				this.sgt_toe_pb_interface_logboek_toernooi_foutStatusField = value;
			}
		}
	}
}
