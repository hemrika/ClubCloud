using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_pb_mutatie_toernooiuitslag_setRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_pb_mutatie_toernooiuitslag_setState sgt_toe_pb_mutatie_toernooiuitslag_setStateField;
		private int sgt_toe_pb_mutatie_toernooiuitslag_setStatusField;
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
		public Sgt_toe_pb_mutatie_toernooiuitslag_setState Sgt_toe_pb_mutatie_toernooiuitslag_setState
		{
			get
			{
				return this.sgt_toe_pb_mutatie_toernooiuitslag_setStateField;
			}
			set
			{
				this.sgt_toe_pb_mutatie_toernooiuitslag_setStateField = value;
				base.RaisePropertyChanged("Sgt_toe_pb_mutatie_toernooiuitslag_setState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_toe_pb_mutatie_toernooiuitslag_setStatus
		{
			get
			{
				return this.sgt_toe_pb_mutatie_toernooiuitslag_setStatusField;
			}
			set
			{
				this.sgt_toe_pb_mutatie_toernooiuitslag_setStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_pb_mutatie_toernooiuitslag_setStatus");
			}
		}
	}
}
