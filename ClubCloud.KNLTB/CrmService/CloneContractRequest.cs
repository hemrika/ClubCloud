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
	public class CloneContractRequest : Request
	{
		private Guid contractIdField;

		private bool includeCanceledLinesField;

		private bool returnDynamicEntitiesField;

		[XmlElement] //[XmlElement(Order=0)]
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

		[XmlElement] //[XmlElement(Order=1)]
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

		public CloneContractRequest()
		{
		}
	}
}