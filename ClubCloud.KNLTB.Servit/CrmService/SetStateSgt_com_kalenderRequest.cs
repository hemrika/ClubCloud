using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_com_kalenderRequest : Request
	{
		private Guid entityIdField;
		private Sgt_com_kalenderState sgt_com_kalenderStateField;
		private int sgt_com_kalenderStatusField;
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
		public Sgt_com_kalenderState Sgt_com_kalenderState
		{
			get
			{
				return this.sgt_com_kalenderStateField;
			}
			set
			{
				this.sgt_com_kalenderStateField = value;
			}
		}
		public int Sgt_com_kalenderStatus
		{
			get
			{
				return this.sgt_com_kalenderStatusField;
			}
			set
			{
				this.sgt_com_kalenderStatusField = value;
			}
		}
	}
}
