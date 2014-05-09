using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateReport : TargetCreate
	{
		private report reportField;
		[XmlElement(Order = 0)]
		public report Report
		{
			get
			{
				return this.reportField;
			}
			set
			{
				this.reportField = value;
				base.RaisePropertyChanged("Report");
			}
		}
	}
}
