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
	public class TargetCreateReportCategory : TargetCreate
	{
		private reportcategory reportCategoryField;

		[XmlElement] //[XmlElement(Order=0)]
		public reportcategory ReportCategory
		{
			get
			{
				return this.reportCategoryField;
			}
			set
			{
				this.reportCategoryField = value;
				base.RaisePropertyChanged("ReportCategory");
			}
		}

		public TargetCreateReportCategory()
		{
		}
	}
}