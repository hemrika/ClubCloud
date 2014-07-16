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
	public class SetStateSgt_com_ploeginschrijving_afhandelingRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_com_ploeginschrijving_afhandelingState sgt_com_ploeginschrijving_afhandelingStateField;

		private int sgt_com_ploeginschrijving_afhandelingStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_com_ploeginschrijving_afhandelingState Sgt_com_ploeginschrijving_afhandelingState
		{
			get
			{
				return this.sgt_com_ploeginschrijving_afhandelingStateField;
			}
			set
			{
				this.sgt_com_ploeginschrijving_afhandelingStateField = value;
				base.RaisePropertyChanged("Sgt_com_ploeginschrijving_afhandelingState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_com_ploeginschrijving_afhandelingStatus
		{
			get
			{
				return this.sgt_com_ploeginschrijving_afhandelingStatusField;
			}
			set
			{
				this.sgt_com_ploeginschrijving_afhandelingStatusField = value;
				base.RaisePropertyChanged("Sgt_com_ploeginschrijving_afhandelingStatus");
			}
		}

		public SetStateSgt_com_ploeginschrijving_afhandelingRequest()
		{
		}
	}
}