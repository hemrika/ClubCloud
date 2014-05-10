using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_alg_nummerreeks : TargetCreate
	{
		private sgt_alg_nummerreeks sgt_alg_nummerreeksField;
		public sgt_alg_nummerreeks Sgt_alg_nummerreeks
		{
			get
			{
				return this.sgt_alg_nummerreeksField;
			}
			set
			{
				this.sgt_alg_nummerreeksField = value;
			}
		}
	}
}
