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
	public class SetStateAccountRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.AccountState accountStateField;

		private int accountStatusField;

		[XmlElement] //[XmlElement(Order=1)]
		public ClubCloud.KNLTB.ServIt.CrmService.AccountState AccountState
		{
			get
			{
				return this.accountStateField;
			}
			set
			{
				this.accountStateField = value;
				base.RaisePropertyChanged("AccountState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int AccountStatus
		{
			get
			{
				return this.accountStatusField;
			}
			set
			{
				this.accountStatusField = value;
				base.RaisePropertyChanged("AccountStatus");
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

		public SetStateAccountRequest()
		{
		}
	}
}