using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.MetadataService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class RetrieveEntityRequest : MetadataServiceRequest
	{
		private Guid metadataIdField;
		private EntityItems entityItemsField;
		private string logicalNameField;
		private bool retrieveAsIfPublishedField;
		public Guid MetadataId
		{
			get
			{
				return this.metadataIdField;
			}
			set
			{
				this.metadataIdField = value;
			}
		}
		public EntityItems EntityItems
		{
			get
			{
				return this.entityItemsField;
			}
			set
			{
				this.entityItemsField = value;
			}
		}
		public string LogicalName
		{
			get
			{
				return this.logicalNameField;
			}
			set
			{
				this.logicalNameField = value;
			}
		}
		public bool RetrieveAsIfPublished
		{
			get
			{
				return this.retrieveAsIfPublishedField;
			}
			set
			{
				this.retrieveAsIfPublishedField = value;
			}
		}
	}
}
