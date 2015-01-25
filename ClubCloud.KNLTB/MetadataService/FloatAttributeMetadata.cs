using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.MetadataService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class FloatAttributeMetadata : AttributeMetadata
	{
		private CrmFloat minValueField;
		private CrmFloat maxValueField;
		private CrmNumber precisionField;
		private CrmImeMode imeModeField;
		public CrmFloat MinValue
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
		public CrmFloat MaxValue
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
		public CrmNumber Precision
		{
			get
			{
				return this.precisionField;
			}
			set
			{
				this.precisionField = value;
			}
		}
		public CrmImeMode ImeMode
		{
			get
			{
				return this.imeModeField;
			}
			set
			{
				this.imeModeField = value;
			}
		}
	}
}
