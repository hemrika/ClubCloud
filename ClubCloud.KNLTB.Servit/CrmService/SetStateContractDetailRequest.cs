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
	public class SetStateContractDetailRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.ContractDetailState contractDetailStateField;

		private int contractDetailStatusField;

		[XmlElement] //[XmlElement(Order=1)]
		public ClubCloud.KNLTB.ServIt.CrmService.ContractDetailState ContractDetailState
		{
			get
			{
				return this.contractDetailStateField;
			}
			set
			{
				this.contractDetailStateField = value;
				base.RaisePropertyChanged("ContractDetailState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int ContractDetailStatus
		{
			get
			{
				return this.contractDetailStatusField;
			}
			set
			{
				this.contractDetailStatusField = value;
				base.RaisePropertyChanged("ContractDetailStatus");
			}
		}

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

		public SetStateContractDetailRequest()
		{
		}
	}
}