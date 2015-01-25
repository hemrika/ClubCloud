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
	public class SetStateProductRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.ProductState productStateField;

		private int productStatusField;

		[XmlElement] //[XmlElement(Order=0)]
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

		[XmlElement] //[XmlElement(Order=1)]
		public ClubCloud.KNLTB.ServIt.CrmService.ProductState ProductState
		{
			get
			{
				return this.productStateField;
			}
			set
			{
				this.productStateField = value;
				base.RaisePropertyChanged("ProductState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int ProductStatus
		{
			get
			{
				return this.productStatusField;
			}
			set
			{
				this.productStatusField = value;
				base.RaisePropertyChanged("ProductStatus");
			}
		}

		public SetStateProductRequest()
		{
		}
	}
}