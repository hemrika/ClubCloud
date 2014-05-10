using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_alg_district : TargetCreate
	{
		private sgt_alg_district sgt_alg_districtField;
		public sgt_alg_district Sgt_alg_district
		{
			get
			{
				return this.sgt_alg_districtField;
			}
			set
			{
				this.sgt_alg_districtField = value;
			}
		}
	}
}
