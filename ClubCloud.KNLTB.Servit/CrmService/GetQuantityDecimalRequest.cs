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
	public class GetQuantityDecimalRequest : Request
	{
		private TargetQuantify targetField;

		private Guid productIdField;

		private Guid uoMIdField;

		[XmlElement] //[XmlElement(Order=1)]
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

		[XmlElement] //[XmlElement(Order=0)]
		public TargetQuantify Target
		{
			get
			{
				return this.targetField;
			}
			set
			{
				this.targetField = value;
				base.RaisePropertyChanged("Target");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public Guid UoMId
		{
			get
			{
				return this.uoMIdField;
			}
			set
			{
				this.uoMIdField = value;
				base.RaisePropertyChanged("UoMId");
			}
		}

		public GetQuantityDecimalRequest()
		{
		}
	}
}