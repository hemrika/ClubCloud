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
	public class RemoveSubstituteProductRequest : Request
	{
		private Guid productIdField;

		private Guid substituteIdField;

		[XmlElement] //[XmlElement(Order=0)]
		public Guid ProductId
		{
			get
			{
				return this.productIdField;
			}
			set
			{
				this.productIdField = value;
				base.RaisePropertyChanged("ProductId");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public Guid SubstituteId
		{
			get
			{
				return this.substituteIdField;
			}
			set
			{
				this.substituteIdField = value;
				base.RaisePropertyChanged("SubstituteId");
			}
		}

		public RemoveSubstituteProductRequest()
		{
		}
	}
}