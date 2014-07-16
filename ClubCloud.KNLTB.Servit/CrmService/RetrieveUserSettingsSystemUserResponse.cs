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
	public class RetrieveUserSettingsSystemUserResponse : Response
	{
		private ClubCloud.KNLTB.ServIt.CrmService.BusinessEntity businessEntityField;

		[XmlElement(Namespace="http://schemas.microsoft.com/crm/2006/WebServices")]
		public ClubCloud.KNLTB.ServIt.CrmService.BusinessEntity BusinessEntity
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

		public RetrieveUserSettingsSystemUserResponse()
		{
		}
	}
}