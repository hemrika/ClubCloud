using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_toernooischemaRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_toernooischemaState sgt_toe_toernooischemaStateField;
		private int sgt_toe_toernooischemaStatusField;
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
		public Sgt_toe_toernooischemaState Sgt_toe_toernooischemaState
		{
			get
			{
				return this.sgt_toe_toernooischemaStateField;
			}
			set
			{
				this.sgt_toe_toernooischemaStateField = value;
				base.RaisePropertyChanged("Sgt_toe_toernooischemaState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_toe_toernooischemaStatus
		{
			get
			{
				return this.sgt_toe_toernooischemaStatusField;
			}
			set
			{
				this.sgt_toe_toernooischemaStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_toernooischemaStatus");
			}
		}
	}
}
