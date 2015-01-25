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
	public class SetStateSgt_com_speelschema_wedstrijdRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_com_speelschema_wedstrijdState sgt_com_speelschema_wedstrijdStateField;

		private int sgt_com_speelschema_wedstrijdStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_com_speelschema_wedstrijdState Sgt_com_speelschema_wedstrijdState
		{
			get
			{
				return this.sgt_com_speelschema_wedstrijdStateField;
			}
			set
			{
				this.sgt_com_speelschema_wedstrijdStateField = value;
				base.RaisePropertyChanged("Sgt_com_speelschema_wedstrijdState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_com_speelschema_wedstrijdStatus
		{
			get
			{
				return this.sgt_com_speelschema_wedstrijdStatusField;
			}
			set
			{
				this.sgt_com_speelschema_wedstrijdStatusField = value;
				base.RaisePropertyChanged("Sgt_com_speelschema_wedstrijdStatus");
			}
		}

		public SetStateSgt_com_speelschema_wedstrijdRequest()
		{
		}
	}
}