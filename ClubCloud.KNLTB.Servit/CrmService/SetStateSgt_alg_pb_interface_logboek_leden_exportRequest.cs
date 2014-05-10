using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_pb_interface_logboek_leden_exportRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_pb_interface_logboek_leden_exportState sgt_alg_pb_interface_logboek_leden_exportStateField;
		private int sgt_alg_pb_interface_logboek_leden_exportStatusField;
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
		public Sgt_alg_pb_interface_logboek_leden_exportState Sgt_alg_pb_interface_logboek_leden_exportState
		{
			get
			{
				return this.sgt_alg_pb_interface_logboek_leden_exportStateField;
			}
			set
			{
				this.sgt_alg_pb_interface_logboek_leden_exportStateField = value;
			}
		}
		public int Sgt_alg_pb_interface_logboek_leden_exportStatus
		{
			get
			{
				return this.sgt_alg_pb_interface_logboek_leden_exportStatusField;
			}
			set
			{
				this.sgt_alg_pb_interface_logboek_leden_exportStatusField = value;
			}
		}
	}
}
