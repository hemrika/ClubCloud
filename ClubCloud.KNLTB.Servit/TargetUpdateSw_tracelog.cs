using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSw_tracelog : TargetUpdate
	{
		private sw_tracelog sw_tracelogField;
		[XmlElement(Order = 0)]
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
	}
}
