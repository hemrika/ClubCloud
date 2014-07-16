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
	public class SetStateSgt_alg_competentieRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_competentieState sgt_alg_competentieStateField;

		private int sgt_alg_competentieStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_competentieState Sgt_alg_competentieState
		{
			get
			{
				return this.sgt_alg_competentieStateField;
			}
			set
			{
				this.sgt_alg_competentieStateField = value;
				base.RaisePropertyChanged("Sgt_alg_competentieState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_alg_competentieStatus
		{
			get
			{
				return this.sgt_alg_competentieStatusField;
			}
			set
			{
				this.sgt_alg_competentieStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_competentieStatus");
			}
		}

		public SetStateSgt_alg_competentieRequest()
		{
		}
	}
}