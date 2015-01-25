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
	public class ProcessOneMemberBulkOperationRequest : Request
	{
		private Guid bulkOperationIdField;

		private BusinessEntity entityField;

		private ClubCloud.KNLTB.ServIt.CrmService.BulkOperationSource bulkOperationSourceField;

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

		[XmlElement] //[XmlElement(Order=2)]
		public ClubCloud.KNLTB.ServIt.CrmService.BulkOperationSource BulkOperationSource
		{
			get
			{
				return this.bulkOperationSourceField;
			}
			set
			{
				this.bulkOperationSourceField = value;
				base.RaisePropertyChanged("BulkOperationSource");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public BusinessEntity Entity
		{
			get
			{
				return this.entityField;
			}
			set
			{
				this.entityField = value;
				base.RaisePropertyChanged("Entity");
			}
		}

		public ProcessOneMemberBulkOperationRequest()
		{
		}
	}
}