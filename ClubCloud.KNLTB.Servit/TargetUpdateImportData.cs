using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateImportData : TargetUpdate
	{
		private importdata importDataField;
		[XmlElement(Order = 0)]
		public importdata ImportData
		{
			get
			{
				return this.importDataField;
			}
			set
			{
				this.importDataField = value;
				base.RaisePropertyChanged("ImportData");
			}
		}
	}
}
