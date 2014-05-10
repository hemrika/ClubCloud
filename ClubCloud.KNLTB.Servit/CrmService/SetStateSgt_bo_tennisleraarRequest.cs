using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_bo_tennisleraarRequest : Request
	{
		private Guid entityIdField;
		private Sgt_bo_tennisleraarState sgt_bo_tennisleraarStateField;
		private int sgt_bo_tennisleraarStatusField;
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
		public Sgt_bo_tennisleraarState Sgt_bo_tennisleraarState
		{
			get
			{
				return this.sgt_bo_tennisleraarStateField;
			}
			set
			{
				this.sgt_bo_tennisleraarStateField = value;
			}
		}
		public int Sgt_bo_tennisleraarStatus
		{
			get
			{
				return this.sgt_bo_tennisleraarStatusField;
			}
			set
			{
				this.sgt_bo_tennisleraarStatusField = value;
			}
		}
	}
}
