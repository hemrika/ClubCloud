using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.MetadataService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class UpdateEntityRequest : MetadataServiceRequest
	{
		private EntityMetadata entityField;
		private bool mergeLabelsField;
		public EntityMetadata Entity
		{
			get
			{
				return this.entityField;
			}
			set
			{
				this.entityField = value;
			}
		}
		public bool MergeLabels
		{
			get
			{
				return this.mergeLabelsField;
			}
			set
			{
				this.mergeLabelsField = value;
			}
		}
	}
}
