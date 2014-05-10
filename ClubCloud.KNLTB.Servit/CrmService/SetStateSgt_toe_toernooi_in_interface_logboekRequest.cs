using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_toernooi_in_interface_logboekRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_toernooi_in_interface_logboekState sgt_toe_toernooi_in_interface_logboekStateField;
		private int sgt_toe_toernooi_in_interface_logboekStatusField;
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
		public Sgt_toe_toernooi_in_interface_logboekState Sgt_toe_toernooi_in_interface_logboekState
		{
			get
			{
				return this.sgt_toe_toernooi_in_interface_logboekStateField;
			}
			set
			{
				this.sgt_toe_toernooi_in_interface_logboekStateField = value;
			}
		}
		public int Sgt_toe_toernooi_in_interface_logboekStatus
		{
			get
			{
				return this.sgt_toe_toernooi_in_interface_logboekStatusField;
			}
			set
			{
				this.sgt_toe_toernooi_in_interface_logboekStatusField = value;
			}
		}
	}
}
