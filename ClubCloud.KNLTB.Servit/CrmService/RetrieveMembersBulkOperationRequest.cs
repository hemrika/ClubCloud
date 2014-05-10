using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class RetrieveMembersBulkOperationRequest : Request
	{
		private Guid bulkOperationIdField;
		private BulkOperationSource bulkOperationSourceField;
		private EntitySource entitySourceField;
		private QueryBase queryField;
		private bool returnDynamicEntitiesField;
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
		public BulkOperationSource BulkOperationSource
		{
			get
			{
				return this.bulkOperationSourceField;
			}
			set
			{
				this.bulkOperationSourceField = value;
			}
		}
		public EntitySource EntitySource
		{
			get
			{
				return this.entitySourceField;
			}
			set
			{
				this.entitySourceField = value;
			}
		}
		public QueryBase Query
		{
			get
			{
				return this.queryField;
			}
			set
			{
				this.queryField = value;
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
			}
		}
	}
}
