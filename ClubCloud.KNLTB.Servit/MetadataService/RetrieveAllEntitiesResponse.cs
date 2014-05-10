using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.MetadataService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class RetrieveAllEntitiesResponse : MetadataServiceResponse
	{
		private CrmMetadata[] crmMetadataField;
		private string timestampField;
		public CrmMetadata[] CrmMetadata
		{
			get
			{
				return this.crmMetadataField;
			}
			set
			{
				this.crmMetadataField = value;
			}
		}
		public string Timestamp
		{
			get
			{
				return this.timestampField;
			}
			set
			{
				this.timestampField = value;
			}
		}
	}
}
