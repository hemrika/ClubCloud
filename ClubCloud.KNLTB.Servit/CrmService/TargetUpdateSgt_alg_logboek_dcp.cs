using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_alg_logboek_dcp : TargetUpdate
	{
		private sgt_alg_logboek_dcp sgt_alg_logboek_dcpField;
		public sgt_alg_logboek_dcp Sgt_alg_logboek_dcp
		{
			get
			{
				return this.sgt_alg_logboek_dcpField;
			}
			set
			{
				this.sgt_alg_logboek_dcpField = value;
			}
		}
	}
}
