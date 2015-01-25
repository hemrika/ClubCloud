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
	public class SetStateSgt_autorisatie_padenRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_autorisatie_padenState sgt_autorisatie_padenStateField;

		private int sgt_autorisatie_padenStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_autorisatie_padenState Sgt_autorisatie_padenState
		{
			get
			{
				return this.sgt_autorisatie_padenStateField;
			}
			set
			{
				this.sgt_autorisatie_padenStateField = value;
				base.RaisePropertyChanged("Sgt_autorisatie_padenState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_autorisatie_padenStatus
		{
			get
			{
				return this.sgt_autorisatie_padenStatusField;
			}
			set
			{
				this.sgt_autorisatie_padenStatusField = value;
				base.RaisePropertyChanged("Sgt_autorisatie_padenStatus");
			}
		}

		public SetStateSgt_autorisatie_padenRequest()
		{
		}
	}
}