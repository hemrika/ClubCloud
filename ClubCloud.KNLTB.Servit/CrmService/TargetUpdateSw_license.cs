using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSw_license : TargetUpdate
	{
		private sw_license sw_licenseField;
		public sw_license Sw_license
		{
			get
			{
				return this.sw_licenseField;
			}
			set
			{
				this.sw_licenseField = value;
			}
		}
	}
}
