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
	public class GetQuantityDecimalResponse : Response
	{
		private int quantityField;

		[XmlElement] //[XmlElement(Order=0)]
		public int Quantity
		{
			get
			{
				return this.quantityField;
			}
			set
			{
				this.quantityField = value;
				base.RaisePropertyChanged("Quantity");
			}
		}

		public GetQuantityDecimalResponse()
		{
		}
	}
}