using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.MetadataService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class InsertOptionValueResponse : MetadataServiceResponse
	{
		private int newOptionValueField;
		public int NewOptionValue
		{
			get
			{
				return this.newOptionValueField;
			}
			set
			{
				this.newOptionValueField = value;
			}
		}
	}
}