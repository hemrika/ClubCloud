using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_com_afdelingRequest : Request
	{
		private Guid entityIdField;
		private Sgt_com_afdelingState sgt_com_afdelingStateField;
		private int sgt_com_afdelingStatusField;
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
		public Sgt_com_afdelingState Sgt_com_afdelingState
		{
			get
			{
				return this.sgt_com_afdelingStateField;
			}
			set
			{
				this.sgt_com_afdelingStateField = value;
			}
		}
		public int Sgt_com_afdelingStatus
		{
			get
			{
				return this.sgt_com_afdelingStatusField;
			}
			set
			{
				this.sgt_com_afdelingStatusField = value;
			}
		}
	}
}
