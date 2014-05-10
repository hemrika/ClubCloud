using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSw_lookupviewtranslation : TargetUpdate
	{
		private sw_lookupviewtranslation sw_lookupviewtranslationField;
		public sw_lookupviewtranslation Sw_lookupviewtranslation
		{
			get
			{
				return this.sw_lookupviewtranslationField;
			}
			set
			{
				this.sw_lookupviewtranslationField = value;
			}
		}
	}
}
