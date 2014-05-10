using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.MetadataService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class RetrieveRelationshipRequest : MetadataServiceRequest
	{
		private Guid metadataIdField;
		private string nameField;
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
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
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
