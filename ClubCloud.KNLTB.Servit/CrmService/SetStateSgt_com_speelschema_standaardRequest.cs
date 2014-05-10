using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_com_speelschema_standaardRequest : Request
	{
		private Guid entityIdField;
		private Sgt_com_speelschema_standaardState sgt_com_speelschema_standaardStateField;
		private int sgt_com_speelschema_standaardStatusField;
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
		public Sgt_com_speelschema_standaardState Sgt_com_speelschema_standaardState
		{
			get
			{
				return this.sgt_com_speelschema_standaardStateField;
			}
			set
			{
				this.sgt_com_speelschema_standaardStateField = value;
			}
		}
		public int Sgt_com_speelschema_standaardStatus
		{
			get
			{
				return this.sgt_com_speelschema_standaardStatusField;
			}
			set
			{
				this.sgt_com_speelschema_standaardStatusField = value;
			}
		}
	}
}
