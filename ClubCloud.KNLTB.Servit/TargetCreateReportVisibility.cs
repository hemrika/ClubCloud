using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateReportVisibility : TargetCreate
	{
		private reportvisibility reportVisibilityField;
		[XmlElement(Order = 0)]
		public reportvisibility ReportVisibility
		{
			get
			{
				return this.reportVisibilityField;
			}
			set
			{
				this.reportVisibilityField = value;
				base.RaisePropertyChanged("ReportVisibility");
			}
		}
	}
}
