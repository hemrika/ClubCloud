using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_alg_pastype : TargetUpdate
	{
		private sgt_alg_pastype sgt_alg_pastypeField;
		public sgt_alg_pastype Sgt_alg_pastype
		{
			get
			{
				return this.sgt_alg_pastypeField;
			}
			set
			{
				this.sgt_alg_pastypeField = value;
			}
		}
	}
}
