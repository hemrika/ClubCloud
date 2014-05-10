using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_com_competitietypeRequest : Request
	{
		private Guid entityIdField;
		private Sgt_com_competitietypeState sgt_com_competitietypeStateField;
		private int sgt_com_competitietypeStatusField;
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
		public Sgt_com_competitietypeState Sgt_com_competitietypeState
		{
			get
			{
				return this.sgt_com_competitietypeStateField;
			}
			set
			{
				this.sgt_com_competitietypeStateField = value;
			}
		}
		public int Sgt_com_competitietypeStatus
		{
			get
			{
				return this.sgt_com_competitietypeStatusField;
			}
			set
			{
				this.sgt_com_competitietypeStatusField = value;
			}
		}
	}
}
