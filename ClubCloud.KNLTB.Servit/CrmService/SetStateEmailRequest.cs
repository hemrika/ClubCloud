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
	public class SetStateEmailRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.EmailState emailStateField;

		private int emailStatusField;

		[XmlElement] //[XmlElement(Order=1)]
		public ClubCloud.KNLTB.ServIt.CrmService.EmailState EmailState
		{
			get
			{
				return this.emailStateField;
			}
			set
			{
				this.emailStateField = value;
				base.RaisePropertyChanged("EmailState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int EmailStatus
		{
			get
			{
				return this.emailStatusField;
			}
			set
			{
				this.emailStatusField = value;
				base.RaisePropertyChanged("EmailStatus");
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

		public SetStateEmailRequest()
		{
		}
	}
}