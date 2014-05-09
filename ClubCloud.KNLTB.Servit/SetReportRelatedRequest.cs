using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetReportRelatedRequest : Request
	{
		private Guid reportIdField;
		private int[] entitiesField;
		private int[] categoriesField;
		private int[] visibilityField;
		[XmlElement(Order = 0)]
		public Guid ReportId
		{
			get
			{
				return this.reportIdField;
			}
			set
			{
				this.reportIdField = value;
				base.RaisePropertyChanged("ReportId");
			}
		}
		[XmlArray(Order = 1)]
		public int[] Entities
		{
			get
			{
				return this.entitiesField;
			}
			set
			{
				this.entitiesField = value;
				base.RaisePropertyChanged("Entities");
			}
		}
		[XmlArray(Order = 2)]
		public int[] Categories
		{
			get
			{
				return this.categoriesField;
			}
			set
			{
				this.categoriesField = value;
				base.RaisePropertyChanged("Categories");
			}
		}
		[XmlArray(Order = 3)]
		public int[] Visibility
		{
			get
			{
				return this.visibilityField;
			}
			set
			{
				this.visibilityField = value;
				base.RaisePropertyChanged("Visibility");
			}
		}
	}
}
