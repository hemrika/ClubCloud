using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_pb_mutatie_toernooiuitslag_teamRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_pb_mutatie_toernooiuitslag_teamState sgt_toe_pb_mutatie_toernooiuitslag_teamStateField;
		private int sgt_toe_pb_mutatie_toernooiuitslag_teamStatusField;
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
		public Sgt_toe_pb_mutatie_toernooiuitslag_teamState Sgt_toe_pb_mutatie_toernooiuitslag_teamState
		{
			get
			{
				return this.sgt_toe_pb_mutatie_toernooiuitslag_teamStateField;
			}
			set
			{
				this.sgt_toe_pb_mutatie_toernooiuitslag_teamStateField = value;
				base.RaisePropertyChanged("Sgt_toe_pb_mutatie_toernooiuitslag_teamState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_toe_pb_mutatie_toernooiuitslag_teamStatus
		{
			get
			{
				return this.sgt_toe_pb_mutatie_toernooiuitslag_teamStatusField;
			}
			set
			{
				this.sgt_toe_pb_mutatie_toernooiuitslag_teamStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_pb_mutatie_toernooiuitslag_teamStatus");
			}
		}
	}
}
