using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_alg_leveringsconditie : TargetUpdate
	{
		private sgt_alg_leveringsconditie sgt_alg_leveringsconditieField;
		public sgt_alg_leveringsconditie Sgt_alg_leveringsconditie
		{
			get
			{
				return this.sgt_alg_leveringsconditieField;
			}
			set
			{
				this.sgt_alg_leveringsconditieField = value;
			}
		}
	}
}
