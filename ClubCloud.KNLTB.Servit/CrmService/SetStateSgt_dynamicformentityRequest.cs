using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_dynamicformentityRequest : Request
	{
		private Guid entityIdField;
		private Sgt_dynamicformentityState sgt_dynamicformentityStateField;
		private int sgt_dynamicformentityStatusField;
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
		public Sgt_dynamicformentityState Sgt_dynamicformentityState
		{
			get
			{
				return this.sgt_dynamicformentityStateField;
			}
			set
			{
				this.sgt_dynamicformentityStateField = value;
			}
		}
		public int Sgt_dynamicformentityStatus
		{
			get
			{
				return this.sgt_dynamicformentityStatusField;
			}
			set
			{
				this.sgt_dynamicformentityStatusField = value;
			}
		}
	}
}
