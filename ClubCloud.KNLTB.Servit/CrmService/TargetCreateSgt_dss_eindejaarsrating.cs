using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_dss_eindejaarsrating : TargetCreate
	{
		private sgt_dss_eindejaarsrating sgt_dss_eindejaarsratingField;
		public sgt_dss_eindejaarsrating Sgt_dss_eindejaarsrating
		{
			get
			{
				return this.sgt_dss_eindejaarsratingField;
			}
			set
			{
				this.sgt_dss_eindejaarsratingField = value;
			}
		}
	}
}
