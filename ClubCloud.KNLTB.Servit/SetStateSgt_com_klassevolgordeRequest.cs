using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_com_klassevolgordeRequest : Request
	{
		private Guid entityIdField;
		private Sgt_com_klassevolgordeState sgt_com_klassevolgordeStateField;
		private int sgt_com_klassevolgordeStatusField;
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
		public Sgt_com_klassevolgordeState Sgt_com_klassevolgordeState
		{
			get
			{
				return this.sgt_com_klassevolgordeStateField;
			}
			set
			{
				this.sgt_com_klassevolgordeStateField = value;
				base.RaisePropertyChanged("Sgt_com_klassevolgordeState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_com_klassevolgordeStatus
		{
			get
			{
				return this.sgt_com_klassevolgordeStatusField;
			}
			set
			{
				this.sgt_com_klassevolgordeStatusField = value;
				base.RaisePropertyChanged("Sgt_com_klassevolgordeStatus");
			}
		}
	}
}
