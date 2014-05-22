using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class RenewContractRequest : Request
	{
		private Guid contractIdField;
		private int statusField;
		private bool includeCanceledLinesField;
		private bool returnDynamicEntitiesField;
		public Guid ContractId
		{
			get
			{
				return this.contractIdField;
			}
			set
			{
				this.contractIdField = value;
			}
		}
		public int Status
		{
			get
			{
				return this.statusField;
			}
			set
			{
				this.statusField = value;
			}
		}
		public bool IncludeCanceledLines
		{
			get
			{
				return this.includeCanceledLinesField;
			}
			set
			{
				this.includeCanceledLinesField = value;
			}
		}
		[XmlAttribute]
		public bool ReturnDynamicEntities
		{
			get
			{
				return this.returnDynamicEntitiesField;
			}
			set
			{
				this.returnDynamicEntitiesField = value;
			}
		}
	}
}