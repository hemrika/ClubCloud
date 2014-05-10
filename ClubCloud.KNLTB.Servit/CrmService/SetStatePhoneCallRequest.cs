using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStatePhoneCallRequest : Request
	{
		private Guid entityIdField;
		private PhoneCallState phoneCallStateField;
		private int phoneCallStatusField;
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
		public PhoneCallState PhoneCallState
		{
			get
			{
				return this.phoneCallStateField;
			}
			set
			{
				this.phoneCallStateField = value;
			}
		}
		public int PhoneCallStatus
		{
			get
			{
				return this.phoneCallStatusField;
			}
			set
			{
				this.phoneCallStatusField = value;
			}
		}
	}
}
