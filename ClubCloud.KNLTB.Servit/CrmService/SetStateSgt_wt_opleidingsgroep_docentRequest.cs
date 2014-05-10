using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_wt_opleidingsgroep_docentRequest : Request
	{
		private Guid entityIdField;
		private Sgt_wt_opleidingsgroep_docentState sgt_wt_opleidingsgroep_docentStateField;
		private int sgt_wt_opleidingsgroep_docentStatusField;
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
		public Sgt_wt_opleidingsgroep_docentState Sgt_wt_opleidingsgroep_docentState
		{
			get
			{
				return this.sgt_wt_opleidingsgroep_docentStateField;
			}
			set
			{
				this.sgt_wt_opleidingsgroep_docentStateField = value;
			}
		}
		public int Sgt_wt_opleidingsgroep_docentStatus
		{
			get
			{
				return this.sgt_wt_opleidingsgroep_docentStatusField;
			}
			set
			{
				this.sgt_wt_opleidingsgroep_docentStatusField = value;
			}
		}
	}
}
