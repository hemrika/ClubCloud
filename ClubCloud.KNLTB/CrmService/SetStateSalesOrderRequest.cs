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
	public class SetStateSalesOrderRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.SalesOrderState salesOrderStateField;

		private int salesOrderStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.SalesOrderState SalesOrderState
		{
			get
			{
				return this.salesOrderStateField;
			}
			set
			{
				this.salesOrderStateField = value;
				base.RaisePropertyChanged("SalesOrderState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int SalesOrderStatus
		{
			get
			{
				return this.salesOrderStatusField;
			}
			set
			{
				this.salesOrderStatusField = value;
				base.RaisePropertyChanged("SalesOrderStatus");
			}
		}

		public SetStateSalesOrderRequest()
		{
		}
	}
}