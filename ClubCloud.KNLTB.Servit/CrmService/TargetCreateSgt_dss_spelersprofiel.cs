using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_dss_spelersprofiel : TargetCreate
	{
		private sgt_dss_spelersprofiel sgt_dss_spelersprofielField;
		public sgt_dss_spelersprofiel Sgt_dss_spelersprofiel
		{
			get
			{
				return this.sgt_dss_spelersprofielField;
			}
			set
			{
				this.sgt_dss_spelersprofielField = value;
			}
		}
	}
}
