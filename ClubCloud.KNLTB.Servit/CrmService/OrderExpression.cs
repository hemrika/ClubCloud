using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2006/Query")]
	[Serializable]
	public class OrderExpression
	{
		private string attributeNameField;
		private OrderType orderTypeField;
		public string AttributeName
		{
			get
			{
				return this.attributeNameField;
			}
			set
			{
				this.attributeNameField = value;
			}
		}
		public OrderType OrderType
		{
			get
			{
				return this.orderTypeField;
			}
			set
			{
				this.orderTypeField = value;
			}
		}
	}
}
