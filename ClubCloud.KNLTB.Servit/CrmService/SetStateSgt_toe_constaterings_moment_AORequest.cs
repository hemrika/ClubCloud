using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_constaterings_moment_AORequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_constaterings_moment_AOState sgt_toe_constaterings_moment_AOStateField;
		private int sgt_toe_constaterings_moment_AOStatusField;
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
		public Sgt_toe_constaterings_moment_AOState Sgt_toe_constaterings_moment_AOState
		{
			get
			{
				return this.sgt_toe_constaterings_moment_AOStateField;
			}
			set
			{
				this.sgt_toe_constaterings_moment_AOStateField = value;
			}
		}
		public int Sgt_toe_constaterings_moment_AOStatus
		{
			get
			{
				return this.sgt_toe_constaterings_moment_AOStatusField;
			}
			set
			{
				this.sgt_toe_constaterings_moment_AOStatusField = value;
			}
		}
	}
}
