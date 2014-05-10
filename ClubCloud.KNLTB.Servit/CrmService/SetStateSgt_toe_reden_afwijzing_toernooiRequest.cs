using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_reden_afwijzing_toernooiRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_reden_afwijzing_toernooiState sgt_toe_reden_afwijzing_toernooiStateField;
		private int sgt_toe_reden_afwijzing_toernooiStatusField;
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
		public Sgt_toe_reden_afwijzing_toernooiState Sgt_toe_reden_afwijzing_toernooiState
		{
			get
			{
				return this.sgt_toe_reden_afwijzing_toernooiStateField;
			}
			set
			{
				this.sgt_toe_reden_afwijzing_toernooiStateField = value;
			}
		}
		public int Sgt_toe_reden_afwijzing_toernooiStatus
		{
			get
			{
				return this.sgt_toe_reden_afwijzing_toernooiStatusField;
			}
			set
			{
				this.sgt_toe_reden_afwijzing_toernooiStatusField = value;
			}
		}
	}
}
