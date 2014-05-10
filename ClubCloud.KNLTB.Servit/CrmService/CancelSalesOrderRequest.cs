using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class CancelSalesOrderRequest : Request
	{
		private BusinessEntity orderCloseField;
		private int statusField;
		public BusinessEntity OrderClose
		{
			get
			{
				return this.orderCloseField;
			}
			set
			{
				this.orderCloseField = value;
			}
		}
		public int Status
		{
			get
			{
				return this.statusField;
			}
			set
			{
				this.statusField = value;
			}
		}
	}
}
