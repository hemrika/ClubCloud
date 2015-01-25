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
	public class SetStateSgt_alg_melding_maatwerkRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_melding_maatwerkState sgt_alg_melding_maatwerkStateField;

		private int sgt_alg_melding_maatwerkStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_melding_maatwerkState Sgt_alg_melding_maatwerkState
		{
			get
			{
				return this.sgt_alg_melding_maatwerkStateField;
			}
			set
			{
				this.sgt_alg_melding_maatwerkStateField = value;
				base.RaisePropertyChanged("Sgt_alg_melding_maatwerkState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_alg_melding_maatwerkStatus
		{
			get
			{
				return this.sgt_alg_melding_maatwerkStatusField;
			}
			set
			{
				this.sgt_alg_melding_maatwerkStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_melding_maatwerkStatus");
			}
		}

		public SetStateSgt_alg_melding_maatwerkRequest()
		{
		}
	}
}