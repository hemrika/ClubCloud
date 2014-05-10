using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSw_lookuptemplate : TargetUpdate
	{
		private sw_lookuptemplate sw_lookuptemplateField;
		public sw_lookuptemplate Sw_lookuptemplate
		{
			get
			{
				return this.sw_lookuptemplateField;
			}
			set
			{
				this.sw_lookuptemplateField = value;
			}
		}
	}
}
