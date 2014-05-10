using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class RemoveSubstituteProductRequest : Request
	{
		private Guid productIdField;
		private Guid substituteIdField;
		public Guid ProductId
		{
			get
			{
				return this.productIdField;
			}
			set
			{
				this.productIdField = value;
			}
		}
		public Guid SubstituteId
		{
			get
			{
				return this.substituteIdField;
			}
			set
			{
				this.substituteIdField = value;
			}
		}
	}
}
