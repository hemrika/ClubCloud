using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class BulkOperationStatusCloseRequest : Request
	{
		private Guid bulkOperationIdField;
		private int failureCountField;
		private int successCountField;
		private int statusReasonField;
		private int errorCodeField;
		[XmlElement(Order = 0)]
		public Guid BulkOperationId
		{
			get
			{
				return this.bulkOperationIdField;
			}
			set
			{
				this.bulkOperationIdField = value;
				base.RaisePropertyChanged("BulkOperationId");
			}
		}
		[XmlElement(Order = 1)]
		public int FailureCount
		{
			get
			{
				return this.failureCountField;
			}
			set
			{
				this.failureCountField = value;
				base.RaisePropertyChanged("FailureCount");
			}
		}
		[XmlElement(Order = 2)]
		public int SuccessCount
		{
			get
			{
				return this.successCountField;
			}
			set
			{
				this.successCountField = value;
				base.RaisePropertyChanged("SuccessCount");
			}
		}
		[XmlElement(Order = 3)]
		public int StatusReason
		{
			get
			{
				return this.statusReasonField;
			}
			set
			{
				this.statusReasonField = value;
				base.RaisePropertyChanged("StatusReason");
			}
		}
		[XmlElement(Order = 4)]
		public int ErrorCode
		{
			get
			{
				return this.errorCodeField;
			}
			set
			{
				this.errorCodeField = value;
				base.RaisePropertyChanged("ErrorCode");
			}
		}
	}
}
