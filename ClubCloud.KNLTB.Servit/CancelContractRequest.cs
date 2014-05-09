using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class CancelContractRequest : Request
	{
		private Guid contractIdField;
		private CrmDateTime cancelDateField;
		private int statusField;
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
		public CrmDateTime CancelDate
		{
			get
			{
				return this.cancelDateField;
			}
			set
			{
				this.cancelDateField = value;
				base.RaisePropertyChanged("CancelDate");
			}
		}
		[XmlElement(Order = 2)]
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
	}
}
