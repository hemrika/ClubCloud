using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSw_tracelog : TargetCreate
	{
		private sw_tracelog sw_tracelogField;
		public sw_tracelog Sw_tracelog
		{
			get
			{
				return this.sw_tracelogField;
			}
			set
			{
				this.sw_tracelogField = value;
			}
		}
	}
}