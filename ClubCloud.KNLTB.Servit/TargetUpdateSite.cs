using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSite : TargetUpdate
	{
		private site siteField;
		[XmlElement(Order = 0)]
		public site Site
		{
			get
			{
				return this.siteField;
			}
			set
			{
				this.siteField = value;
				base.RaisePropertyChanged("Site");
			}
		}
	}
}
