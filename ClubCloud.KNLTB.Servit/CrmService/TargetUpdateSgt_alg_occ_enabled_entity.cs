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
	public class TargetUpdateSgt_alg_occ_enabled_entity : TargetUpdate
	{
		private sgt_alg_occ_enabled_entity sgt_alg_occ_enabled_entityField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_alg_occ_enabled_entity Sgt_alg_occ_enabled_entity
		{
			get
			{
				return this.sgt_alg_occ_enabled_entityField;
			}
			set
			{
				this.sgt_alg_occ_enabled_entityField = value;
				base.RaisePropertyChanged("Sgt_alg_occ_enabled_entity");
			}
		}

		public TargetUpdateSgt_alg_occ_enabled_entity()
		{
		}
	}
}