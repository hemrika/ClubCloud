using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_basisschemaRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_basisschemaState sgt_toe_basisschemaStateField;
		private int sgt_toe_basisschemaStatusField;
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
		public Sgt_toe_basisschemaState Sgt_toe_basisschemaState
		{
			get
			{
				return this.sgt_toe_basisschemaStateField;
			}
			set
			{
				this.sgt_toe_basisschemaStateField = value;
			}
		}
		public int Sgt_toe_basisschemaStatus
		{
			get
			{
				return this.sgt_toe_basisschemaStatusField;
			}
			set
			{
				this.sgt_toe_basisschemaStatusField = value;
			}
		}
	}
}
