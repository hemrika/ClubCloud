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
	public class TargetUpdateSw_tracelog : TargetUpdate
	{
		private sw_tracelog sw_tracelogField;

		[XmlElement] //[XmlElement(Order=0)]
		public sw_tracelog Sw_tracelog
		{
			get
			{
				return this.sw_tracelogField;
			}
			set
			{
				this.sw_tracelogField = value;
				base.RaisePropertyChanged("Sw_tracelog");
			}
		}

		public TargetUpdateSw_tracelog()
		{
		}
	}
}