using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_fac_buma_soort_apparatuur : TargetCreate
	{
		private sgt_fac_buma_soort_apparatuur sgt_fac_buma_soort_apparatuurField;
		public sgt_fac_buma_soort_apparatuur Sgt_fac_buma_soort_apparatuur
		{
			get
			{
				return this.sgt_fac_buma_soort_apparatuurField;
			}
			set
			{
				this.sgt_fac_buma_soort_apparatuurField = value;
			}
		}
	}
}
