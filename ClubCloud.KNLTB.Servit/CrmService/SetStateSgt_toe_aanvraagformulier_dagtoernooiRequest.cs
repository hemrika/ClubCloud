using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_aanvraagformulier_dagtoernooiRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_aanvraagformulier_dagtoernooiState sgt_toe_aanvraagformulier_dagtoernooiStateField;
		private int sgt_toe_aanvraagformulier_dagtoernooiStatusField;
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
		public Sgt_toe_aanvraagformulier_dagtoernooiState Sgt_toe_aanvraagformulier_dagtoernooiState
		{
			get
			{
				return this.sgt_toe_aanvraagformulier_dagtoernooiStateField;
			}
			set
			{
				this.sgt_toe_aanvraagformulier_dagtoernooiStateField = value;
			}
		}
		public int Sgt_toe_aanvraagformulier_dagtoernooiStatus
		{
			get
			{
				return this.sgt_toe_aanvraagformulier_dagtoernooiStatusField;
			}
			set
			{
				this.sgt_toe_aanvraagformulier_dagtoernooiStatusField = value;
			}
		}
	}
}
