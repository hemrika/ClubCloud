using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_com_beslissingswedstrijdRequest : Request
	{
		private Guid entityIdField;
		private Sgt_com_beslissingswedstrijdState sgt_com_beslissingswedstrijdStateField;
		private int sgt_com_beslissingswedstrijdStatusField;
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
		public Sgt_com_beslissingswedstrijdState Sgt_com_beslissingswedstrijdState
		{
			get
			{
				return this.sgt_com_beslissingswedstrijdStateField;
			}
			set
			{
				this.sgt_com_beslissingswedstrijdStateField = value;
				base.RaisePropertyChanged("Sgt_com_beslissingswedstrijdState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_com_beslissingswedstrijdStatus
		{
			get
			{
				return this.sgt_com_beslissingswedstrijdStatusField;
			}
			set
			{
				this.sgt_com_beslissingswedstrijdStatusField = value;
				base.RaisePropertyChanged("Sgt_com_beslissingswedstrijdStatus");
			}
		}
	}
}
