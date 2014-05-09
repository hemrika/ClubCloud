using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_toernooikalenderRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_toernooikalenderState sgt_toe_toernooikalenderStateField;
		private int sgt_toe_toernooikalenderStatusField;
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
		public Sgt_toe_toernooikalenderState Sgt_toe_toernooikalenderState
		{
			get
			{
				return this.sgt_toe_toernooikalenderStateField;
			}
			set
			{
				this.sgt_toe_toernooikalenderStateField = value;
				base.RaisePropertyChanged("Sgt_toe_toernooikalenderState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_toe_toernooikalenderStatus
		{
			get
			{
				return this.sgt_toe_toernooikalenderStatusField;
			}
			set
			{
				this.sgt_toe_toernooikalenderStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_toernooikalenderStatus");
			}
		}
	}
}
