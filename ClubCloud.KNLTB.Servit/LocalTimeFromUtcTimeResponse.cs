using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class LocalTimeFromUtcTimeResponse : Response
	{
		private CrmDateTime localTimeField;
		[XmlElement(Order = 0)]
		public CrmDateTime LocalTime
		{
			get
			{
				return this.localTimeField;
			}
			set
			{
				this.localTimeField = value;
				base.RaisePropertyChanged("LocalTime");
			}
		}
	}
}
