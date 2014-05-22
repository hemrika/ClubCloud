using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class GetSalesOrderProductsFromOpportunityRequest : Request
	{
		private Guid opportunityIdField;
		private Guid salesOrderIdField;
		public Guid OpportunityId
		{
			get
			{
				return this.opportunityIdField;
			}
			set
			{
				this.opportunityIdField = value;
			}
		}
		public Guid SalesOrderId
		{
			get
			{
				return this.salesOrderIdField;
			}
			set
			{
				this.salesOrderIdField = value;
			}
		}
	}
}