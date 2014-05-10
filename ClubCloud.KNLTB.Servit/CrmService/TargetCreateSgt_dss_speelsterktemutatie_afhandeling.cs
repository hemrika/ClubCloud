using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_dss_speelsterktemutatie_afhandeling : TargetCreate
	{
		private sgt_dss_speelsterktemutatie_afhandeling sgt_dss_speelsterktemutatie_afhandelingField;
		public sgt_dss_speelsterktemutatie_afhandeling Sgt_dss_speelsterktemutatie_afhandeling
		{
			get
			{
				return this.sgt_dss_speelsterktemutatie_afhandelingField;
			}
			set
			{
				this.sgt_dss_speelsterktemutatie_afhandelingField = value;
			}
		}
	}
}
