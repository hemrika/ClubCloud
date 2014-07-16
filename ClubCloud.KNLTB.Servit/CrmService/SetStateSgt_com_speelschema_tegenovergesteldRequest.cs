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
	public class SetStateSgt_com_speelschema_tegenovergesteldRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_com_speelschema_tegenovergesteldState sgt_com_speelschema_tegenovergesteldStateField;

		private int sgt_com_speelschema_tegenovergesteldStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_com_speelschema_tegenovergesteldState Sgt_com_speelschema_tegenovergesteldState
		{
			get
			{
				return this.sgt_com_speelschema_tegenovergesteldStateField;
			}
			set
			{
				this.sgt_com_speelschema_tegenovergesteldStateField = value;
				base.RaisePropertyChanged("Sgt_com_speelschema_tegenovergesteldState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_com_speelschema_tegenovergesteldStatus
		{
			get
			{
				return this.sgt_com_speelschema_tegenovergesteldStatusField;
			}
			set
			{
				this.sgt_com_speelschema_tegenovergesteldStatusField = value;
				base.RaisePropertyChanged("Sgt_com_speelschema_tegenovergesteldStatus");
			}
		}

		public SetStateSgt_com_speelschema_tegenovergesteldRequest()
		{
		}
	}
}