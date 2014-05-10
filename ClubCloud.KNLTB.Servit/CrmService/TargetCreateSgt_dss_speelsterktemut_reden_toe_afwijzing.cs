using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_dss_speelsterktemut_reden_toe_afwijzing : TargetCreate
	{
		private sgt_dss_speelsterktemut_reden_toe_afwijzing sgt_dss_speelsterktemut_reden_toe_afwijzingField;
		public sgt_dss_speelsterktemut_reden_toe_afwijzing Sgt_dss_speelsterktemut_reden_toe_afwijzing
		{
			get
			{
				return this.sgt_dss_speelsterktemut_reden_toe_afwijzingField;
			}
			set
			{
				this.sgt_dss_speelsterktemut_reden_toe_afwijzingField = value;
			}
		}
	}
}
