using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_alg_telmethode : TargetCreate
	{
		private sgt_alg_telmethode sgt_alg_telmethodeField;
		public sgt_alg_telmethode Sgt_alg_telmethode
		{
			get
			{
				return this.sgt_alg_telmethodeField;
			}
			set
			{
				this.sgt_alg_telmethodeField = value;
			}
		}
	}
}
