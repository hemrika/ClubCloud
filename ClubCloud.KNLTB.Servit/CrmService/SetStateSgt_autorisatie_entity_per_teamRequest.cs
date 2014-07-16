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
	public class SetStateSgt_autorisatie_entity_per_teamRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_autorisatie_entity_per_teamState sgt_autorisatie_entity_per_teamStateField;

		private int sgt_autorisatie_entity_per_teamStatusField;

		[XmlElement] //[XmlElement(Order=0)]
		public Guid EntityId
		{
			get
			{
				return this.entityIdField;
			}
			set
			{
				this.entityIdField = value;
				base.RaisePropertyChanged("EntityId");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_autorisatie_entity_per_teamState Sgt_autorisatie_entity_per_teamState
		{
			get
			{
				return this.sgt_autorisatie_entity_per_teamStateField;
			}
			set
			{
				this.sgt_autorisatie_entity_per_teamStateField = value;
				base.RaisePropertyChanged("Sgt_autorisatie_entity_per_teamState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_autorisatie_entity_per_teamStatus
		{
			get
			{
				return this.sgt_autorisatie_entity_per_teamStatusField;
			}
			set
			{
				this.sgt_autorisatie_entity_per_teamStatusField = value;
				base.RaisePropertyChanged("Sgt_autorisatie_entity_per_teamStatus");
			}
		}

		public SetStateSgt_autorisatie_entity_per_teamRequest()
		{
		}
	}
}