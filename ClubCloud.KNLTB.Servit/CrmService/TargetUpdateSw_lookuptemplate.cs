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
	public class TargetUpdateSw_lookuptemplate : TargetUpdate
	{
		private sw_lookuptemplate sw_lookuptemplateField;

		[XmlElement] //[XmlElement(Order=0)]
		public sw_lookuptemplate Sw_lookuptemplate
		{
			get
			{
				return this.sw_lookuptemplateField;
			}
			set
			{
				this.sw_lookuptemplateField = value;
				base.RaisePropertyChanged("Sw_lookuptemplate");
			}
		}

		public TargetUpdateSw_lookuptemplate()
		{
		}
	}
}