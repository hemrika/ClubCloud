using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.MetadataService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class MoneyAttributeMetadata : AttributeMetadata
	{
		private CrmDouble minValueField;
		private CrmDouble maxValueField;
		private CrmNumber precisionField;
		private CrmNumber precisionSourceField;
		private CrmImeMode imeModeField;
		public CrmDouble MinValue
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
		public CrmDouble MaxValue
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
		public CrmNumber PrecisionSource
		{
			get
			{
				return this.precisionSourceField;
			}
			set
			{
				this.precisionSourceField = value;
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
