using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_alg_baantype : TargetUpdate
	{
		private sgt_alg_baantype sgt_alg_baantypeField;
		public sgt_alg_baantype Sgt_alg_baantype
		{
			get
			{
				return this.sgt_alg_baantypeField;
			}
			set
			{
				this.sgt_alg_baantypeField = value;
			}
		}
	}
}
