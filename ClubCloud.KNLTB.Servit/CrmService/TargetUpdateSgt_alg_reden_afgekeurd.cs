using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_alg_reden_afgekeurd : TargetUpdate
	{
		private sgt_alg_reden_afgekeurd sgt_alg_reden_afgekeurdField;
		public sgt_alg_reden_afgekeurd Sgt_alg_reden_afgekeurd
		{
			get
			{
				return this.sgt_alg_reden_afgekeurdField;
			}
			set
			{
				this.sgt_alg_reden_afgekeurdField = value;
			}
		}
	}
}
