using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class PublishDuplicateRuleResponse : Response
	{
		private Guid jobIdField;
		[XmlElement(Order = 0)]
		public Guid JobId
		{
			get
			{
				return this.jobIdField;
			}
			set
			{
				this.jobIdField = value;
				base.RaisePropertyChanged("JobId");
			}
		}
	}
}
