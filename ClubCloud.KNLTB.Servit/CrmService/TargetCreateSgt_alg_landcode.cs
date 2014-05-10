using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_alg_landcode : TargetCreate
	{
		private sgt_alg_landcode sgt_alg_landcodeField;
		public sgt_alg_landcode Sgt_alg_landcode
		{
			get
			{
				return this.sgt_alg_landcodeField;
			}
			set
			{
				this.sgt_alg_landcodeField = value;
			}
		}
	}
}
