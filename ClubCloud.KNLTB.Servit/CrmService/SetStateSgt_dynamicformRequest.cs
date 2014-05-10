using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_dynamicformRequest : Request
	{
		private Guid entityIdField;
		private Sgt_dynamicformState sgt_dynamicformStateField;
		private int sgt_dynamicformStatusField;
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
		public Sgt_dynamicformState Sgt_dynamicformState
		{
			get
			{
				return this.sgt_dynamicformStateField;
			}
			set
			{
				this.sgt_dynamicformStateField = value;
			}
		}
		public int Sgt_dynamicformStatus
		{
			get
			{
				return this.sgt_dynamicformStatusField;
			}
			set
			{
				this.sgt_dynamicformStatusField = value;
			}
		}
	}
}
