using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_fac_factuurverzamelingRequest : Request
	{
		private Guid entityIdField;
		private Sgt_fac_factuurverzamelingState sgt_fac_factuurverzamelingStateField;
		private int sgt_fac_factuurverzamelingStatusField;
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
		public Sgt_fac_factuurverzamelingState Sgt_fac_factuurverzamelingState
		{
			get
			{
				return this.sgt_fac_factuurverzamelingStateField;
			}
			set
			{
				this.sgt_fac_factuurverzamelingStateField = value;
			}
		}
		public int Sgt_fac_factuurverzamelingStatus
		{
			get
			{
				return this.sgt_fac_factuurverzamelingStatusField;
			}
			set
			{
				this.sgt_fac_factuurverzamelingStatusField = value;
			}
		}
	}
}
