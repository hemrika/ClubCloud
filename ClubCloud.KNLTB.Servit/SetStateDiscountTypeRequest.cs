using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateDiscountTypeRequest : Request
	{
		private Guid entityIdField;
		private DiscountTypeState discountTypeStateField;
		private int discountTypeStatusField;
		[XmlElement(Order = 0)]
		public Guid EntityId
		{
			get
			{
				return this.entityIdField;
			}
			set
			{
				this.entityIdField = value;
				base.RaisePropertyChanged("EntityId");
			}
		}
		[XmlElement(Order = 1)]
		public DiscountTypeState DiscountTypeState
		{
			get
			{
				return this.discountTypeStateField;
			}
			set
			{
				this.discountTypeStateField = value;
				base.RaisePropertyChanged("DiscountTypeState");
			}
		}
		[XmlElement(Order = 2)]
		public int DiscountTypeStatus
		{
			get
			{
				return this.discountTypeStatusField;
			}
			set
			{
				this.discountTypeStatusField = value;
				base.RaisePropertyChanged("DiscountTypeStatus");
			}
		}
	}
}
