using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_autorisatie_padenRequest : Request
	{
		private Guid entityIdField;
		private Sgt_autorisatie_padenState sgt_autorisatie_padenStateField;
		private int sgt_autorisatie_padenStatusField;
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
		public Sgt_autorisatie_padenState Sgt_autorisatie_padenState
		{
			get
			{
				return this.sgt_autorisatie_padenStateField;
			}
			set
			{
				this.sgt_autorisatie_padenStateField = value;
			}
		}
		public int Sgt_autorisatie_padenStatus
		{
			get
			{
				return this.sgt_autorisatie_padenStatusField;
			}
			set
			{
				this.sgt_autorisatie_padenStatusField = value;
			}
		}
	}
}
