using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class BackgroundSendEmailResponse : Response
	{
		private BusinessEntityCollection businessEntityCollectionField;
		private bool[] hasAttachmentsField;
		[XmlElement(Namespace = "http://schemas.microsoft.com/crm/2006/WebServices", Order = 0)]
		public BusinessEntityCollection BusinessEntityCollection
		{
			get
			{
				return this.businessEntityCollectionField;
			}
			set
			{
				this.businessEntityCollectionField = value;
				base.RaisePropertyChanged("BusinessEntityCollection");
			}
		}
		[XmlArray(Order = 1)]
		public bool[] HasAttachments
		{
			get
			{
				return this.hasAttachmentsField;
			}
			set
			{
				this.hasAttachmentsField = value;
				base.RaisePropertyChanged("HasAttachments");
			}
		}
	}
}
