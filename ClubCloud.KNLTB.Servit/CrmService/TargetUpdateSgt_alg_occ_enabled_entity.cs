using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_alg_occ_enabled_entity : TargetUpdate
	{
		private sgt_alg_occ_enabled_entity sgt_alg_occ_enabled_entityField;
		public sgt_alg_occ_enabled_entity Sgt_alg_occ_enabled_entity
		{
			get
			{
				return this.sgt_alg_occ_enabled_entityField;
			}
			set
			{
				this.sgt_alg_occ_enabled_entityField = value;
			}
		}
	}
}
