using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class ReviseQuoteResponse : Response
	{
		private BusinessEntity businessEntityField;
		[XmlElement(Namespace = "http://schemas.microsoft.com/crm/2006/WebServices", Order = 0)]
		public BusinessEntity BusinessEntity
		{
			get
			{
				return this.businessEntityField;
			}
			set
			{
				this.businessEntityField = value;
				base.RaisePropertyChanged("BusinessEntity");
			}
		}
	}
}
