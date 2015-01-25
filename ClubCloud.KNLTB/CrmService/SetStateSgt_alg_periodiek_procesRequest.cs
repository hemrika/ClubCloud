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
	public class SetStateSgt_alg_periodiek_procesRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_periodiek_procesState sgt_alg_periodiek_procesStateField;

		private int sgt_alg_periodiek_procesStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_periodiek_procesState Sgt_alg_periodiek_procesState
		{
			get
			{
				return this.sgt_alg_periodiek_procesStateField;
			}
			set
			{
				this.sgt_alg_periodiek_procesStateField = value;
				base.RaisePropertyChanged("Sgt_alg_periodiek_procesState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_alg_periodiek_procesStatus
		{
			get
			{
				return this.sgt_alg_periodiek_procesStatusField;
			}
			set
			{
				this.sgt_alg_periodiek_procesStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_periodiek_procesStatus");
			}
		}

		public SetStateSgt_alg_periodiek_procesRequest()
		{
		}
	}
}