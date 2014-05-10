using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateContractRequest : Request
	{
		private Guid entityIdField;
		private ContractState contractStateField;
		private int contractStatusField;
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
		public ContractState ContractState
		{
			get
			{
				return this.contractStateField;
			}
			set
			{
				this.contractStateField = value;
			}
		}
		public int ContractStatus
		{
			get
			{
				return this.contractStatusField;
			}
			set
			{
				this.contractStatusField = value;
			}
		}
	}
}
