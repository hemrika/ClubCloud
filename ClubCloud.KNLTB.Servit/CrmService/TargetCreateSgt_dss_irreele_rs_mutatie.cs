using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_dss_irreele_rs_mutatie : TargetCreate
	{
		private sgt_dss_irreele_rs_mutatie sgt_dss_irreele_rs_mutatieField;
		public sgt_dss_irreele_rs_mutatie Sgt_dss_irreele_rs_mutatie
		{
			get
			{
				return this.sgt_dss_irreele_rs_mutatieField;
			}
			set
			{
				this.sgt_dss_irreele_rs_mutatieField = value;
			}
		}
	}
}
