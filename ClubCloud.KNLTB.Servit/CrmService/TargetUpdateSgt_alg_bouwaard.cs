using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_alg_bouwaard : TargetUpdate
	{
		private sgt_alg_bouwaard sgt_alg_bouwaardField;
		public sgt_alg_bouwaard Sgt_alg_bouwaard
		{
			get
			{
				return this.sgt_alg_bouwaardField;
			}
			set
			{
				this.sgt_alg_bouwaardField = value;
			}
		}
	}
}
