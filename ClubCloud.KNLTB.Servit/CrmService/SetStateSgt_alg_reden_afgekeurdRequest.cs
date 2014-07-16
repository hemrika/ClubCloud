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
	public class SetStateSgt_alg_reden_afgekeurdRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_reden_afgekeurdState sgt_alg_reden_afgekeurdStateField;

		private int sgt_alg_reden_afgekeurdStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_reden_afgekeurdState Sgt_alg_reden_afgekeurdState
		{
			get
			{
				return this.sgt_alg_reden_afgekeurdStateField;
			}
			set
			{
				this.sgt_alg_reden_afgekeurdStateField = value;
				base.RaisePropertyChanged("Sgt_alg_reden_afgekeurdState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_alg_reden_afgekeurdStatus
		{
			get
			{
				return this.sgt_alg_reden_afgekeurdStatusField;
			}
			set
			{
				this.sgt_alg_reden_afgekeurdStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_reden_afgekeurdStatus");
			}
		}

		public SetStateSgt_alg_reden_afgekeurdRequest()
		{
		}
	}
}