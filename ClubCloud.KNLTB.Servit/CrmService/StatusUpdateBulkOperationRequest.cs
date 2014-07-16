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
	public class StatusUpdateBulkOperationRequest : Request
	{
		private Guid bulkOperationIdField;

		private int failureCountField;

		private int successCountField;

		[XmlElement] //[XmlElement(Order=0)]
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

		[XmlElement] //[XmlElement(Order=1)]
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

		[XmlElement] //[XmlElement(Order=2)]
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

		public StatusUpdateBulkOperationRequest()
		{
		}
	}
}