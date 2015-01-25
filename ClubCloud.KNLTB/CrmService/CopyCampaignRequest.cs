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
	public class CopyCampaignRequest : Request
	{
		private Guid baseCampaignField;

		private bool saveAsTemplateField;

		[XmlElement] //[XmlElement(Order=0)]
		public Guid BaseCampaign
		{
			get
			{
				return this.baseCampaignField;
			}
			set
			{
				this.baseCampaignField = value;
				base.RaisePropertyChanged("BaseCampaign");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public bool SaveAsTemplate
		{
			get
			{
				return this.saveAsTemplateField;
			}
			set
			{
				this.saveAsTemplateField = value;
				base.RaisePropertyChanged("SaveAsTemplate");
			}
		}

		public CopyCampaignRequest()
		{
		}
	}
}