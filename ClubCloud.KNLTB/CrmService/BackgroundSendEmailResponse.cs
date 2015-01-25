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
	public class BackgroundSendEmailResponse : Response
	{
		private ClubCloud.KNLTB.ServIt.CrmService.BusinessEntityCollection businessEntityCollectionField;

		private bool[] hasAttachmentsField;

		[XmlElement(Namespace="http://schemas.microsoft.com/crm/2006/WebServices")]
		public ClubCloud.KNLTB.ServIt.CrmService.BusinessEntityCollection BusinessEntityCollection
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

		[XmlArray] //[XmlArray(Order=1)]
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

		public BackgroundSendEmailResponse()
		{
		}
	}
}