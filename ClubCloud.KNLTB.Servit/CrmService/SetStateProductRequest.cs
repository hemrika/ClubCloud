using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateProductRequest : Request
	{
		private Guid entityIdField;
		private ProductState productStateField;
		private int productStatusField;
		public Guid EntityId
		{
			get
			{
				return this.entityIdField;
			}
			set
			{
				this.entityIdField = value;
			}
		}
		public ProductState ProductState
		{
			get
			{
				return this.productStateField;
			}
			set
			{
				this.productStateField = value;
			}
		}
		public int ProductStatus
		{
			get
			{
				return this.productStatusField;
			}
			set
			{
				this.productStatusField = value;
			}
		}
	}
}
