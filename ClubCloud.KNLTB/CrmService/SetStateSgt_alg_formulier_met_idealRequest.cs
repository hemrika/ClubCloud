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
	public class SetStateSgt_alg_formulier_met_idealRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_formulier_met_idealState sgt_alg_formulier_met_idealStateField;

		private int sgt_alg_formulier_met_idealStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_formulier_met_idealState Sgt_alg_formulier_met_idealState
		{
			get
			{
				return this.sgt_alg_formulier_met_idealStateField;
			}
			set
			{
				this.sgt_alg_formulier_met_idealStateField = value;
				base.RaisePropertyChanged("Sgt_alg_formulier_met_idealState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_alg_formulier_met_idealStatus
		{
			get
			{
				return this.sgt_alg_formulier_met_idealStatusField;
			}
			set
			{
				this.sgt_alg_formulier_met_idealStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_formulier_met_idealStatus");
			}
		}

		public SetStateSgt_alg_formulier_met_idealRequest()
		{
		}
	}
}