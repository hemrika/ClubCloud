using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateContractDetailRequest : Request
	{
		private Guid entityIdField;
		private ContractDetailState contractDetailStateField;
		private int contractDetailStatusField;
		public Guid EntityId
		{
			get
			{
				return this.entityIdField;
			}
			set
			{
				this.entityIdField = value;
			}
		}
		public ContractDetailState ContractDetailState
		{
			get
			{
				return this.contractDetailStateField;
			}
			set
			{
				this.contractDetailStateField = value;
			}
		}
		public int ContractDetailStatus
		{
			get
			{
				return this.contractDetailStatusField;
			}
			set
			{
				this.contractDetailStatusField = value;
			}
		}
	}
}
