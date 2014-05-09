using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class ExportCompressedAllXmlRequest : Request
	{
		private string embeddedFileNameField;
		[XmlElement(Order = 0)]
		public string EmbeddedFileName
		{
			get
			{
				return this.embeddedFileNameField;
			}
			set
			{
				this.embeddedFileNameField = value;
				base.RaisePropertyChanged("EmbeddedFileName");
			}
		}
	}
}
