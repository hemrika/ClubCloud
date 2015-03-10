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
	public class SetStateSgt_alg_schorsingRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_schorsingState sgt_alg_schorsingStateField;

		private int sgt_alg_schorsingStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_schorsingState Sgt_alg_schorsingState
		{
			get
			{
				return this.sgt_alg_schorsingStateField;
			}
			set
			{
				this.sgt_alg_schorsingStateField = value;
				base.RaisePropertyChanged("Sgt_alg_schorsingState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_alg_schorsingStatus
		{
			get
			{
				return this.sgt_alg_schorsingStatusField;
			}
			set
			{
				this.sgt_alg_schorsingStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_schorsingStatus");
			}
		}

		public SetStateSgt_alg_schorsingRequest()
		{
		}
	}
}