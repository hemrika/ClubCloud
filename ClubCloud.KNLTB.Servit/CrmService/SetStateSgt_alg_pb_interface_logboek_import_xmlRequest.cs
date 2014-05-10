using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_pb_interface_logboek_import_xmlRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_pb_interface_logboek_import_xmlState sgt_alg_pb_interface_logboek_import_xmlStateField;
		private int sgt_alg_pb_interface_logboek_import_xmlStatusField;
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
		public Sgt_alg_pb_interface_logboek_import_xmlState Sgt_alg_pb_interface_logboek_import_xmlState
		{
			get
			{
				return this.sgt_alg_pb_interface_logboek_import_xmlStateField;
			}
			set
			{
				this.sgt_alg_pb_interface_logboek_import_xmlStateField = value;
			}
		}
		public int Sgt_alg_pb_interface_logboek_import_xmlStatus
		{
			get
			{
				return this.sgt_alg_pb_interface_logboek_import_xmlStatusField;
			}
			set
			{
				this.sgt_alg_pb_interface_logboek_import_xmlStatusField = value;
			}
		}
	}
}
