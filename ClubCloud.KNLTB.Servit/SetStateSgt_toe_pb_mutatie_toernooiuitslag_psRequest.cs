using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_pb_mutatie_toernooiuitslag_psRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_pb_mutatie_toernooiuitslag_psState sgt_toe_pb_mutatie_toernooiuitslag_psStateField;
		private int sgt_toe_pb_mutatie_toernooiuitslag_psStatusField;
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
		public Sgt_toe_pb_mutatie_toernooiuitslag_psState Sgt_toe_pb_mutatie_toernooiuitslag_psState
		{
			get
			{
				return this.sgt_toe_pb_mutatie_toernooiuitslag_psStateField;
			}
			set
			{
				this.sgt_toe_pb_mutatie_toernooiuitslag_psStateField = value;
				base.RaisePropertyChanged("Sgt_toe_pb_mutatie_toernooiuitslag_psState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_toe_pb_mutatie_toernooiuitslag_psStatus
		{
			get
			{
				return this.sgt_toe_pb_mutatie_toernooiuitslag_psStatusField;
			}
			set
			{
				this.sgt_toe_pb_mutatie_toernooiuitslag_psStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_pb_mutatie_toernooiuitslag_psStatus");
			}
		}
	}
}
