using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_zwaarte_op_toernooiniveauRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_zwaarte_op_toernooiniveauState sgt_toe_zwaarte_op_toernooiniveauStateField;
		private int sgt_toe_zwaarte_op_toernooiniveauStatusField;
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
		public Sgt_toe_zwaarte_op_toernooiniveauState Sgt_toe_zwaarte_op_toernooiniveauState
		{
			get
			{
				return this.sgt_toe_zwaarte_op_toernooiniveauStateField;
			}
			set
			{
				this.sgt_toe_zwaarte_op_toernooiniveauStateField = value;
			}
		}
		public int Sgt_toe_zwaarte_op_toernooiniveauStatus
		{
			get
			{
				return this.sgt_toe_zwaarte_op_toernooiniveauStatusField;
			}
			set
			{
				this.sgt_toe_zwaarte_op_toernooiniveauStatusField = value;
			}
		}
	}
}
