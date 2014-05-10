using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_alg_ledenpas_vereniging : TargetUpdate
	{
		private sgt_alg_ledenpas_vereniging sgt_alg_ledenpas_verenigingField;
		public sgt_alg_ledenpas_vereniging Sgt_alg_ledenpas_vereniging
		{
			get
			{
				return this.sgt_alg_ledenpas_verenigingField;
			}
			set
			{
				this.sgt_alg_ledenpas_verenigingField = value;
			}
		}
	}
}
