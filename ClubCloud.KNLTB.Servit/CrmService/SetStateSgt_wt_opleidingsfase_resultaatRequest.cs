using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_wt_opleidingsfase_resultaatRequest : Request
	{
		private Guid entityIdField;
		private Sgt_wt_opleidingsfase_resultaatState sgt_wt_opleidingsfase_resultaatStateField;
		private int sgt_wt_opleidingsfase_resultaatStatusField;
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
		public Sgt_wt_opleidingsfase_resultaatState Sgt_wt_opleidingsfase_resultaatState
		{
			get
			{
				return this.sgt_wt_opleidingsfase_resultaatStateField;
			}
			set
			{
				this.sgt_wt_opleidingsfase_resultaatStateField = value;
			}
		}
		public int Sgt_wt_opleidingsfase_resultaatStatus
		{
			get
			{
				return this.sgt_wt_opleidingsfase_resultaatStatusField;
			}
			set
			{
				this.sgt_wt_opleidingsfase_resultaatStatusField = value;
			}
		}
	}
}
