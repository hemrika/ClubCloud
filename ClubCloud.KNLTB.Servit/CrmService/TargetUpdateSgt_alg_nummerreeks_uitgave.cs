using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_alg_nummerreeks_uitgave : TargetUpdate
	{
		private sgt_alg_nummerreeks_uitgave sgt_alg_nummerreeks_uitgaveField;
		public sgt_alg_nummerreeks_uitgave Sgt_alg_nummerreeks_uitgave
		{
			get
			{
				return this.sgt_alg_nummerreeks_uitgaveField;
			}
			set
			{
				this.sgt_alg_nummerreeks_uitgaveField = value;
			}
		}
	}
}
