using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSw_licensemanager : TargetUpdate
	{
		private sw_licensemanager sw_licensemanagerField;
		[XmlElement(Order = 0)]
		public sw_licensemanager Sw_licensemanager
		{
			get
			{
				return this.sw_licensemanagerField;
			}
			set
			{
				this.sw_licensemanagerField = value;
				base.RaisePropertyChanged("Sw_licensemanager");
			}
		}
	}
}
