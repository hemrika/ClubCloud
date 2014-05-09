using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetRelatedProductToLead : TargetRelated
	{
		private Guid productIdField;
		private Guid leadIdField;
		[XmlElement(Order = 0)]
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
		[XmlElement(Order = 1)]
		public Guid LeadId
		{
			get
			{
				return this.leadIdField;
			}
			set
			{
				this.leadIdField = value;
				base.RaisePropertyChanged("LeadId");
			}
		}
	}
}
