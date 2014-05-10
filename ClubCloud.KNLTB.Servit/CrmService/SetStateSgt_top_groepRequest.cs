using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_top_groepRequest : Request
	{
		private Guid entityIdField;
		private Sgt_top_groepState sgt_top_groepStateField;
		private int sgt_top_groepStatusField;
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
		public Sgt_top_groepState Sgt_top_groepState
		{
			get
			{
				return this.sgt_top_groepStateField;
			}
			set
			{
				this.sgt_top_groepStateField = value;
			}
		}
		public int Sgt_top_groepStatus
		{
			get
			{
				return this.sgt_top_groepStatusField;
			}
			set
			{
				this.sgt_top_groepStatusField = value;
			}
		}
	}
}
