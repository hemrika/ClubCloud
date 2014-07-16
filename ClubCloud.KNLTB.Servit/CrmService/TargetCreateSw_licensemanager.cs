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
	public class TargetCreateSw_licensemanager : TargetCreate
	{
		private sw_licensemanager sw_licensemanagerField;

		[XmlElement] //[XmlElement(Order=0)]
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

		public TargetCreateSw_licensemanager()
		{
		}
	}
}