using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateImportJob : TargetUpdate
	{
		private importjob importJobField;
		[XmlElement(Order = 0)]
		public importjob ImportJob
		{
			get
			{
				return this.importJobField;
			}
			set
			{
				this.importJobField = value;
				base.RaisePropertyChanged("ImportJob");
			}
		}
	}
}
