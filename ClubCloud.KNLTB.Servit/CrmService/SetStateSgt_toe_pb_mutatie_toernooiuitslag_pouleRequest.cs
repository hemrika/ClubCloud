using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_pb_mutatie_toernooiuitslag_pouleRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_pb_mutatie_toernooiuitslag_pouleState sgt_toe_pb_mutatie_toernooiuitslag_pouleStateField;
		private int sgt_toe_pb_mutatie_toernooiuitslag_pouleStatusField;
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
		public Sgt_toe_pb_mutatie_toernooiuitslag_pouleState Sgt_toe_pb_mutatie_toernooiuitslag_pouleState
		{
			get
			{
				return this.sgt_toe_pb_mutatie_toernooiuitslag_pouleStateField;
			}
			set
			{
				this.sgt_toe_pb_mutatie_toernooiuitslag_pouleStateField = value;
			}
		}
		public int Sgt_toe_pb_mutatie_toernooiuitslag_pouleStatus
		{
			get
			{
				return this.sgt_toe_pb_mutatie_toernooiuitslag_pouleStatusField;
			}
			set
			{
				this.sgt_toe_pb_mutatie_toernooiuitslag_pouleStatusField = value;
			}
		}
	}
}
