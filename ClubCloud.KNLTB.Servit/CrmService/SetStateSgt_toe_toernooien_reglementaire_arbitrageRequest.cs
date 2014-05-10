using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_toernooien_reglementaire_arbitrageRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_toernooien_reglementaire_arbitrageState sgt_toe_toernooien_reglementaire_arbitrageStateField;
		private int sgt_toe_toernooien_reglementaire_arbitrageStatusField;
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
		public Sgt_toe_toernooien_reglementaire_arbitrageState Sgt_toe_toernooien_reglementaire_arbitrageState
		{
			get
			{
				return this.sgt_toe_toernooien_reglementaire_arbitrageStateField;
			}
			set
			{
				this.sgt_toe_toernooien_reglementaire_arbitrageStateField = value;
			}
		}
		public int Sgt_toe_toernooien_reglementaire_arbitrageStatus
		{
			get
			{
				return this.sgt_toe_toernooien_reglementaire_arbitrageStatusField;
			}
			set
			{
				this.sgt_toe_toernooien_reglementaire_arbitrageStatusField = value;
			}
		}
	}
}
