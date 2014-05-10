using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_spelersmemoRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_spelersmemoState sgt_toe_spelersmemoStateField;
		private int sgt_toe_spelersmemoStatusField;
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
		public Sgt_toe_spelersmemoState Sgt_toe_spelersmemoState
		{
			get
			{
				return this.sgt_toe_spelersmemoStateField;
			}
			set
			{
				this.sgt_toe_spelersmemoStateField = value;
			}
		}
		public int Sgt_toe_spelersmemoStatus
		{
			get
			{
				return this.sgt_toe_spelersmemoStatusField;
			}
			set
			{
				this.sgt_toe_spelersmemoStatusField = value;
			}
		}
	}
}
