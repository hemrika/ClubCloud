using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_alg_lookupcontrol_filter : TargetCreate
	{
		private sgt_alg_lookupcontrol_filter sgt_alg_lookupcontrol_filterField;
		public sgt_alg_lookupcontrol_filter Sgt_alg_lookupcontrol_filter
		{
			get
			{
				return this.sgt_alg_lookupcontrol_filterField;
			}
			set
			{
				this.sgt_alg_lookupcontrol_filterField = value;
			}
		}
	}
}
