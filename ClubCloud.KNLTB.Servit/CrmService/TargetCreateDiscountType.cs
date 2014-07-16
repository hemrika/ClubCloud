using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[GeneratedCode("System.Xml", "4.0.30319.33440")]
	[Serializable]
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2007/WebServices")]
	public class TargetCreateDiscountType : TargetCreate
	{
		private discounttype discountTypeField;

		[XmlElement] //[XmlElement(Order=0)]
		public discounttype DiscountType
		{
			get
			{
				return this.discountTypeField;
			}
			set
			{
				this.discountTypeField = value;
				base.RaisePropertyChanged("DiscountType");
			}
		}

		public TargetCreateDiscountType()
		{
		}
	}
}