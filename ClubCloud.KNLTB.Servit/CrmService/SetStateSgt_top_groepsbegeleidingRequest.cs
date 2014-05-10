using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_top_groepsbegeleidingRequest : Request
	{
		private Guid entityIdField;
		private Sgt_top_groepsbegeleidingState sgt_top_groepsbegeleidingStateField;
		private int sgt_top_groepsbegeleidingStatusField;
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
		public Sgt_top_groepsbegeleidingState Sgt_top_groepsbegeleidingState
		{
			get
			{
				return this.sgt_top_groepsbegeleidingStateField;
			}
			set
			{
				this.sgt_top_groepsbegeleidingStateField = value;
			}
		}
		public int Sgt_top_groepsbegeleidingStatus
		{
			get
			{
				return this.sgt_top_groepsbegeleidingStatusField;
			}
			set
			{
				this.sgt_top_groepsbegeleidingStatusField = value;
			}
		}
	}
}
