using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_ranglijstpunten_toernooiresultaatRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_ranglijstpunten_toernooiresultaatState sgt_toe_ranglijstpunten_toernooiresultaatStateField;
		private int sgt_toe_ranglijstpunten_toernooiresultaatStatusField;
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
		public Sgt_toe_ranglijstpunten_toernooiresultaatState Sgt_toe_ranglijstpunten_toernooiresultaatState
		{
			get
			{
				return this.sgt_toe_ranglijstpunten_toernooiresultaatStateField;
			}
			set
			{
				this.sgt_toe_ranglijstpunten_toernooiresultaatStateField = value;
			}
		}
		public int Sgt_toe_ranglijstpunten_toernooiresultaatStatus
		{
			get
			{
				return this.sgt_toe_ranglijstpunten_toernooiresultaatStatusField;
			}
			set
			{
				this.sgt_toe_ranglijstpunten_toernooiresultaatStatusField = value;
			}
		}
	}
}
