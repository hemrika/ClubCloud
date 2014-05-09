using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_prijzengeldRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_prijzengeldState sgt_toe_prijzengeldStateField;
		private int sgt_toe_prijzengeldStatusField;
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
		public Sgt_toe_prijzengeldState Sgt_toe_prijzengeldState
		{
			get
			{
				return this.sgt_toe_prijzengeldStateField;
			}
			set
			{
				this.sgt_toe_prijzengeldStateField = value;
				base.RaisePropertyChanged("Sgt_toe_prijzengeldState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_toe_prijzengeldStatus
		{
			get
			{
				return this.sgt_toe_prijzengeldStatusField;
			}
			set
			{
				this.sgt_toe_prijzengeldStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_prijzengeldStatus");
			}
		}
	}
}
