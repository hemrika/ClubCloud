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
	public class TargetCreateSw_lookupdefinition : TargetCreate
	{
		private sw_lookupdefinition sw_lookupdefinitionField;

		[XmlElement] //[XmlElement(Order=0)]
		public sw_lookupdefinition Sw_lookupdefinition
		{
			get
			{
				return this.sw_lookupdefinitionField;
			}
			set
			{
				this.sw_lookupdefinitionField = value;
				base.RaisePropertyChanged("Sw_lookupdefinition");
			}
		}

		public TargetCreateSw_lookupdefinition()
		{
		}
	}
}