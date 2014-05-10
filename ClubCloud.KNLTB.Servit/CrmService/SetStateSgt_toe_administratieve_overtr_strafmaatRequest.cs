using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_administratieve_overtr_strafmaatRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_administratieve_overtr_strafmaatState sgt_toe_administratieve_overtr_strafmaatStateField;
		private int sgt_toe_administratieve_overtr_strafmaatStatusField;
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
		public Sgt_toe_administratieve_overtr_strafmaatState Sgt_toe_administratieve_overtr_strafmaatState
		{
			get
			{
				return this.sgt_toe_administratieve_overtr_strafmaatStateField;
			}
			set
			{
				this.sgt_toe_administratieve_overtr_strafmaatStateField = value;
			}
		}
		public int Sgt_toe_administratieve_overtr_strafmaatStatus
		{
			get
			{
				return this.sgt_toe_administratieve_overtr_strafmaatStatusField;
			}
			set
			{
				this.sgt_toe_administratieve_overtr_strafmaatStatusField = value;
			}
		}
	}
}
