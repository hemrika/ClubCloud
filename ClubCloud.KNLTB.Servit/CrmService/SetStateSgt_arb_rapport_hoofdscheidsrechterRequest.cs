using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_arb_rapport_hoofdscheidsrechterRequest : Request
	{
		private Guid entityIdField;
		private Sgt_arb_rapport_hoofdscheidsrechterState sgt_arb_rapport_hoofdscheidsrechterStateField;
		private int sgt_arb_rapport_hoofdscheidsrechterStatusField;
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
		public Sgt_arb_rapport_hoofdscheidsrechterState Sgt_arb_rapport_hoofdscheidsrechterState
		{
			get
			{
				return this.sgt_arb_rapport_hoofdscheidsrechterStateField;
			}
			set
			{
				this.sgt_arb_rapport_hoofdscheidsrechterStateField = value;
			}
		}
		public int Sgt_arb_rapport_hoofdscheidsrechterStatus
		{
			get
			{
				return this.sgt_arb_rapport_hoofdscheidsrechterStatusField;
			}
			set
			{
				this.sgt_arb_rapport_hoofdscheidsrechterStatusField = value;
			}
		}
	}
}
