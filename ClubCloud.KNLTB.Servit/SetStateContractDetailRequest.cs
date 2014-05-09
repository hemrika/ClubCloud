using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateContractDetailRequest : Request
	{
		private Guid entityIdField;
		private ContractDetailState contractDetailStateField;
		private int contractDetailStatusField;
		[XmlElement(Order = 0)]
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
		[XmlElement(Order = 1)]
		public ContractDetailState ContractDetailState
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
		[XmlElement(Order = 2)]
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
	}
}
