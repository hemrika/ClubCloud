using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.MetadataService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class CreateEntityRequest : MetadataServiceRequest
	{
		private EntityMetadata entityField;
		private StringAttributeMetadata primaryAttributeField;
		private bool hasNotesField;
		private bool hasActivitiesField;
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
		public StringAttributeMetadata PrimaryAttribute
		{
			get
			{
				return this.primaryAttributeField;
			}
			set
			{
				this.primaryAttributeField = value;
			}
		}
		public bool HasNotes
		{
			get
			{
				return this.hasNotesField;
			}
			set
			{
				this.hasNotesField = value;
			}
		}
		public bool HasActivities
		{
			get
			{
				return this.hasActivitiesField;
			}
			set
			{
				this.hasActivitiesField = value;
			}
		}
	}
}
