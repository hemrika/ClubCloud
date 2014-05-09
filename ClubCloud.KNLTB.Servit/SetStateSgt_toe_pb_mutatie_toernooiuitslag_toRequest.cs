using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_pb_mutatie_toernooiuitslag_toRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_pb_mutatie_toernooiuitslag_toState sgt_toe_pb_mutatie_toernooiuitslag_toStateField;
		private int sgt_toe_pb_mutatie_toernooiuitslag_toStatusField;
		[XmlElement(Order = 0)]
		public Guid EntityId
		{
			get
			{
				return this.entityIdField;
			}
			set
			{
				this.entityIdField = value;
				base.RaisePropertyChanged("EntityId");
			}
		}
		[XmlElement(Order = 1)]
		public Sgt_toe_pb_mutatie_toernooiuitslag_toState Sgt_toe_pb_mutatie_toernooiuitslag_toState
		{
			get
			{
				return this.sgt_toe_pb_mutatie_toernooiuitslag_toStateField;
			}
			set
			{
				this.sgt_toe_pb_mutatie_toernooiuitslag_toStateField = value;
				base.RaisePropertyChanged("Sgt_toe_pb_mutatie_toernooiuitslag_toState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_toe_pb_mutatie_toernooiuitslag_toStatus
		{
			get
			{
				return this.sgt_toe_pb_mutatie_toernooiuitslag_toStatusField;
			}
			set
			{
				this.sgt_toe_pb_mutatie_toernooiuitslag_toStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_pb_mutatie_toernooiuitslag_toStatus");
			}
		}
	}
}
