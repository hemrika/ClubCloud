using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_alg_activiteitenplan : TargetUpdate
	{
		private sgt_alg_activiteitenplan sgt_alg_activiteitenplanField;
		public sgt_alg_activiteitenplan Sgt_alg_activiteitenplan
		{
			get
			{
				return this.sgt_alg_activiteitenplanField;
			}
			set
			{
				this.sgt_alg_activiteitenplanField = value;
			}
		}
	}
}
