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
	public class RetrieveMembersBulkOperationRequest : Request
	{
		private Guid bulkOperationIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.BulkOperationSource bulkOperationSourceField;

		private ClubCloud.KNLTB.ServIt.CrmService.EntitySource entitySourceField;

		private QueryBase queryField;

		private bool returnDynamicEntitiesField;

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

		[XmlElement] //[XmlElement(Order=2)]
		public ClubCloud.KNLTB.ServIt.CrmService.EntitySource EntitySource
		{
			get
			{
				return this.entitySourceField;
			}
			set
			{
				this.entitySourceField = value;
				base.RaisePropertyChanged("EntitySource");
			}
		}

		[XmlElement] //[XmlElement(Order=3)]
		public QueryBase Query
		{
			get
			{
				return this.queryField;
			}
			set
			{
				this.queryField = value;
				base.RaisePropertyChanged("Query");
			}
		}

		[XmlAttribute]
		public bool ReturnDynamicEntities
		{
			get
			{
				return this.returnDynamicEntitiesField;
			}
			set
			{
				this.returnDynamicEntitiesField = value;
				base.RaisePropertyChanged("ReturnDynamicEntities");
			}
		}

		public RetrieveMembersBulkOperationRequest()
		{
		}
	}
}