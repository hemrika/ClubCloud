using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_autorisatie_entity_per_team : TargetUpdate
	{
		private sgt_autorisatie_entity_per_team sgt_autorisatie_entity_per_teamField;
		public sgt_autorisatie_entity_per_team Sgt_autorisatie_entity_per_team
		{
			get
			{
				return this.sgt_autorisatie_entity_per_teamField;
			}
			set
			{
				this.sgt_autorisatie_entity_per_teamField = value;
			}
		}
	}
}
