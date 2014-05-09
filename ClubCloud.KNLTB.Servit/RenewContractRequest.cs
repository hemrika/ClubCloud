using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class RenewContractRequest : Request
	{
		private Guid contractIdField;
		private int statusField;
		private bool includeCanceledLinesField;
		private bool returnDynamicEntitiesField;
		[XmlElement(Order = 0)]
		public Guid ContractId
		{
			get
			{
				return this.contractIdField;
			}
			set
			{
				this.contractIdField = value;
				base.RaisePropertyChanged("ContractId");
			}
		}
		[XmlElement(Order = 1)]
		public int Status
		{
			get
			{
				return this.statusField;
			}
			set
			{
				this.statusField = value;
				base.RaisePropertyChanged("Status");
			}
		}
		[XmlElement(Order = 2)]
		public bool IncludeCanceledLines
		{
			get
			{
				return this.includeCanceledLinesField;
			}
			set
			{
				this.includeCanceledLinesField = value;
				base.RaisePropertyChanged("IncludeCanceledLines");
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
				base.RaisePropertyChanged("ReturnDynamicEntities");
			}
		}
	}
}
