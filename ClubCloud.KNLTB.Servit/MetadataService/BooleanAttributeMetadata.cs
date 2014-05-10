using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.MetadataService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class BooleanAttributeMetadata : AttributeMetadata
	{
		private Option trueOptionField;
		private Option falseOptionField;
		public Option TrueOption
		{
			get
			{
				return this.trueOptionField;
			}
			set
			{
				this.trueOptionField = value;
			}
		}
		public Option FalseOption
		{
			get
			{
				return this.falseOptionField;
			}
			set
			{
				this.falseOptionField = value;
			}
		}
	}
}
