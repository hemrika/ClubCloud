using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_schemasoortRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_schemasoortState sgt_toe_schemasoortStateField;
		private int sgt_toe_schemasoortStatusField;
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
		public Sgt_toe_schemasoortState Sgt_toe_schemasoortState
		{
			get
			{
				return this.sgt_toe_schemasoortStateField;
			}
			set
			{
				this.sgt_toe_schemasoortStateField = value;
			}
		}
		public int Sgt_toe_schemasoortStatus
		{
			get
			{
				return this.sgt_toe_schemasoortStatusField;
			}
			set
			{
				this.sgt_toe_schemasoortStatusField = value;
			}
		}
	}
}