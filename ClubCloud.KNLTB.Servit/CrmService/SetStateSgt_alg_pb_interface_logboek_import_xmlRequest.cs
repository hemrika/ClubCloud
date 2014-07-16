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
	public class SetStateSgt_alg_pb_interface_logboek_import_xmlRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_pb_interface_logboek_import_xmlState sgt_alg_pb_interface_logboek_import_xmlStateField;

		private int sgt_alg_pb_interface_logboek_import_xmlStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_pb_interface_logboek_import_xmlState Sgt_alg_pb_interface_logboek_import_xmlState
		{
			get
			{
				return this.sgt_alg_pb_interface_logboek_import_xmlStateField;
			}
			set
			{
				this.sgt_alg_pb_interface_logboek_import_xmlStateField = value;
				base.RaisePropertyChanged("Sgt_alg_pb_interface_logboek_import_xmlState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_alg_pb_interface_logboek_import_xmlStatus
		{
			get
			{
				return this.sgt_alg_pb_interface_logboek_import_xmlStatusField;
			}
			set
			{
				this.sgt_alg_pb_interface_logboek_import_xmlStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_pb_interface_logboek_import_xmlStatus");
			}
		}

		public SetStateSgt_alg_pb_interface_logboek_import_xmlRequest()
		{
		}
	}
}