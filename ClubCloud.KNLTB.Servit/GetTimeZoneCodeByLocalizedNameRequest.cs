using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class GetTimeZoneCodeByLocalizedNameRequest : Request
	{
		private string localizedStandardNameField;
		private int localeIdField;
		[XmlElement(Order = 0)]
		public string LocalizedStandardName
		{
			get
			{
				return this.localizedStandardNameField;
			}
			set
			{
				this.localizedStandardNameField = value;
				base.RaisePropertyChanged("LocalizedStandardName");
			}
		}
		[XmlElement(Order = 1)]
		public int LocaleId
		{
			get
			{
				return this.localeIdField;
			}
			set
			{
				this.localeIdField = value;
				base.RaisePropertyChanged("LocaleId");
			}
		}
	}
}
