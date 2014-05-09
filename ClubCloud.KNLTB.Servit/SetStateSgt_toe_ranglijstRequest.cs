using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_ranglijstRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_ranglijstState sgt_toe_ranglijstStateField;
		private int sgt_toe_ranglijstStatusField;
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
		public Sgt_toe_ranglijstState Sgt_toe_ranglijstState
		{
			get
			{
				return this.sgt_toe_ranglijstStateField;
			}
			set
			{
				this.sgt_toe_ranglijstStateField = value;
				base.RaisePropertyChanged("Sgt_toe_ranglijstState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_toe_ranglijstStatus
		{
			get
			{
				return this.sgt_toe_ranglijstStatusField;
			}
			set
			{
				this.sgt_toe_ranglijstStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_ranglijstStatus");
			}
		}
	}
}
