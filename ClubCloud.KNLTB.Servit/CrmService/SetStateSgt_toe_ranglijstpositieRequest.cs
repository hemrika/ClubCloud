using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_ranglijstpositieRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_ranglijstpositieState sgt_toe_ranglijstpositieStateField;
		private int sgt_toe_ranglijstpositieStatusField;
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
		public Sgt_toe_ranglijstpositieState Sgt_toe_ranglijstpositieState
		{
			get
			{
				return this.sgt_toe_ranglijstpositieStateField;
			}
			set
			{
				this.sgt_toe_ranglijstpositieStateField = value;
			}
		}
		public int Sgt_toe_ranglijstpositieStatus
		{
			get
			{
				return this.sgt_toe_ranglijstpositieStatusField;
			}
			set
			{
				this.sgt_toe_ranglijstpositieStatusField = value;
			}
		}
	}
}
