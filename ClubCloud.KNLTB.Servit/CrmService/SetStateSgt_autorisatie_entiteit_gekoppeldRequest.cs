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
	public class SetStateSgt_autorisatie_entiteit_gekoppeldRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_autorisatie_entiteit_gekoppeldState sgt_autorisatie_entiteit_gekoppeldStateField;

		private int sgt_autorisatie_entiteit_gekoppeldStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_autorisatie_entiteit_gekoppeldState Sgt_autorisatie_entiteit_gekoppeldState
		{
			get
			{
				return this.sgt_autorisatie_entiteit_gekoppeldStateField;
			}
			set
			{
				this.sgt_autorisatie_entiteit_gekoppeldStateField = value;
				base.RaisePropertyChanged("Sgt_autorisatie_entiteit_gekoppeldState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_autorisatie_entiteit_gekoppeldStatus
		{
			get
			{
				return this.sgt_autorisatie_entiteit_gekoppeldStatusField;
			}
			set
			{
				this.sgt_autorisatie_entiteit_gekoppeldStatusField = value;
				base.RaisePropertyChanged("Sgt_autorisatie_entiteit_gekoppeldStatus");
			}
		}

		public SetStateSgt_autorisatie_entiteit_gekoppeldRequest()
		{
		}
	}
}