using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class LogFailureBulkOperationRequest : Request
	{
		private Guid bulkOperationIdField;
		private Guid regardingObjectIdField;
		private int regardingObjectTypeCodeField;
		private int errorCodeField;
		private string messageField;
		private string additionalInfoField;
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
		public Guid RegardingObjectId
		{
			get
			{
				return this.regardingObjectIdField;
			}
			set
			{
				this.regardingObjectIdField = value;
			}
		}
		public int RegardingObjectTypeCode
		{
			get
			{
				return this.regardingObjectTypeCodeField;
			}
			set
			{
				this.regardingObjectTypeCodeField = value;
			}
		}
		public int ErrorCode
		{
			get
			{
				return this.errorCodeField;
			}
			set
			{
				this.errorCodeField = value;
			}
		}
		public string Message
		{
			get
			{
				return this.messageField;
			}
			set
			{
				this.messageField = value;
			}
		}
		public string AdditionalInfo
		{
			get
			{
				return this.additionalInfoField;
			}
			set
			{
				this.additionalInfoField = value;
			}
		}
	}
}
