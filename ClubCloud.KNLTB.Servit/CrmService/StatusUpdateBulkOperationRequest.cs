using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class StatusUpdateBulkOperationRequest : Request
	{
		private Guid bulkOperationIdField;
		private int failureCountField;
		private int successCountField;
		public Guid BulkOperationId
		{
			get
			{
				return this.bulkOperationIdField;
			}
			set
			{
				this.bulkOperationIdField = value;
			}
		}
		public int FailureCount
		{
			get
			{
				return this.failureCountField;
			}
			set
			{
				this.failureCountField = value;
			}
		}
		public int SuccessCount
		{
			get
			{
				return this.successCountField;
			}
			set
			{
				this.successCountField = value;
			}
		}
	}
}
