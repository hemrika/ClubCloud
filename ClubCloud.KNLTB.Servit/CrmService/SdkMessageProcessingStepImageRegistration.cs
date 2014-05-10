using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SdkMessageProcessingStepImageRegistration
	{
		private string messagePropertyNameField;
		private string[] attributesField;
		private string entityAliasField;
		private int imageTypeField;
		public string MessagePropertyName
		{
			get
			{
				return this.messagePropertyNameField;
			}
			set
			{
				this.messagePropertyNameField = value;
			}
		}
		public string[] Attributes
		{
			get
			{
				return this.attributesField;
			}
			set
			{
				this.attributesField = value;
			}
		}
		public string EntityAlias
		{
			get
			{
				return this.entityAliasField;
			}
			set
			{
				this.entityAliasField = value;
			}
		}
		public int ImageType
		{
			get
			{
				return this.imageTypeField;
			}
			set
			{
				this.imageTypeField = value;
			}
		}
	}
}
