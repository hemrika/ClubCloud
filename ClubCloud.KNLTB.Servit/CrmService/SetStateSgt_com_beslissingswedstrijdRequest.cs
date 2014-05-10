using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_com_beslissingswedstrijdRequest : Request
	{
		private Guid entityIdField;
		private Sgt_com_beslissingswedstrijdState sgt_com_beslissingswedstrijdStateField;
		private int sgt_com_beslissingswedstrijdStatusField;
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
		public Sgt_com_beslissingswedstrijdState Sgt_com_beslissingswedstrijdState
		{
			get
			{
				return this.sgt_com_beslissingswedstrijdStateField;
			}
			set
			{
				this.sgt_com_beslissingswedstrijdStateField = value;
			}
		}
		public int Sgt_com_beslissingswedstrijdStatus
		{
			get
			{
				return this.sgt_com_beslissingswedstrijdStatusField;
			}
			set
			{
				this.sgt_com_beslissingswedstrijdStatusField = value;
			}
		}
	}
}
