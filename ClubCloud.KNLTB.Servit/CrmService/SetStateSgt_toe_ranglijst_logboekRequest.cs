using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_ranglijst_logboekRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_ranglijst_logboekState sgt_toe_ranglijst_logboekStateField;
		private int sgt_toe_ranglijst_logboekStatusField;
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
		public Sgt_toe_ranglijst_logboekState Sgt_toe_ranglijst_logboekState
		{
			get
			{
				return this.sgt_toe_ranglijst_logboekStateField;
			}
			set
			{
				this.sgt_toe_ranglijst_logboekStateField = value;
			}
		}
		public int Sgt_toe_ranglijst_logboekStatus
		{
			get
			{
				return this.sgt_toe_ranglijst_logboekStatusField;
			}
			set
			{
				this.sgt_toe_ranglijst_logboekStatusField = value;
			}
		}
	}
}
