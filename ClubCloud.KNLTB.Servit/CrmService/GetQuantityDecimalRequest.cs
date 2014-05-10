using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class GetQuantityDecimalRequest : Request
	{
		private TargetQuantify targetField;
		private Guid productIdField;
		private Guid uoMIdField;
		public TargetQuantify Target
		{
			get
			{
				return this.targetField;
			}
			set
			{
				this.targetField = value;
			}
		}
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
		public Guid UoMId
		{
			get
			{
				return this.uoMIdField;
			}
			set
			{
				this.uoMIdField = value;
			}
		}
	}
}
