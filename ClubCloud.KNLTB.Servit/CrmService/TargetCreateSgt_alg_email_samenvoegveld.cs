using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_alg_email_samenvoegveld : TargetCreate
	{
		private sgt_alg_email_samenvoegveld sgt_alg_email_samenvoegveldField;
		public sgt_alg_email_samenvoegveld Sgt_alg_email_samenvoegveld
		{
			get
			{
				return this.sgt_alg_email_samenvoegveldField;
			}
			set
			{
				this.sgt_alg_email_samenvoegveldField = value;
			}
		}
	}
}
