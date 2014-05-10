using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class ValidateResponse : Response
	{
		private ValidationResult[] resultField;
		public ValidationResult[] Result
		{
			get
			{
				return this.resultField;
			}
			set
			{
				this.resultField = value;
			}
		}
	}
}
