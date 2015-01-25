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
	public class SetStateSgt_com_competitietypeRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_com_competitietypeState sgt_com_competitietypeStateField;

		private int sgt_com_competitietypeStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_com_competitietypeState Sgt_com_competitietypeState
		{
			get
			{
				return this.sgt_com_competitietypeStateField;
			}
			set
			{
				this.sgt_com_competitietypeStateField = value;
				base.RaisePropertyChanged("Sgt_com_competitietypeState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_com_competitietypeStatus
		{
			get
			{
				return this.sgt_com_competitietypeStatusField;
			}
			set
			{
				this.sgt_com_competitietypeStatusField = value;
				base.RaisePropertyChanged("Sgt_com_competitietypeStatus");
			}
		}

		public SetStateSgt_com_competitietypeRequest()
		{
		}
	}
}