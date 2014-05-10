using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class CopyCampaignRequest : Request
	{
		private Guid baseCampaignField;
		private bool saveAsTemplateField;
		public Guid BaseCampaign
		{
			get
			{
				return this.baseCampaignField;
			}
			set
			{
				this.baseCampaignField = value;
			}
		}
		public bool SaveAsTemplate
		{
			get
			{
				return this.saveAsTemplateField;
			}
			set
			{
				this.saveAsTemplateField = value;
			}
		}
	}
}
