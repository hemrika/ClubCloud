using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSw_lookuplabels : TargetCreate
	{
		private sw_lookuplabels sw_lookuplabelsField;
		public sw_lookuplabels Sw_lookuplabels
		{
			get
			{
				return this.sw_lookuplabelsField;
			}
			set
			{
				this.sw_lookuplabelsField = value;
			}
		}
	}
}
