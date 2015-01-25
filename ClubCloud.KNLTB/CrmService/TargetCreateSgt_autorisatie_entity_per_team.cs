using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[GeneratedCode("System.Xml", "4.0.30319.33440")]
	[Serializable]
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2007/WebServices")]
	public class TargetCreateSgt_autorisatie_entity_per_team : TargetCreate
	{
		private sgt_autorisatie_entity_per_team sgt_autorisatie_entity_per_teamField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_autorisatie_entity_per_team Sgt_autorisatie_entity_per_team
		{
			get
			{
				return this.sgt_autorisatie_entity_per_teamField;
			}
			set
			{
				this.sgt_autorisatie_entity_per_teamField = value;
				base.RaisePropertyChanged("Sgt_autorisatie_entity_per_team");
			}
		}

		public TargetCreateSgt_autorisatie_entity_per_team()
		{
		}
	}
}