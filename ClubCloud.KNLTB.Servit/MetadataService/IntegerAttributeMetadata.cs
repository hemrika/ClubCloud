using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.MetadataService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class IntegerAttributeMetadata : AttributeMetadata
	{
		private CrmNumber minValueField;
		private CrmNumber maxValueField;
		private CrmIntegerFormat formatField;
		public CrmNumber MinValue
		{
			get
			{
				return this.minValueField;
			}
			set
			{
				this.minValueField = value;
			}
		}
		public CrmNumber MaxValue
		{
			get
			{
				return this.maxValueField;
			}
			set
			{
				this.maxValueField = value;
			}
		}
		public CrmIntegerFormat Format
		{
			get
			{
				return this.formatField;
			}
			set
			{
				this.formatField = value;
			}
		}
	}
}
