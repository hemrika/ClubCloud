using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_arb_sps_straf : TargetCreate
	{
		private sgt_arb_sps_straf sgt_arb_sps_strafField;
		public sgt_arb_sps_straf Sgt_arb_sps_straf
		{
			get
			{
				return this.sgt_arb_sps_strafField;
			}
			set
			{
				this.sgt_arb_sps_strafField = value;
			}
		}
	}
}
