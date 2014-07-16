using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[GeneratedCode("System.Xml", "4.0.30319.33440")]
	[Serializable]
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2007/WebServices")]
	public class SetStateOrderCloseRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.OrderCloseState orderCloseStateField;

		private int orderCloseStatusField;

		[XmlElement] //[XmlElement(Order=0)]
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

		[XmlElement] //[XmlElement(Order=1)]
		public ClubCloud.KNLTB.ServIt.CrmService.OrderCloseState OrderCloseState
		{
			get
			{
				return this.orderCloseStateField;
			}
			set
			{
				this.orderCloseStateField = value;
				base.RaisePropertyChanged("OrderCloseState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int OrderCloseStatus
		{
			get
			{
				return this.orderCloseStatusField;
			}
			set
			{
				this.orderCloseStatusField = value;
				base.RaisePropertyChanged("OrderCloseStatus");
			}
		}

		public SetStateOrderCloseRequest()
		{
		}
	}
}