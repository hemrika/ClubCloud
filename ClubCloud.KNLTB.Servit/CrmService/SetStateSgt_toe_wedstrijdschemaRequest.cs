using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_wedstrijdschemaRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_wedstrijdschemaState sgt_toe_wedstrijdschemaStateField;
		private int sgt_toe_wedstrijdschemaStatusField;
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
		public Sgt_toe_wedstrijdschemaState Sgt_toe_wedstrijdschemaState
		{
			get
			{
				return this.sgt_toe_wedstrijdschemaStateField;
			}
			set
			{
				this.sgt_toe_wedstrijdschemaStateField = value;
			}
		}
		public int Sgt_toe_wedstrijdschemaStatus
		{
			get
			{
				return this.sgt_toe_wedstrijdschemaStatusField;
			}
			set
			{
				this.sgt_toe_wedstrijdschemaStatusField = value;
			}
		}
	}
}
