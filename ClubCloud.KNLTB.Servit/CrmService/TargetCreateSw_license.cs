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
	public class TargetCreateSw_license : TargetCreate
	{
		private sw_license sw_licenseField;

		[XmlElement] //[XmlElement(Order=0)]
		public sw_license Sw_license
		{
			get
			{
				return this.sw_licenseField;
			}
			set
			{
				this.sw_licenseField = value;
				base.RaisePropertyChanged("Sw_license");
			}
		}

		public TargetCreateSw_license()
		{
		}
	}
}