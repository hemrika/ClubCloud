using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_partij_uitslag_toernooiRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_partij_uitslag_toernooiState sgt_toe_partij_uitslag_toernooiStateField;
		private int sgt_toe_partij_uitslag_toernooiStatusField;
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
		public Sgt_toe_partij_uitslag_toernooiState Sgt_toe_partij_uitslag_toernooiState
		{
			get
			{
				return this.sgt_toe_partij_uitslag_toernooiStateField;
			}
			set
			{
				this.sgt_toe_partij_uitslag_toernooiStateField = value;
			}
		}
		public int Sgt_toe_partij_uitslag_toernooiStatus
		{
			get
			{
				return this.sgt_toe_partij_uitslag_toernooiStatusField;
			}
			set
			{
				this.sgt_toe_partij_uitslag_toernooiStatusField = value;
			}
		}
	}
}
