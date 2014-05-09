using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SendEmailFromTemplateRequest : Request
	{
		private Guid templateIdField;
		private string regardingTypeField;
		private Guid regardingIdField;
		private TargetSendFromTemplate targetField;
		[XmlElement(Order = 0)]
		public Guid TemplateId
		{
			get
			{
				return this.templateIdField;
			}
			set
			{
				this.templateIdField = value;
				base.RaisePropertyChanged("TemplateId");
			}
		}
		[XmlElement(Order = 1)]
		public string RegardingType
		{
			get
			{
				return this.regardingTypeField;
			}
			set
			{
				this.regardingTypeField = value;
				base.RaisePropertyChanged("RegardingType");
			}
		}
		[XmlElement(Order = 2)]
		public Guid RegardingId
		{
			get
			{
				return this.regardingIdField;
			}
			set
			{
				this.regardingIdField = value;
				base.RaisePropertyChanged("RegardingId");
			}
		}
		[XmlElement(Order = 3)]
		public TargetSendFromTemplate Target
		{
			get
			{
				return this.targetField;
			}
			set
			{
				this.targetField = value;
				base.RaisePropertyChanged("Target");
			}
		}
	}
}
