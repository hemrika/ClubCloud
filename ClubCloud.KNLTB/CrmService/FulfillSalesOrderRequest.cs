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
	public class FulfillSalesOrderRequest : Request
	{
		private BusinessEntity orderCloseField;

		private int statusField;

		[XmlElement] //[XmlElement(Order=0)]
		public BusinessEntity OrderClose
		{
			get
			{
				return this.orderCloseField;
			}
			set
			{
				this.orderCloseField = value;
				base.RaisePropertyChanged("OrderClose");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public int Status
		{
			get
			{
				return this.statusField;
			}
			set
			{
				this.statusField = value;
				base.RaisePropertyChanged("Status");
			}
		}

		public FulfillSalesOrderRequest()
		{
		}
	}
}