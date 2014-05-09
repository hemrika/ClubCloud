using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateReportEntity : TargetUpdate
	{
		private reportentity reportEntityField;
		[XmlElement(Order = 0)]
		public reportentity ReportEntity
		{
			get
			{
				return this.reportEntityField;
			}
			set
			{
				this.reportEntityField = value;
				base.RaisePropertyChanged("ReportEntity");
			}
		}
	}
}
