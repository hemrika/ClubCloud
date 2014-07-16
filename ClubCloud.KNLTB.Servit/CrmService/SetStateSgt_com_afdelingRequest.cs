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
	public class SetStateSgt_com_afdelingRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_com_afdelingState sgt_com_afdelingStateField;

		private int sgt_com_afdelingStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_com_afdelingState Sgt_com_afdelingState
		{
			get
			{
				return this.sgt_com_afdelingStateField;
			}
			set
			{
				this.sgt_com_afdelingStateField = value;
				base.RaisePropertyChanged("Sgt_com_afdelingState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_com_afdelingStatus
		{
			get
			{
				return this.sgt_com_afdelingStatusField;
			}
			set
			{
				this.sgt_com_afdelingStatusField = value;
				base.RaisePropertyChanged("Sgt_com_afdelingStatus");
			}
		}

		public SetStateSgt_com_afdelingRequest()
		{
		}
	}
}