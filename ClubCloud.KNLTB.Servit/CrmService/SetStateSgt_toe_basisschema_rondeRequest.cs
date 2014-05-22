using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_basisschema_rondeRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_basisschema_rondeState sgt_toe_basisschema_rondeStateField;
		private int sgt_toe_basisschema_rondeStatusField;
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
		public Sgt_toe_basisschema_rondeState Sgt_toe_basisschema_rondeState
		{
			get
			{
				return this.sgt_toe_basisschema_rondeStateField;
			}
			set
			{
				this.sgt_toe_basisschema_rondeStateField = value;
			}
		}
		public int Sgt_toe_basisschema_rondeStatus
		{
			get
			{
				return this.sgt_toe_basisschema_rondeStatusField;
			}
			set
			{
				this.sgt_toe_basisschema_rondeStatusField = value;
			}
		}
	}
}