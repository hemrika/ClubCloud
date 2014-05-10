using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class GetAllTimeZonesWithDisplayNameResponse : Response
	{
		private BusinessEntityCollection businessEntityCollectionField;
		[XmlElement(Namespace = "http://schemas.microsoft.com/crm/2006/WebServices")]
		public BusinessEntityCollection BusinessEntityCollection
		{
			get
			{
				return this.businessEntityCollectionField;
			}
			set
			{
				this.businessEntityCollectionField = value;
			}
		}
	}
}
