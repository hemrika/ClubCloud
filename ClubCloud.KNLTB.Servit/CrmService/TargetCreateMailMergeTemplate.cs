using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateMailMergeTemplate : TargetCreate
	{
		private mailmergetemplate mailMergeTemplateField;
		public mailmergetemplate MailMergeTemplate
		{
			get
			{
				return this.mailMergeTemplateField;
			}
			set
			{
				this.mailMergeTemplateField = value;
			}
		}
	}
}
