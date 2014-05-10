using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_com_speelschema_tegenovergesteldRequest : Request
	{
		private Guid entityIdField;
		private Sgt_com_speelschema_tegenovergesteldState sgt_com_speelschema_tegenovergesteldStateField;
		private int sgt_com_speelschema_tegenovergesteldStatusField;
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
		public Sgt_com_speelschema_tegenovergesteldState Sgt_com_speelschema_tegenovergesteldState
		{
			get
			{
				return this.sgt_com_speelschema_tegenovergesteldStateField;
			}
			set
			{
				this.sgt_com_speelschema_tegenovergesteldStateField = value;
			}
		}
		public int Sgt_com_speelschema_tegenovergesteldStatus
		{
			get
			{
				return this.sgt_com_speelschema_tegenovergesteldStatusField;
			}
			set
			{
				this.sgt_com_speelschema_tegenovergesteldStatusField = value;
			}
		}
	}
}
