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
	public class TargetCreateSw_retrievequery : TargetCreate
	{
		private sw_retrievequery sw_retrievequeryField;

		[XmlElement] //[XmlElement(Order=0)]
		public sw_retrievequery Sw_retrievequery
		{
			get
			{
				return this.sw_retrievequeryField;
			}
			set
			{
				this.sw_retrievequeryField = value;
				base.RaisePropertyChanged("Sw_retrievequery");
			}
		}

		public TargetCreateSw_retrievequery()
		{
		}
	}
}