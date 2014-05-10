using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateDiscountTypeRequest : Request
	{
		private Guid entityIdField;
		private DiscountTypeState discountTypeStateField;
		private int discountTypeStatusField;
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
		public DiscountTypeState DiscountTypeState
		{
			get
			{
				return this.discountTypeStateField;
			}
			set
			{
				this.discountTypeStateField = value;
			}
		}
		public int DiscountTypeStatus
		{
			get
			{
				return this.discountTypeStatusField;
			}
			set
			{
				this.discountTypeStatusField = value;
			}
		}
	}
}
