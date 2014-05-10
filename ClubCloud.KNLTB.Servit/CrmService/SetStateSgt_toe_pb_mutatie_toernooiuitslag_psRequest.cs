using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_pb_mutatie_toernooiuitslag_psRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_pb_mutatie_toernooiuitslag_psState sgt_toe_pb_mutatie_toernooiuitslag_psStateField;
		private int sgt_toe_pb_mutatie_toernooiuitslag_psStatusField;
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
		public Sgt_toe_pb_mutatie_toernooiuitslag_psState Sgt_toe_pb_mutatie_toernooiuitslag_psState
		{
			get
			{
				return this.sgt_toe_pb_mutatie_toernooiuitslag_psStateField;
			}
			set
			{
				this.sgt_toe_pb_mutatie_toernooiuitslag_psStateField = value;
			}
		}
		public int Sgt_toe_pb_mutatie_toernooiuitslag_psStatus
		{
			get
			{
				return this.sgt_toe_pb_mutatie_toernooiuitslag_psStatusField;
			}
			set
			{
				this.sgt_toe_pb_mutatie_toernooiuitslag_psStatusField = value;
			}
		}
	}
}
