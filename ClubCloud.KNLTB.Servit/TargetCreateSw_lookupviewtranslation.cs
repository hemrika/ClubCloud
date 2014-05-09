using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSw_lookupviewtranslation : TargetCreate
	{
		private sw_lookupviewtranslation sw_lookupviewtranslationField;
		[XmlElement(Order = 0)]
		public sw_lookupviewtranslation Sw_lookupviewtranslation
		{
			get
			{
				return this.sw_lookupviewtranslationField;
			}
			set
			{
				this.sw_lookupviewtranslationField = value;
				base.RaisePropertyChanged("Sw_lookupviewtranslation");
			}
		}
	}
}
