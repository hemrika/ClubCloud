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
	public class SetStateSgt_alg_baansoortRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_baansoortState sgt_alg_baansoortStateField;

		private int sgt_alg_baansoortStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_baansoortState Sgt_alg_baansoortState
		{
			get
			{
				return this.sgt_alg_baansoortStateField;
			}
			set
			{
				this.sgt_alg_baansoortStateField = value;
				base.RaisePropertyChanged("Sgt_alg_baansoortState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_alg_baansoortStatus
		{
			get
			{
				return this.sgt_alg_baansoortStatusField;
			}
			set
			{
				this.sgt_alg_baansoortStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_baansoortStatus");
			}
		}

		public SetStateSgt_alg_baansoortRequest()
		{
		}
	}
}