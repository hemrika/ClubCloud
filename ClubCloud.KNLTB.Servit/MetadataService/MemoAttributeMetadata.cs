using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.MetadataService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class MemoAttributeMetadata : AttributeMetadata
	{
		private CrmStringFormat formatField;
		private CrmNumber maxLengthField;
		private CrmImeMode imeModeField;
		public CrmStringFormat Format
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
		public CrmNumber MaxLength
		{
			get
			{
				return this.maxLengthField;
			}
			set
			{
				this.maxLengthField = value;
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
