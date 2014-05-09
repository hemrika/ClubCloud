using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_com_klasseRequest : Request
	{
		private Guid entityIdField;
		private Sgt_com_klasseState sgt_com_klasseStateField;
		private int sgt_com_klasseStatusField;
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
		public Sgt_com_klasseState Sgt_com_klasseState
		{
			get
			{
				return this.sgt_com_klasseStateField;
			}
			set
			{
				this.sgt_com_klasseStateField = value;
				base.RaisePropertyChanged("Sgt_com_klasseState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_com_klasseStatus
		{
			get
			{
				return this.sgt_com_klasseStatusField;
			}
			set
			{
				this.sgt_com_klasseStatusField = value;
				base.RaisePropertyChanged("Sgt_com_klasseStatus");
			}
		}
	}
}
