using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_toernooionderdeel_ranglijstRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_toernooionderdeel_ranglijstState sgt_toe_toernooionderdeel_ranglijstStateField;
		private int sgt_toe_toernooionderdeel_ranglijstStatusField;
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
		public Sgt_toe_toernooionderdeel_ranglijstState Sgt_toe_toernooionderdeel_ranglijstState
		{
			get
			{
				return this.sgt_toe_toernooionderdeel_ranglijstStateField;
			}
			set
			{
				this.sgt_toe_toernooionderdeel_ranglijstStateField = value;
			}
		}
		public int Sgt_toe_toernooionderdeel_ranglijstStatus
		{
			get
			{
				return this.sgt_toe_toernooionderdeel_ranglijstStatusField;
			}
			set
			{
				this.sgt_toe_toernooionderdeel_ranglijstStatusField = value;
			}
		}
	}
}