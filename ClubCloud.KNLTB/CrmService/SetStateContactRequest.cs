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
	public class SetStateContactRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.ContactState contactStateField;

		private int contactStatusField;

		[XmlElement] //[XmlElement(Order=1)]
		public ClubCloud.KNLTB.ServIt.CrmService.ContactState ContactState
		{
			get
			{
				return this.contactStateField;
			}
			set
			{
				this.contactStateField = value;
				base.RaisePropertyChanged("ContactState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int ContactStatus
		{
			get
			{
				return this.contactStatusField;
			}
			set
			{
				this.contactStatusField = value;
				base.RaisePropertyChanged("ContactStatus");
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

		public SetStateContactRequest()
		{
		}
	}
}