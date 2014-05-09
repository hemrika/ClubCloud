using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSalesOrderRequest : Request
	{
		private Guid entityIdField;
		private SalesOrderState salesOrderStateField;
		private int salesOrderStatusField;
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
		public SalesOrderState SalesOrderState
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
		[XmlElement(Order = 2)]
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
	}
}
