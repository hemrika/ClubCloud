using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_alg_custom_config : TargetUpdate
	{
		private sgt_alg_custom_config sgt_alg_custom_configField;
		public sgt_alg_custom_config Sgt_alg_custom_config
		{
			get
			{
				return this.sgt_alg_custom_configField;
			}
			set
			{
				this.sgt_alg_custom_configField = value;
			}
		}
	}
}