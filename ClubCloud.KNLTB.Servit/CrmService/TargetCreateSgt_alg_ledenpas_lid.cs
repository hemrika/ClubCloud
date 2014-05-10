using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_alg_ledenpas_lid : TargetCreate
	{
		private sgt_alg_ledenpas_lid sgt_alg_ledenpas_lidField;
		public sgt_alg_ledenpas_lid Sgt_alg_ledenpas_lid
		{
			get
			{
				return this.sgt_alg_ledenpas_lidField;
			}
			set
			{
				this.sgt_alg_ledenpas_lidField = value;
			}
		}
	}
}
