using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_com_klassegroepRequest : Request
	{
		private Guid entityIdField;
		private Sgt_com_klassegroepState sgt_com_klassegroepStateField;
		private int sgt_com_klassegroepStatusField;
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
		public Sgt_com_klassegroepState Sgt_com_klassegroepState
		{
			get
			{
				return this.sgt_com_klassegroepStateField;
			}
			set
			{
				this.sgt_com_klassegroepStateField = value;
				base.RaisePropertyChanged("Sgt_com_klassegroepState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_com_klassegroepStatus
		{
			get
			{
				return this.sgt_com_klassegroepStatusField;
			}
			set
			{
				this.sgt_com_klassegroepStatusField = value;
				base.RaisePropertyChanged("Sgt_com_klassegroepStatus");
			}
		}
	}
}
