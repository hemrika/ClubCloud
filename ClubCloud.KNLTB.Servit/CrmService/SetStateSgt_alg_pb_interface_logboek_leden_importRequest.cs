using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_pb_interface_logboek_leden_importRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_pb_interface_logboek_leden_importState sgt_alg_pb_interface_logboek_leden_importStateField;
		private int sgt_alg_pb_interface_logboek_leden_importStatusField;
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
		public Sgt_alg_pb_interface_logboek_leden_importState Sgt_alg_pb_interface_logboek_leden_importState
		{
			get
			{
				return this.sgt_alg_pb_interface_logboek_leden_importStateField;
			}
			set
			{
				this.sgt_alg_pb_interface_logboek_leden_importStateField = value;
			}
		}
		public int Sgt_alg_pb_interface_logboek_leden_importStatus
		{
			get
			{
				return this.sgt_alg_pb_interface_logboek_leden_importStatusField;
			}
			set
			{
				this.sgt_alg_pb_interface_logboek_leden_importStatusField = value;
			}
		}
	}
}
